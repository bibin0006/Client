<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarPerfil2.aspx.cs" Inherits="clients.EditarPerfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <br />
        Editar Perfil</h2>
    <p>
        Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="email_edit" runat="server"></asp:TextBox>
    </p>
    <p>
        Teléfono:&nbsp;&nbsp;
        <asp:TextBox ID="tel_edit" runat="server"></asp:TextBox>
    </p>
    <p>
        Celular:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="cel_edit" runat="server"></asp:TextBox>
    </p>
    <p>
        Dirección:&nbsp;&nbsp;
        <asp:TextBox ID="dir_edit" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
    </p>
    <p>
    </p>
</asp:Content>
