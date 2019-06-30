<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationForWCFCalcService._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Aktuális érték:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Frissít" OnClick="Button1_Click" />
    <br />
    <asp:Button ID="Button2" runat="server" Text="Hozzáad" OnClick="Button2_Click" />
    <asp:Button ID="Button3" runat="server" Text="Kivon" OnClick="Button3_Click" />
    <asp:Button ID="Button4" runat="server" Text="Töröl" Height="26px" OnClick="Button4_Click" />
</asp:Content>
