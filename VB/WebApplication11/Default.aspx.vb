Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxGridView

Namespace WebApplication11
    Partial Public Class _Default
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

        End Sub


        Protected Sub ASPxGridView1_DataBound(ByVal sender As Object, ByVal e As EventArgs)
            Dim item As ASPxSummaryItem = TryCast(DirectCast(sender, ASPxGridView).TotalSummary("UnitPrice"), ASPxSummaryItem)
            Dim val As Object = ASPxGridView1.GetTotalSummaryValue(item)
            Dim col As GridViewDataColumn = TryCast(DirectCast(sender, ASPxGridView).Columns("UnitPrice"), GridViewDataColumn)
            Dim lnk As HtmlAnchor = TryCast(DirectCast(sender, ASPxGridView).FindFooterCellTemplateControl(col, "summaryLink"), HtmlAnchor)
            lnk.InnerText = "The total price is $ " & val.ToString()
            lnk.HRef = "TestPage.aspx?TotalPrice=" & val.ToString()


        End Sub


    End Class
End Namespace
