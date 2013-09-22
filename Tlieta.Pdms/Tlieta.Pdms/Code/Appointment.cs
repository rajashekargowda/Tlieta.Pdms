using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tlieta.Pdms.Views.Shared
{
    public class Appointment 
    {
        private DateTime start = DateTime.Now;
        private DateTime end = DateTime.Now;
        private string summary = string.Empty;
        private string description = string.Empty;
        private string location = string.Empty;
        private int id = 0;

        public Appointment()
        {
        }

        public Appointment(int id, DateTime start, DateTime end, string summary, string description, string location)
        {
            this.id = id;
            this.start = start;
            this.end = end;
            this.summary = summary;
            this.description = description;
            this.location = location;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (this.id != value)
                {
                    this.id = value;
                }
            }
        }

        public DateTime Start
        {
            get
            {
                return this.start;
            }
            set
            {
                if (this.start != value)
                {
                    this.start = value;
                }
            }
        }

        public DateTime End
        {
            get
            {
                return this.end;
            }
            set
            {
                if (this.end != value)
                {
                    this.end = value;
                }
            }
        }

        public string Summary
        {
            get
            {
                return this.summary;
            }
            set
            {
                if (this.summary != value)
                {
                    this.summary = value;
                }
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                if (this.description != value)
                {
                    this.description = value;
                }
            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }
            set
            {
                if (this.location != value)
                {
                    this.location = value;
                }
            }
        }
    }
}
