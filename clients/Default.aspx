<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="clients.Home" %>
<%@ Register src="DefaultHeader.ascx" tagname="DefaultHeader" tagprefix="art" %>
<%@ Register src="DefaultMenu.ascx" tagname="DefaultMenu" tagprefix="art" %>
<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="~/DefaultSidebar1.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ScriptIncludePlaceHolder" runat="server">
    <style type="text/css">
        .style1
        {
            font-family: "Palatino Linotype";
        }
        .style2
        {
            font-family: "Palatino Linotype";
            font-size: large;
        }
        .style3
        {
            font-size: large;
        }
        .style4
        {
            font-family: "Palatino Linotype";
            text-align: center;
        }
        .style5
        {
            font-family: "Palatino Linotype";
            font-size: large;
            text-align: center;
        }
        .style6
        {
            text-align: center;
        }
        .style7
        {
            margin-left: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderContentPlaceHolder" runat="server">
    <asp:Image ID="Image3" runat="server" ImageUrl="~/images/medicslogo.png" />
    <art:DefaultHeader ID="DefaultHeader" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MenuContentPlaceHolder" runat="server">
    </asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="SheetContentPlaceHolder" runat="server">
    <p class="style4">
        <br />
    </p>
    <p>
    </p>
    <p class="style5">
        Bienvenidos a la portal web de Medics. Esta platforma les permitira visualizar 
        su historial medico y al mismo tiempo modificar sus datos personales 
        registrados.</p>
    <p class="style6">
    &nbsp;&nbsp;&nbsp; <span class="style1">&nbsp;</span></p>
    <p __designer:mapid="2" class="style4">
        &nbsp; </p>
    <p>
        &nbsp;</p>
    <p class="style4">
        <asp:Image ID="Image2" runat="server" CssClass="style7" 
            ImageUrl="~/images/preview.jpg" />
    </p>
    <p class="style4">
        &nbsp;</p>
    <p class="style1">
        <span class="style3"></p>
    <p class="style4">
        &nbsp;&nbsp;</p>
    <p class="style6">
        </span><span class="style1"><span class="style3">Username:</span></span><asp:TextBox 
            ID="txtuser" runat="server" Height="20px" CssClass="style2"></asp:TextBox>
    </p>
    <p class="style1">
        <span class="style3"></p>
    <p class="style6">
        </span><span class="style1"><span class="style3">Password: </span></span>
        <asp:TextBox ID="txtpass" runat="server" Height="20px" 
            TextMode="Password" CssClass="style2"></asp:TextBox>
    </p>
    <p class="style5">
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnLogin" runat="server" Text="Login" 
            onclick="btnLogin_Click" Height="42px" Width="161px" CssClass="style2" />
    </p>
    <p class="style4">
        <span class="style3">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtuser" ErrorMessage="Información incompleta"></asp:RequiredFieldValidator>
    </p>
    <p class="style4">
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="txtuser" 
            ErrorMessage="Nombre de usuario no cumple los requerimientos" 
            ValidationExpression=".{4}.*"></asp:RegularExpressionValidator>
    </p>
    <p class="style4">
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    <p class="style4">
        &nbsp;&nbsp;</span></p>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="Sidebar1ContentPlaceHolder" runat="server">
     </asp:Content>
