<%@ Page Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="HakkimizdaDetay.aspx.cs" Inherits="YemekTarifi.HakkimizdaDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        HAKKIMIZDA</p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server" Height="185px" TextMode="MultiLine" Width="440px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Güncelle" />
    </p>
    </asp:Content>