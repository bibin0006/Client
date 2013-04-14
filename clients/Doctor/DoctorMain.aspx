<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeBehind="DoctorMain.aspx.cs" Inherits="clients.Doctor.DoctorMain" %>
<%@ Register src="../DefaultHeader.ascx" tagname="DefaultHeader" tagprefix="art" %>
<%@ Register src="../DefaultMenu.ascx" tagname="DefaultMenu" tagprefix="art" %>
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
            text-align: center;
        }
        .style5
        {
            font-size: x-large;
        }
        .style6
        {
            font-size: x-large;
        }
        .style7
        {
            font-family: "Palatino Linotype";
            font-size: x-large;
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
        <span class="style3">
        <br />
    </p>
    <p>
    </p>
    </span>
    <p class="style7">
        Bienvenido
        <asp:Label ID="lblbienvenida" runat="server" Text="Label"></asp:Label>
    </p>
    <span class="style3">
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p class="style4">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="btnMiHistorial" runat="server" Height="190px" 
            ImageUrl="~/images/medico.jpg" onclick="btnMiHistorial_Click" 
            Width="250px" CssClass="style1" />
        <span class="style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="btnPacientes" runat="server" Height="190px" 
            ImageUrl="~/images/pacientes.jpg" Width="250px" 
            onclick="btnPacientes_Click" />
        </span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
    <p class="style4">
        &nbsp;
        <asp:Label ID="Label1" runat="server" Text="Mi Historial" CssClass="style5"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text=" Mis Pacientes" CssClass="style6"></asp:Label>
    </p>
    <p class="style1">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </span>
    </p>
    <h5 class="style1">
        <asp:Label ID="listado_pacientes" runat="server" CssClass="style3"></asp:Label>
    </h5>
    <p class="style1">
        <span class="style3"></p>
    <p>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" CssClass="art-vmenu">
        </asp:RadioButtonList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p class="style1">
        </span></p>
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" 
            Visible="False" CssClass="style2" />
    </p>
    <span class="style2">&nbsp;
</span>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="Sidebar1ContentPlaceHolder" runat="server">
</asp:Content>
