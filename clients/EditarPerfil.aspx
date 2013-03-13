<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeBehind="EditarPerfil.aspx.cs" Inherits="clients.WebForm2" %>
<%@ Register src="DefaultHeader.ascx" tagname="DefaultHeader" tagprefix="art" %>
<%@ Register src="DefaultMenu.ascx" tagname="DefaultMenu" tagprefix="art" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ScriptIncludePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderContentPlaceHolder" runat="server">
    <art:DefaultHeader ID="DefaultHeader" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MenuContentPlaceHolder" runat="server">
    <art:DefaultMenu ID="DefaultMenuContent" runat="server" />
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="SheetContentPlaceHolder" runat="server">
    <p>
    <br />
</p>
<p>
</p>
<p>
</p>
    <h2>
        Editar Perfil</h2>
    <p>
        Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="email_edit" runat="server" Width="250px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Teléfono: &nbsp;&nbsp;
        <asp:TextBox ID="tel_edit" runat="server" Width="200px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Celular:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="cel_edit" runat="server" Width="200px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Dirección:&nbsp;&nbsp;
        <asp:TextBox ID="dir_edit" runat="server" Width="250px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
<p>
    <asp:Button ID="Button1" runat="server" Text="Submit" />
</p>
<p>
</p>
<p>
    &nbsp; &nbsp;</p>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="Sidebar1ContentPlaceHolder" runat="server">
</asp:Content>
