<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeBehind="EditarPerfil.aspx.cs" Inherits="clients.WebForm2" %>
<%@ Register src="DefaultHeader.ascx" tagname="DefaultHeader" tagprefix="art" %>
<%@ Register src="DefaultMenu.ascx" tagname="DefaultMenu" tagprefix="art" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ScriptIncludePlaceHolder" runat="server">
    <style type="text/css">
        .style1
        {
            font-family: "Palatino Linotype";
            text-align: center;
        }<a href="EditarPerfil.aspx">EditarPerfil.aspx</a>
        .style2
        {
            font-family: "Palatino Linotype";
            text-align: center;
        }
        .style3
        {
            text-align: left;
        }
        .style4
        {
            font-family: "Palatino Linotype";
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderContentPlaceHolder" runat="server">
    <asp:Image ID="Image3" runat="server" ImageUrl="~/images/medicslogo.png" />
    <art:DefaultHeader ID="DefaultHeader" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MenuContentPlaceHolder" runat="server">
    <art:DefaultMenu ID="DefaultMenuContent" runat="server" />
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="SheetContentPlaceHolder" runat="server">
    <p class="style1">
    <br />
</p>
<p>
</p>
<p>
</p>
    <h2 class="style2">
        &nbsp;&nbsp;
        Editar Perfil</h2>
        <br/>
    <p class="style4">
        Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="email_edit" runat="server" Width="300px" CssClass="style1" 
            Height="25px"></asp:TextBox>
    </p>
    <p class="style3">
        &nbsp;</p>
    <p class="style3">
        <span class="style1">Teléfono: &nbsp;&nbsp;
        </span>
        <asp:TextBox ID="tel_edit" runat="server" Width="222px" CssClass="style1" 
            Height="25px"></asp:TextBox>
    </p>
    <p class="style3">
        &nbsp;</p>
    <p class="style3">
        <span class="style1">Celular:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </span>
        <asp:TextBox ID="cel_edit" runat="server" Width="222px" CssClass="style1" 
            Height="22px"></asp:TextBox>
    </p>
    <p class="style3">
        &nbsp;</p>
    <p class="style3">
        <span class="style1">Dirección:&nbsp;&nbsp;
        </span>
        <asp:TextBox ID="dir_edit" runat="server" Width="300px" CssClass="style1" 
            Height="25px"></asp:TextBox>
    </p>
    <p class="style2">
        &nbsp;</p>
    <p class="style2">
    <asp:Button ID="Button1" runat="server" Text="Submit" CausesValidation="False" 
        EnableTheming="False" EnableViewState="False" onclick="Button1_Click1" 
        UseSubmitBehavior="False" Height="42px" Width="114px" CssClass="style1" />
    </p>
<p class="style1">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    &#39;</p>
<p class="style1">
    &nbsp; &nbsp;</p>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="Sidebar1ContentPlaceHolder" runat="server">
</asp:Content>
