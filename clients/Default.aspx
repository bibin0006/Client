﻿<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="clients.Home" %>
<%@ Register src="DefaultHeader.ascx" tagname="DefaultHeader" tagprefix="art" %>
<%@ Register src="DefaultMenu.ascx" tagname="DefaultMenu" tagprefix="art" %>
<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="~/DefaultSidebar1.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ScriptIncludePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderContentPlaceHolder" runat="server">
    <art:DefaultHeader ID="DefaultHeader" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MenuContentPlaceHolder" runat="server">
    </asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="SheetContentPlaceHolder" runat="server">
    <p>
        <br />
    </p>
    <p>
    </p>
    <p>
        Bienvenidos a la portal web de Medics. Esta platforma les permitira visualizar 
        su historial medico y al mismo tiempo modificar sus datos personales 
        registrados.</p>
    <p>
    <img src="images/preview.jpg" alt="an image" style="float:left;" __designer:mapid="a7" />
    </p>
    <p __designer:mapid="2">
        &nbsp; </p>
    <p __designer:mapid="3">
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;</p>
    <p>
        Username:<asp:TextBox ID="txtuser" runat="server" Height="20px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Password:<asp:TextBox ID="txtpass" runat="server" Height="20px" 
            TextMode="Password"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btnLogin" runat="server" Text="Login" 
            onclick="btnLogin_Click" Height="42px" Width="161px" />
    </p>
    <p>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtuser" ErrorMessage="Información incompleta"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="txtuser" 
            ErrorMessage="Nombre de usuario no cumple los requerimientos" 
            ValidationExpression=".{4}.*"></asp:RegularExpressionValidator>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;&nbsp;</p>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="Sidebar1ContentPlaceHolder" runat="server">
     </asp:Content>
