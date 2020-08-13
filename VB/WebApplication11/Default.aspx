<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication11._Default" %>

<%@ register Assembly="DevExpress.Web.v14.1" Namespace="DevExpress.Web.ASPxEditors"
    TagPrefix="dxe" %>

<%@ register Assembly="DevExpress.Web.v14.1" Namespace="DevExpress.Web.ASPxGridView"
    TagPrefix="dxwgv" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dxwgv:aspxgridview ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="AccessDataSource1" KeyFieldName="ProductID" OnDataBound="ASPxGridView1_DataBound">
            <totalsummary>
                <dxwgv:aspxsummaryitem FieldName="UnitPrice" ShowInColumn="Unit Price" SummaryType="Sum" />
            </totalsummary>
            <columns>
                <dxwgv:gridviewdatatextcolumn FieldName="ProductID" ReadOnly="True" VisibleIndex="0">
                    <editformsettings Visible="False" />
                </dxwgv:gridviewdatatextcolumn>
                <dxwgv:gridviewdatatextcolumn FieldName="ProductName" VisibleIndex="1">
                </dxwgv:gridviewdatatextcolumn>
                <dxwgv:gridviewdatatextcolumn FieldName="UnitPrice" VisibleIndex="2">
                    <footertemplate>
                        <a id = "summaryLink" runat="server"></a>
                    </footertemplate>
                    <propertiestextedit DisplayFormatString="c">
                    </propertiestextedit>
                </dxwgv:gridviewdatatextcolumn>
            </columns>
            <settings ShowFooter="True" />
        </dxwgv:aspxgridview>
        <asp:accessdatasource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/nwind.mdb"
            SelectCommand="SELECT [ProductID], [ProductName], [UnitPrice] FROM [Products]"></asp:accessdatasource>
    </div>
    </form>
</body>
</html>