<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeBehind="Historial.aspx.cs" Inherits="clients.Historial" %>
<%@ Register src="DefaultHeader.ascx" tagname="DefaultHeader" tagprefix="art" %>
<%@ Register src="DefaultMenu.ascx" tagname="DefaultMenu" tagprefix="art" %>
<%@ Register src="DefaultSidebar1.ascx" tagname="DefaultSidebar1" tagprefix="art" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc1" %>
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
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <h4>
        &nbsp;Historial de enfermedades</h4>
    <p>
        &nbsp;</p>
    <ajaxToolkit:Accordion ID="Accordion1" runat="server" SelectedIndex="0"
            HeaderCssClass="accordionHeader" HeaderSelectedCssClass="accordionHeaderSelected"
            ContentCssClass="accordionContent" FadeTransitions="false" FramesPerSecond="40" 
            TransitionDuration="250" AutoSize="None" RequireOpenedPane="false" SuppressHeaderPostbacks="true">
    </ajaxToolkit:Accordion>
<p>
        &nbsp;</p>
    <h4>
        Antecedentes alérgicos
    </h4>
    <p>
        &nbsp;<ajaxToolkit:Accordion ID="Accordion2" runat="server" SelectedIndex="0"
            HeaderCssClass="accordionHeader" HeaderSelectedCssClass="accordionHeaderSelected"
            ContentCssClass="accordionContent" FadeTransitions="false" FramesPerSecond="40" 
            TransitionDuration="250" AutoSize="None" RequireOpenedPane="false" SuppressHeaderPostbacks="true">
    </ajaxToolkit:Accordion>
    <p>
        &nbsp;</p>
    <h4>
        Historial procedimientos&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </h4>
    <p>
&nbsp;&nbsp;&nbsp;<ajaxToolkit:Accordion ID="Accordion3" runat="server" SelectedIndex="0"
            HeaderCssClass="accordionHeader" HeaderSelectedCssClass="accordionHeaderSelected"
            ContentCssClass="accordionContent" FadeTransitions="false" FramesPerSecond="40" 
            TransitionDuration="250" AutoSize="None" RequireOpenedPane="false" SuppressHeaderPostbacks="true">
    </ajaxToolkit:Accordion>
<p>
        &nbsp;</p>
<h4>
        Antecedentes tóxicos
    </h4>
<p>
        &nbsp;<ajaxToolkit:Accordion ID="Accordion4" runat="server" SelectedIndex="0"
            HeaderCssClass="accordionHeader" HeaderSelectedCssClass="accordionHeaderSelected"
            ContentCssClass="accordionContent" FadeTransitions="false" FramesPerSecond="40" 
            TransitionDuration="250" AutoSize="None" RequireOpenedPane="false" SuppressHeaderPostbacks="true">
    </ajaxToolkit:Accordion>
    <p>
        &nbsp;</p>
    <h4>
        Enfermedades hereditarias</h4>
    <p>
        &nbsp;</p>
    <ajaxToolkit:Accordion ID="Accordion5" runat="server" SelectedIndex="0"
            HeaderCssClass="accordionHeader" HeaderSelectedCssClass="accordionHeaderSelected"
            ContentCssClass="accordionContent" FadeTransitions="false" FramesPerSecond="40" 
            TransitionDuration="250" AutoSize="None" RequireOpenedPane="false" SuppressHeaderPostbacks="true">
    </ajaxToolkit:Accordion>
    </p>
    <br />
    <p>
    </p>
        <br />
            <p>
        &nbsp;</p>
    <p>
    </p>
        <br />
            <p>
        &nbsp;</p>
    <p>
    </p>
    <br />
        <p>
        &nbsp;</p>
    <p>
    </p>



    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </ajaxToolkit:ToolkitScriptManager>
      





    <br />
&nbsp;<br />
    </asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="Sidebar1ContentPlaceHolder" runat="server">
    
</asp:Content>
