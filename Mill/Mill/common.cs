using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormToImage
{
    public class common
    {
        public static string ID { get; set; }
        public static string SchoolID { get; set; }
        public static bool CheckLicence()
        {
            string dateInstalled =
               (string)Application.UserAppDataRegistry.GetValue("installeddate",
                              string.Empty);
            if (dateInstalled == "")
                Application.UserAppDataRegistry.SetValue("installeddate", System.DateTime.Now.ToShortDateString().ToString());

            string strLicence = (string)Application.UserAppDataRegistry.GetValue("licence",
                               string.Empty);
            string dateIstalledDate = (string)Application.UserAppDataRegistry.GetValue("installeddate", string.Empty);

            bool registered = false;
            if (strLicence == "ECAEE7303BA8D4C535C2DFCDEE3AEAA41EA223CB")
                registered = true;

            bool retValue = false;
             
                if (Convert.ToDateTime(dateIstalledDate).AddDays(7) < System.DateTime.Now)
                {
                    MessageBox.Show("Please contact to Mr. bcdSSSS \n Mobile: 1231231233;");
                    retValue = false;
                }
                else
                {
                    retValue =true;
                }
             
            return retValue;

        }
    }
    
}
