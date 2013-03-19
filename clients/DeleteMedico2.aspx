<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteMedico2.aspx.cs" Inherits="clients.DeleteMedico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style2
        {}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <br />
        Médicos Con acceso a sus Datos</h2>
    <p>
        <asp:ListBox ID="ListBox1" runat="server" CssClass="style2" Height="140px" 
            Width="291px"></asp:ListBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
