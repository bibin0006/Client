<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeBehind="Historial.aspx.cs" Inherits="clients.Historial" %>
<%@ Register src="DefaultHeader.ascx" tagname="DefaultHeader" tagprefix="art" %>
<%@ Register src="DefaultMenu.ascx" tagname="DefaultMenu" tagprefix="art" %>
<%@ Register src="DefaultSidebar1.ascx" tagname="DefaultSidebar1" tagprefix="art" %>
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
        Historial de enfermedades&nbsp;&nbsp; Antecedentes alérgicos
    </p>
    <p>
&nbsp;&nbsp;
    </p>
    <p>
        <asp:ListBox ID="ListBox1" runat="server" Height="180px" Width="180px">
        </asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="ListBox2" runat="server" Height="180px" Width="180px">
        </asp:ListBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Historial procedimientos&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        Antecedentes tóxicos
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:ListBox ID="ListBox3" runat="server" Height="180px" Width="180px">
        </asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="ListBox4" runat="server" Height="180px" Width="180px">
        </asp:ListBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
&nbsp;Enfermedades hereditarias</p>
    <p>
        &nbsp;</p>
    <p>
&nbsp;<asp:ListBox ID="ListBox5" runat="server" AutoPostBack="True" Height="180px" 
            Width="180px"></asp:ListBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="Sidebar1ContentPlaceHolder" runat="server">
    <art:DefaultSidebar1 ID="DefaultSidebar1Content" runat="server" />
</asp:Content>
