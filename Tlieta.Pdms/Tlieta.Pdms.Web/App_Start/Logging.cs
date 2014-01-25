using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using Tlieta.Pdms.Web.Models;

namespace Tlieta.Pdms.Web
{
    public static class Logging
    {
        public static void LogError(Exception oEx)
        {
            try
            {
                HandleException(oEx);
            }
            catch (Exception exc)
            {
                EventLog.WriteEntry(exc.Source, "Error From Exception Log", EventLogEntryType.Error, 65535);
            }
        }

        static void HandleException(Exception ex)
        {
            HttpContext ctxObject = HttpContext.Current;
            if (ctxObject != null)
            {
                DateTime logDateTime = DateTime.Now;
                string strReqURL = (ctxObject.Request.Url != null) ? ctxObject.Request.Url.ToString() : String.Empty;
                string strReqQS = (ctxObject.Request.QueryString != null) ? ctxObject.Request.QueryString.ToString() : String.Empty;
                string strServerName = String.Empty;
                if (ctxObject.Request.ServerVariables["HTTP_REFERER"] != null)
                {
                    strServerName = ctxObject.Request.ServerVariables["HTTP_REFERER"].ToString();
                }
                string strUserAgent = (ctxObject.Request.UserAgent != null) ? ctxObject.Request.UserAgent : String.Empty;
                string strUserIP = (ctxObject.Request.UserHostAddress != null) ? ctxObject.Request.UserHostAddress : String.Empty;
                string strUserAuthen = (ctxObject.User.Identity.IsAuthenticated.ToString() != null) ? ctxObject.User.Identity.IsAuthenticated.ToString() : String.Empty;
                string strUserName = (ctxObject.User.Identity.Name != null) ? ctxObject.User.Identity.Name : String.Empty;
                string strMessage = string.Empty, strSource = string.Empty, strTargetSite = string.Empty, strStackTrace = string.Empty;
                while (ex != null)
                {

                    strMessage = ex.Message;
                    strSource = ex.Source;
                    strTargetSite = ex.TargetSite.ToString();
                    strStackTrace = ex.StackTrace;
                    ex = ex.InnerException;
                }

                try
                {
                    ErrorLog model = new ErrorLog()
                    {
                        Source = strSource,
                        LogDate = logDateTime,
                        Message = strMessage,
                        QueryString = strReqQS,
                        TargetSite = strTargetSite,
                        StackTrace = strStackTrace,
                        ServerName = strServerName,
                        RequestUrl = strReqURL,
                        UserAgent = strUserAgent,
                        UserIP = strUserIP,
                        UserAuthentication = strUserAuthen,
                        UserName = strUserName
                    };
                    bool result = new ErrorLogData().Add(model);
                }
                catch (Exception exc)
                {
                    EventLog.WriteEntry(exc.Source, "Database Error From Exception Log", EventLogEntryType.Error, 65535);
                }
            }
        }
    }
}
