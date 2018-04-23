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
using DevExpress.Web.ASPxGridView;

namespace WebApplication11
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       

        protected void ASPxGridView1_DataBound(object sender, EventArgs e)
        {
            ASPxSummaryItem item = ((ASPxGridView)sender).TotalSummary["UnitPrice"] as ASPxSummaryItem;
            object val = ASPxGridView1.GetTotalSummaryValue(item);
            GridViewDataColumn col = ((ASPxGridView)sender).Columns["UnitPrice"] as GridViewDataColumn;
            HtmlAnchor lnk = ((ASPxGridView)sender).FindFooterCellTemplateControl(col, "summaryLink") as HtmlAnchor;
            lnk.InnerText = "The total price is $ " + val.ToString();
            lnk.HRef = "TestPage.aspx?TotalPrice=" + val.ToString();


        }

       
    }
}
