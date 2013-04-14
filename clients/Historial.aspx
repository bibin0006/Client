<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeBehind="Historial.aspx.cs" Inherits="clients.Historial" %>
<%@ Register src="DefaultHeader.ascx" tagname="DefaultHeader" tagprefix="art" %>
<%@ Register src="DefaultMenu.ascx" tagname="DefaultMenu" tagprefix="art" %>
<%@ Register src="DefaultSidebar1.ascx" tagname="DefaultSidebar1" tagprefix="art" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc1" %>
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
            font-size: large;
        }
        .style3
        {
            font-family: "Palatino Linotype";
            font-size: large;
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
        <span class="style2">
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
    <p class="style1">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </span>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <h4 class="style3">
        &nbsp;Historial de enfermedades</h4>
    <p class="style1">
        <span class="style2"></p>
    <ajaxToolkit:Accordion ID="Accordion1" runat="server" SelectedIndex="0"
            HeaderCssClass="accordionHeader" HeaderSelectedCssClass="accordionHeaderSelected"
            ContentCssClass="accordionContent" FadeTransitions="false" FramesPerSecond="40" 
            TransitionDuration="250" AutoSize="None" RequireOpenedPane="false" SuppressHeaderPostbacks="true">
    </ajaxToolkit:Accordion>
<p class="style1">
        </span></p>
    <h4 class="style3">
        Antecedentes alérgicos
    </h4>
    <p class="style1">
        <span class="style2"><ajaxToolkit:Accordion ID="Accordion2" runat="server" SelectedIndex="0"
            HeaderCssClass="accordionHeader" HeaderSelectedCssClass="accordionHeaderSelected"
            ContentCssClass="accordionContent" FadeTransitions="false" FramesPerSecond="40" 
            TransitionDuration="250" AutoSize="None" RequireOpenedPane="false" SuppressHeaderPostbacks="true">
    </ajaxToolkit:Accordion>
    <p class="style1">
        </span></p>
    <h4 class="style3">
        Historial procedimientos&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </h4>
    <p class="style1">
        <span class="style2">&nbsp;&nbsp;&nbsp;<ajaxToolkit:Accordion ID="Accordion3" runat="server" SelectedIndex="0"
            HeaderCssClass="accordionHeader" HeaderSelectedCssClass="accordionHeaderSelected"
            ContentCssClass="accordionContent" FadeTransitions="false" FramesPerSecond="40" 
            TransitionDuration="250" AutoSize="None" RequireOpenedPane="false" SuppressHeaderPostbacks="true">
    </ajaxToolkit:Accordion>
<p class="style1">
        </span></p>
<h4 class="style3">
        Antecedentes tóxicos
    </h4>
<p class="style1">
        <span class="style2"><ajaxToolkit:Accordion ID="Accordion4" runat="server" SelectedIndex="0"
            HeaderCssClass="accordionHeader" HeaderSelectedCssClass="accordionHeaderSelected"
            ContentCssClass="accordionContent" FadeTransitions="false" FramesPerSecond="40" 
            TransitionDuration="250" AutoSize="None" RequireOpenedPane="false" SuppressHeaderPostbacks="true">
    </ajaxToolkit:Accordion>
    <p class="style1">
        </span></p>
    <h4 class="style3">
        Enfermedades hereditarias</h4>
    <p class="style1">
        <span class="style2"></p>
    <ajaxToolkit:Accordion ID="Accordion5" runat="server" SelectedIndex="0"
            HeaderCssClass="accordionHeader" HeaderSelectedCssClass="accordionHeaderSelected"
            ContentCssClass="accordionContent" FadeTransitions="false" FramesPerSecond="40" 
            TransitionDuration="250" AutoSize="None" RequireOpenedPane="false" SuppressHeaderPostbacks="true">
    </ajaxToolkit:Accordion>
    </p>
    <span class="style1">
    <br />
    <p>
    </p>
        <br />
            </span>
            <p class="style1">
                &nbsp;</p>
    <p>
    </p>
        <br class="style1" />
            <p class="style1">
                &nbsp;</p>
    <p>
    </p>
    <br class="style1" />
        <p class="style1">
            &nbsp;</p>
    <p>
    </p>



    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </ajaxToolkit:ToolkitScriptManager>
      





    </span><span class="style1"><span class="style2">
      





    <br />
&nbsp;<br />
    </span></span></asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="Sidebar1ContentPlaceHolder" runat="server">
    
</asp:Content>
