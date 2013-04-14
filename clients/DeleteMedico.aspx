<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeBehind="DeleteMedico.aspx.cs" Inherits="clients.DeleteMedico1" %>
<%@ Register src="DefaultHeader.ascx" tagname="DefaultHeader" tagprefix="art" %>
<%@ Register src="DefaultMenu.ascx" tagname="DefaultMenu" tagprefix="art" %>
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
    <p class="style1">
        </span></p>
    <h3 class="style3">
        Desligar médicos</h3>
    <p class="style1">
        <span class="style2">&nbsp;&nbsp;</p>
    <p>
    </p>
    <p class="style1">
        Para desligar un médico solo es necesario marcar la casilla correspondiente y 
        presionar el botón.</p>
    <p>
    </p>
    <p class="style1">
        &nbsp;</p>
    <p class="style1">
        &nbsp;</p>
    <p>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
        </asp:CheckBoxList>
    </p>
    <p class="style1">
        &nbsp;</p>
    </span><span class="style1"><span class="style2">
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <br />
    <br />
    </span></span>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" 
        Height="38px" Width="126px" CssClass="style3" />
    <span class="style2">
    <br class="style1" />
    </span><span class="style1"><span class="style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    </span></span> 
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="Sidebar1ContentPlaceHolder" runat="server">
</asp:Content>
