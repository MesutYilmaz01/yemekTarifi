<%@ Page Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="GununYemegi.aspx.cs" Inherits="YemekTarifi.GununYemegi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList2" runat="server" Width="445px">
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td style="text-align: center">
                        <asp:Label ID="Label3" runat="server" style="font-size: x-large; font-weight: 700" Text='<%# Eval("YemekAd") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>Malzemeler</strong> :
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("YemekMalzeme") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <strong>Tarif</strong> :
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("YemekTarif") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Image ID="Image1" runat="server" Height="165px" style="text-align: center" Width="314px" ImageUrl='<%# Eval("YemekResim") %>' />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5"><strong>Puan</strong> :
                        <asp:Label ID="Label6" runat="server" Text='<%# Eval("YemekPuan") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5"><strong>Eklenme</strong> <strong>Tarihi</strong> :
                        <asp:Label ID="Label7" runat="server" Text='<%# Eval("YemekTarih") %>'></asp:Label>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>