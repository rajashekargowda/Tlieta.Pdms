using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;
using Tlieta.Pdms.Properties;

namespace Tlieta.Pdms
{
    public partial class Form1 : RadForm
    {
        public const int WM_SIZE = 5;

        private LightVisualElement examplePage;
        private RadImageItem backButton;
        private RadImageItem logoTlietaHeader;
        private RadImageItem logoTlieta;
        private LightVisualElement headerLabel;
        private LightVisualElement serialLabel;
        private LightVisualElement doctorLabel;
        private LightVisualElement suffixLabel;
        private LightVisualElement suffix2Label;
        private LightVisualElement suffix3Label;
        private LightVisualElement suffix4Label;
        private RadTitleBarElement titleBar;

        private string serialKey = "";

        private bool isFormMoving = false;
        private string currentExample = string.Empty;
        private Dictionary<string, UserControl> exampleControls;

        #region Initialization

        public Form1(string pSerialkey)
        {
            InitializeComponent();

            this.serialKey = pSerialkey;

            new TelerikMetroTheme();
            this.ThemeName = "Panorama";

            this.radPanorama1.ThemeName = "Panorama";
            this.radPanorama1.ScrollingBackground = true;
            this.radPanorama1.PanelImage = Resources.bg_pattern;
            this.radPanorama1.PanoramaElement.BackgroundImagePrimitive.ImageLayout = ImageLayout.Tile;
            this.radPanorama1.SizeChanged += new EventHandler(radTilePanel1_SizeChanged);
            this.radPanorama1.ScrollBarAlignment = HorizontalScrollAlignment.Bottom;
            this.radPanorama1.ScrollBarThickness = 10;
            this.radPanorama1.PanoramaElement.GradientStyle = GradientStyles.Solid;
            this.radPanorama1.PanoramaElement.DrawFill = true;
            this.radPanorama1.PanoramaElement.BackColor = System.Drawing.Color.FromArgb(1, 23, 117);
            this.FormElement.TitleBar.MaxSize = new Size(0, 1);
            this.Text = ConfigurationSettings.AppSettings["ApplicationLabel"].ToString();

            this.PrepareHeader();
            this.PrepareTitleBar();
            this.PrepareFooter();
            this.PrepareLogo();
            this.PreparePages();
        }

        private void PreparePages()
        {
            examplePage = new LightVisualElement();
            examplePage.DrawText = false;
            examplePage.DrawFill = true;
            examplePage.BackColor = Color.White;
            examplePage.GradientStyle = GradientStyles.Solid;
            examplePage.Visibility = ElementVisibility.Collapsed;
            this.radPanorama1.PanoramaElement.Children.Add(examplePage);
            examplePage.Margin = new Padding(0, 140, 0, 0);

            this.exampleControls = new Dictionary<string, UserControl>();
            this.exampleControls.Add("Add Patient", new Tlieta.Pdms.Views.Shared.EditPatient(0));
            this.exampleControls.Add("Patient LookUp", new Tlieta.Pdms.Views.Shared.SearchPatient());
            this.exampleControls.Add("Settings", new Tlieta.Pdms.Views.Shared.Settings(serialKey));
            this.exampleControls.Add("Statistics", new Tlieta.Pdms.Views.Shared.Statistics());
            this.exampleControls.Add("LogBook", new Tlieta.Pdms.Views.Shared.LogBook());
            this.exampleControls.Add("Appointments", new Tlieta.Pdms.Views.Shared.Appointment());
            this.exampleControls.Add("Income/Expense Daybook", new Tlieta.Pdms.Views.Shared.FinanceDaybook());
            this.exampleControls.Add("Certificates", new Tlieta.Pdms.Views.Shared.Certificates());
            this.exampleControls.Add("Contacts", new Tlieta.Pdms.Views.Shared.Contacts());
            this.exampleControls.Add("Letters", new Tlieta.Pdms.Views.Shared.Letters());
            this.PreloadControls();
        }

        private void PreloadControls()
        {
            foreach (KeyValuePair<string, UserControl> entry in this.exampleControls)
            {
                this.Controls.Add(entry.Value);
                entry.Value.Location = new Point(120, 180);
            }
        }

        private void PrepareTitleBar()
        {
            titleBar = new RadTitleBarElement();

            titleBar.FillPrimitive.Visibility = ElementVisibility.Hidden;
            titleBar.MaxSize = new Size(0, 30);
            titleBar.Children[1].Visibility = ElementVisibility.Hidden;

            titleBar.CloseButton.Parent.PositionOffset = new SizeF(0, 5);
            titleBar.CloseButton.MinSize = new Size(50, 50);
            titleBar.CloseButton.ButtonFillElement.Visibility = ElementVisibility.Collapsed;

            titleBar.MinimizeButton.MinSize = new Size(50, 50);
            titleBar.MinimizeButton.ButtonFillElement.Visibility = ElementVisibility.Collapsed;

            titleBar.MaximizeButton.MinSize = new Size(50, 50);
            titleBar.MaximizeButton.ButtonFillElement.Visibility = ElementVisibility.Collapsed;

            titleBar.CloseButton.SetValue(RadFormElement.IsFormActiveProperty, true);
            titleBar.MinimizeButton.SetValue(RadFormElement.IsFormActiveProperty, true);
            titleBar.MaximizeButton.SetValue(RadFormElement.IsFormActiveProperty, true);

            titleBar.Close += new TitleBarSystemEventHandler(titleBar_Close);
            titleBar.Minimize += new TitleBarSystemEventHandler(titleBar_Minimize);
            titleBar.MaximizeRestore += new TitleBarSystemEventHandler(titleBar_MaximizeRestore);
            this.radPanorama1.PanoramaElement.PanGesture += new PanGestureEventHandler(radTilePanel1_PanGesture);
            this.radPanorama1.PanoramaElement.Children.Add(titleBar);
        }

        protected override void OnShown(EventArgs e)
        {
            this.radTilePanel1_SizeChanged(this, EventArgs.Empty);
            foreach (KeyValuePair<string, UserControl> entry in this.exampleControls)
            {
                entry.Value.PerformLayout();
                this.Controls.Remove(entry.Value);
            }

            base.OnShown(e);
        }

        private void PrepareHeader()
        {
            StackLayoutElement headerLayout = new StackLayoutElement();
            headerLayout.Orientation = Orientation.Horizontal;
            headerLayout.Margin = new System.Windows.Forms.Padding(0, 35, 0, 0);
            headerLayout.NotifyParentOnMouseInput = true;
            headerLayout.ShouldHandleMouseInput = false;
            headerLayout.StretchHorizontally = false;

            this.backButton = new RadImageItem();
            this.backButton.Margin = new Padding(40, 0, 28, 0);
            this.backButton.Click += new EventHandler(backButton_Click);
            this.backButton.Visibility = ElementVisibility.Hidden;
            this.backButton.Image = Tlieta.Pdms.Properties.Resources.back;
            this.backButton.BackColor = Color.Transparent;
            this.backButton.BorderThickness = new Padding(0, 0, 0, 0);
            headerLayout.Children.Add(this.backButton);

            this.headerLabel = new LightVisualElement();
            this.headerLabel.Text = ConfigurationSettings.AppSettings["ApplicationLabel"].ToString();
            this.headerLabel.Font = new Font("Segoe UI Light", 42, GraphicsUnit.Point);
            this.headerLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.headerLabel.ForeColor = Color.White;
            this.headerLabel.TextAlignment = ContentAlignment.MiddleLeft;
            this.headerLabel.MaxSize = new Size(1030, 110);
            this.headerLabel.NotifyParentOnMouseInput = true;
            this.headerLabel.ShouldHandleMouseInput = false;
            this.headerLabel.StretchHorizontally = false;
            headerLayout.Children.Add(this.headerLabel);

            StackLayoutElement headerLogo = new StackLayoutElement();
            headerLogo.Margin = new System.Windows.Forms.Padding(1220, 60, 0, 0);
            headerLogo.StretchHorizontally = false;

            this.logoTlietaHeader = new RadImageItem();
            this.logoTlietaHeader.Image = Tlieta.Pdms.Properties.Resources.TLIETA90;
            this.logoTlietaHeader.BackColor = Color.Transparent;
            this.logoTlietaHeader.Margin = new Padding(0, 0, 20, 0);
            this.logoTlietaHeader.BorderThickness = new Padding(0, 0, 0, 0);
            headerLogo.Children.Add(this.logoTlietaHeader);

            this.radPanorama1.PanoramaElement.Children.Add(headerLayout);
            this.radPanorama1.PanoramaElement.Children.Add(headerLogo);
        }

        private void PrepareFooter()
        {
            StackLayoutElement footerLayout = new StackLayoutElement();
            footerLayout.Orientation = Orientation.Horizontal;
            footerLayout.Margin = new System.Windows.Forms.Padding(700, 600, 0, 0);
            footerLayout.StretchHorizontally = false;

            this.doctorLabel = new LightVisualElement();
            this.doctorLabel.Text = ConfigurationSettings.AppSettings["Doctor"].ToString();
            this.doctorLabel.Font = new Font("Segoe UI Light", 45, GraphicsUnit.Point);
            this.doctorLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.doctorLabel.ForeColor = Color.White;
            this.doctorLabel.TextAlignment = ContentAlignment.MiddleLeft;
            this.doctorLabel.StretchHorizontally = false;
            footerLayout.Children.Add(this.doctorLabel);

            StackLayoutElement serialLayout = new StackLayoutElement();
            serialLayout.Orientation = Orientation.Vertical;
            serialLayout.Margin = new System.Windows.Forms.Padding(750, 680, 0, 0);
            serialLayout.StretchHorizontally = false;
            
            this.suffixLabel = new LightVisualElement();
            this.suffixLabel.Text = ConfigurationSettings.AppSettings["Suffix"].ToString();
            this.suffixLabel.Font = new Font("Segoe UI Light", 15, GraphicsUnit.Point);
            this.suffixLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.suffixLabel.ForeColor = Color.White;
            this.suffixLabel.TextAlignment = ContentAlignment.MiddleLeft;
            this.suffixLabel.StretchHorizontally = false;
            serialLayout.Children.Add(this.suffixLabel);

            this.suffix2Label = new LightVisualElement();
            this.suffix2Label.Text = ConfigurationSettings.AppSettings["Suffix2"].ToString();
            this.suffix2Label.Font = new Font("Segoe UI Light", 15, GraphicsUnit.Point);
            this.suffix2Label.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.suffix2Label.ForeColor = Color.White;
            this.suffix2Label.TextAlignment = ContentAlignment.MiddleLeft;
            this.suffix2Label.StretchHorizontally = false;
            serialLayout.Children.Add(this.suffix2Label);

            //this.suffix3Label = new LightVisualElement();
            //this.suffix3Label.Text = ConfigurationSettings.AppSettings["Suffix3"].ToString();
            //this.suffix3Label.Font = new Font("Segoe UI Light", 15, GraphicsUnit.Point);
            //this.suffix3Label.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            //this.suffix3Label.ForeColor = Color.White;
            //this.suffix3Label.TextAlignment = ContentAlignment.MiddleLeft;
            //this.suffix3Label.StretchHorizontally = false;
            //serialLayout.Children.Add(this.suffix3Label);

            //this.suffix4Label = new LightVisualElement();
            //this.suffix4Label.Text = ConfigurationSettings.AppSettings["Suffix4"].ToString();
            //this.suffix4Label.Font = new Font("Segoe UI Light", 15, GraphicsUnit.Point);
            //this.suffix4Label.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            //this.suffix4Label.ForeColor = Color.White;
            //this.suffix4Label.TextAlignment = ContentAlignment.MiddleLeft;
            //this.suffix4Label.StretchHorizontally = false;
            //serialLayout.Children.Add(this.suffix4Label);

            this.radPanorama1.PanoramaElement.Children.Add(footerLayout);
            this.radPanorama1.PanoramaElement.Children.Add(serialLayout);
        }

        private void PrepareLogo()
        {
            StackLayoutElement logoLayout = new StackLayoutElement();
            logoLayout.Orientation = Orientation.Horizontal;
            logoLayout.Margin = new System.Windows.Forms.Padding(120, 645, 0, 0);
            logoLayout.StretchHorizontally = false;

            this.logoTlieta = new RadImageItem();
            this.logoTlieta.Image = Tlieta.Pdms.Properties.Resources.TLIETA250;
            this.logoTlieta.BackColor = Color.Transparent;
            this.logoTlieta.BorderThickness = new Padding(0, 0, 0, 0);
            logoLayout.Children.Add(this.logoTlieta);

            this.radPanorama1.PanoramaElement.Children.Add(logoLayout);
        }

        #endregion

        #region Event Handlers

        void radTilePanel1_SizeChanged(object sender, EventArgs e)
        {
            int width = this.radPanorama1.Width + Math.Max((this.radPanorama1.PanoramaElement.ScrollBar.Maximum - this.radPanorama1.Width) / 4, 1);
            this.radPanorama1.PanelImageSize = new Size(width, 768);
            this.radPanorama1.PanoramaElement.UpdateViewOnScroll();

            UpdateExampleControlPosition();
        }

        void radTilePanel1_PanGesture(object sender, PanGestureEventArgs e)
        {
            if (e.IsBegin && this.titleBar.ControlBoundingRectangle.Contains(e.Location))
            {
                isFormMoving = true;
            }

            if (isFormMoving)
            {
                this.Location = new Point(this.Location.X + e.Offset.Width, this.Location.Y + e.Offset.Height);
            }
            else
            {
                e.Handled = false;
            }

            if (e.IsEnd)
            {
                isFormMoving = false;
            }
        }

        void backButton_Click(object sender, EventArgs e)
        {
            UnloadExample();
        }

        void titleBar_MaximizeRestore(object sender, EventArgs args)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        void titleBar_Minimize(object sender, EventArgs args)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void titleBar_Close(object sender, EventArgs args)
        {
            Application.Exit();
        }

        private void settingsTile_Click(object sender, EventArgs e)
        {
            LoadExample("Settings");
        }

        private void addPatientTile_Click(object sender, EventArgs e)
        {
            LoadExample("Add Patient");
        }

        private void patientlookupTile_Click(object sender, EventArgs e)
        {
            LoadExample("Patient LookUp");
        }

        private void statisticsTile_Click(object sender, EventArgs e)
        {
            LoadExample("Statistics");
        }

        private void logBookTile_Click(object sender, EventArgs e)
        {
            LoadExample("LogBook");
        }

        private void radTileAppointments_Click(object sender, EventArgs e)
        {
            LoadExample("Appointments");
        }

        private void radTileDaybook_Click(object sender, EventArgs e)
        {
            LoadExample("Income/Expense Daybook");
        }

        private void radTileCertificates_Click(object sender, EventArgs e)
        {
            LoadExample("Certificates");
        }

        private void radTileContacts_Click(object sender, EventArgs e)
        {
            LoadExample("Contacts");
        }

        private void radTileLetters_Click(object sender, EventArgs e)
        {
            LoadExample("Letters");
        }
        
        #endregion

        private void LoadExample(string exampleName)
        {
            if (currentExample != string.Empty)
            {
                return;
            }

            this.currentExample = exampleName;

            this.headerLabel.Text = this.currentExample;
            this.backButton.Visibility = ElementVisibility.Visible;

            this.examplePage.PositionOffset = new SizeF(-this.radPanorama1.Width, 0);
            examplePage.Visibility = ElementVisibility.Visible;
            AnimatedPropertySetting setting =
            new AnimatedPropertySetting(RadElement.PositionOffsetProperty,
                                        new SizeF(-this.radPanorama1.Width, 0),
                                        SizeF.Empty, (int)(10d * 800d / this.Width), 10);

            setting.AnimationFinished += new AnimationFinishedEventHandler(OnExampleOpened);
            setting.ApplyValue(this.examplePage);
        }

        private void UnloadExample()
        {
            this.Controls.Remove(this.GetCurrentExampleControl());

            this.backButton.Visibility = ElementVisibility.Hidden;
            this.headerLabel.Text = ConfigurationSettings.AppSettings["ApplicationLabel"].ToString();

            this.examplePage.PositionOffset = new SizeF(-this.radPanorama1.Width, 0);
            examplePage.Visibility = ElementVisibility.Visible;
            AnimatedPropertySetting setting =
            new AnimatedPropertySetting(RadElement.PositionOffsetProperty,
                                        SizeF.Empty,
                                        new SizeF(-this.radPanorama1.Width, 0),
                                        (int)(10d * 1000d / this.Width), 10);

            setting.AnimationFinished += new AnimationFinishedEventHandler(OnExampleClosed);
            setting.ApplyValue(this.examplePage);
        }

        private void OnExampleOpened(object sender, AnimationStatusEventArgs e)
        {
            UserControl ctrl = this.GetCurrentExampleControl();
            if (ctrl != null)
            {
                this.Controls.Add(ctrl);
                ctrl.BringToFront();
                this.UpdateExampleControlPosition();
            }
        }

        private void OnExampleClosed(object sender, AnimationStatusEventArgs e)
        {
            ((AnimatedPropertySetting)sender).AnimationFinished -= OnExampleClosed;
            this.examplePage.Visibility = ElementVisibility.Collapsed;
            this.currentExample = string.Empty;
        }

        private void UpdateExampleControlPosition()
        {
            UserControl ctrl = this.GetCurrentExampleControl();
            if (ctrl != null)
            {
                ctrl.Bounds = new Rectangle(
                    new Point(10, this.examplePage.ControlBoundingRectangle.Y + 10),
                    new Size(1300, 600));
                //new Size(this.Width - 180, this.Height - this.examplePage.ControlBoundingRectangle.Y - 120));
            }
        }

        private UserControl GetCurrentExampleControl()
        {
            if (this.currentExample != "" && this.exampleControls.ContainsKey(this.currentExample))
            {
                return this.exampleControls[this.currentExample];
            }

            return null;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SIZE)
            {
                titleBar.CloseButton.SetValue(RadFormElement.FormWindowStateProperty, this.WindowState);
                titleBar.MinimizeButton.SetValue(RadFormElement.FormWindowStateProperty, this.WindowState);
                titleBar.MaximizeButton.SetValue(RadFormElement.FormWindowStateProperty, this.WindowState);
            }

            base.WndProc(ref m);
        }

        protected override FormControlBehavior InitializeFormBehavior()
        {
            return new MyFormBehavior(this, true);
        }
    }
}
