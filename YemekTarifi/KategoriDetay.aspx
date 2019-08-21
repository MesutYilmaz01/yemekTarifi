<%@ Page Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="KategoriDetay.aspx.cs" Inherits="YemekTarifi.KategoriDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"><style type="text/css">

        .auto-style6 {
            background-color: #9999FF;
        }
        .auto-style5 {
            font-size: x-large;
        }
        .auto-style7 {
            color: #CCFFCC;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:DataList ID="DataList2" runat="server" Width="443px">
    <ItemTemplate>
        <table class="auto-style1">
            <tr>
                <td class="auto-style6"><a href="YemekDetay.aspx?YemekId=<%# Eval("YemekId")%>"><strong>
                    <asp:Label ID="Label4" runat="server" CssClass="auto-style5" Text='<%# Eval("YemekAd") %>'></asp:Label>
                    </strong></a></td>
            </tr>
            <tr>
                <td><strong>Malzemeler</strong> :
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("YemekMalzeme") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td><strong>Yemek Tarifi</strong>:
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("YemekTarif") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td><strong>Eklenme Tarihi </strong>:
                        <asp:Label ID="Label6" runat="server" CssClass="auto-style7" Text='<%# Eval("YemekTarih") %>'></asp:Label>
                        &nbsp;- <strong><em>Puan</em></strong> :<strong><asp:Label ID="Label7" runat="server" Text='<%# Eval("YemekPuan") %>'></asp:Label>
                    </strong></td>
            </tr>
            <tr>
                <td style="border-bottom-style: groove">&nbsp;</td>
            </tr>
        </table>
    </ItemTemplate>
</asp:DataList>

</asp:Content>