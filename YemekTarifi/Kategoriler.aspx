<%@ Page Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Kategoriler.aspx.cs" Inherits="YemekTarifi.Kategoriler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style7 {
        background-color: #999966;
    }
    .auto-style8 {
        text-align: left;
            width: 304px;
        }
    .auto-style9 {
        text-align: right;
    }
    .auto-style10 {
        font-size: large;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style7">
    KATEGORİ LİSTESİ</asp:Panel>
<asp:Panel ID="Panel2" runat="server">
    <asp:DataList ID="DataList1" runat="server" Width="448px">
        <ItemTemplate>
            <table class="auto-style6">
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label1" runat="server" CssClass="auto-style10" Text='<%# Eval("KategoriAd") %>'></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/Ikonlar/delete-icon-png-17.jpg" Width="30px" />
                    </td>
                    <td class="auto-style9">
                        <asp:Image ID="Image3" runat="server" Height="30px" ImageUrl="~/Ikonlar/kisspng-computer-icons-refresh-free-download-clip-art-one-button-reload-5b282ade8d1bf6.251990151529359070578.png" Width="30px" />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Panel>
</asp:Content>
