using System;
using System.Web.Services;

namespace LD2.VirtualPlaybook
{
    public partial class view : VirtualPlaybookModuleBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        [WebMethod]
        public static string GetCurrentTime()
        {
            return "The current time is: " + DateTime.Now.ToString();
        }
    }
}