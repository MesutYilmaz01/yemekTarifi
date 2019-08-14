<%@ Page Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="TarifOner.aspx.cs" Inherits="YemekTarifi.TarifOner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            text-align: right;
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">Tarif Ad :</td>
            <td>
                <asp:TextBox ID="TxtTarifAd" runat="server" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Malzemeler :</td>
            <td>
                <asp:TextBox ID="TxtTarifMalzeme" runat="server" Height="80px" OnTextChanged="TextBox2_TextChanged" TextMode="MultiLine" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Yapılış :</td>
            <td>
                <asp:TextBox ID="TxtTarifYapilis" runat="server" Height="150px" TextMode="MultiLine" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Resim : </td>
            <td>
                <asp:FileUpload ID="TarifResim" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Tarifi Öneren : </td>
            <td>
                <asp:TextBox ID="TxtTarifÖneren" runat="server" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Mail Adresi : </td>
            <td>
                <asp:TextBox ID="TxtTarifMail" runat="server" TextMode="Email" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="BtnTarifOner" runat="server" BackColor="Aqua" Height="40px" style="font-weight: 700; font-style: italic; margin-left: 50px" Text="Tarif Öner" Width="150px" />
            </td>
        </tr>
    </table>
</asp:Content>