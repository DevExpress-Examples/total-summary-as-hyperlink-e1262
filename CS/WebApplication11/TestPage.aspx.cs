using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace WebApplication11
{
    public partial class TestPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["TotalPrice"] == null)
            {
                ASPxLabel1.BackColor = System.Drawing.Color.Red;
                ASPxLabel1.Text = "Required request parameter is empty. Test is failed, sorry =( Please go to the previous page and try again";
            }
            else
            {
                ASPxLabel1.BackColor = System.Drawing.Color.LightSeaGreen;
                ASPxLabel1.Text = "Total price is $ " + Request.Params[0];
            }
           
        }
    }
}
