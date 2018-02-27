<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Pages_Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td rowspan="4">
                <asp:Image ID="imgProduct" runat="server" CssClass="detailsImage" />
            </td>
            <td>
                <h2>
                <asp:Label ID="lblTitle" Text="Label" runat="server" />
                </h2>
                <hr />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDescription" runat="server" CssClass="detailsDescription"/>
            </td>
            <td>
                Quantity:
            <asp:DropDownList ID="ddlAmount" runat="server"></asp:DropDownList><br />
                <asp:Label ID="lblPrice" runat="server" CssClass="detailsPrice"/>
                <br />
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add Product" CssClass="button" />
                <br />
                <asp:Label ID="lblResult" runat="server" Text=""/>
            </td>
            <br />
            
            
        </tr>
        <tr>
               <td>Product Number:<asp:Label ID="lblItemNr" Text="Label" runat="server" /></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" Text="Available" runat="server" CssClass="productPrice"/></td>
        </tr>
    </table>
</asp:Content>

