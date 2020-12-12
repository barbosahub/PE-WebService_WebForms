using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WFCorreios
{
    public partial class SiteMaster : MasterPage
    {

        public enum Alert_CSS
        {
            danger, sucess, info, warning
        }

                     

        public void message(string message, Alert_CSS alert)
        {
            string css = "";
            switch (alert)
            {
                case Alert_CSS.danger:
                    css = "alert alert-danger alert-dismissable";
                    break;
                case Alert_CSS.sucess:
                    css = "alert alert-success alert-dismissable";
                    break;
                case Alert_CSS.info:
                    css = "alert alert-info alert-dismissable";
                    break;
                case Alert_CSS.warning:
                    css = "alert alert-warning alert-dismissable";
                    break;
                default:
                    break;
            }
            litMsg.Text = message;
            updMsg.Visible = true;
            litCss.Text = css;
            btnClose.Text = "x";
            updMsg.Update();

        }


        public void hidemessage()
        {
            litMsg.Text = "";
            updMsg.Visible = true;
            litCss.Text = "";
            btnClose.Text = "";
            updMsg.Update();
        }

    }
}