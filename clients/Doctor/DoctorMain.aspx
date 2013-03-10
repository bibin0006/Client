<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeBehind="DoctorMain.aspx.cs" Inherits="clients.Doctor.DoctorMain" %>
<%@ Register src="../DefaultHeader.ascx" tagname="DefaultHeader" tagprefix="art" %>
<%@ Register src="../DefaultMenu.ascx" tagname="DefaultMenu" tagprefix="art" %>
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
        Bienvenido
        <asp:Label ID="lblbienvenida" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
    </p>
    <p>
        <asp:ImageButton ID="btnMiHistorial" runat="server" Height="190px" 
            ImageUrl="~/images/medico.jpg" onclick="btnMiHistorial_Click" Width="250px" />
&nbsp;&nbsp;
        <asp:ImageButton ID="btnPacientes" runat="server" Height="190px" 
            ImageUrl="~/images/pacientes.jpg" Width="250px" 
            onclick="btnPacientes_Click" />
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Mi Historial"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text=" Mis Pacientes"></asp:Label>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
&nbsp;
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="Sidebar1ContentPlaceHolder" runat="server">
</asp:Content>
