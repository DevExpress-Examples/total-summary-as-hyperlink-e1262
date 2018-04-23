Imports Microsoft.VisualBasic
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

Namespace WebApplication11
	Partial Public Class TestPage
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Request.Params("TotalPrice") Is Nothing Then
				ASPxLabel1.BackColor = System.Drawing.Color.Red
				ASPxLabel1.Text = "Required request parameter is empty. Test is failed, sorry =( Please go to the previous page and try again"
			Else
				ASPxLabel1.BackColor = System.Drawing.Color.LightSeaGreen
				ASPxLabel1.Text = "Total price is $ " & Request.Params(0)
			End If

		End Sub
	End Class
End Namespace
