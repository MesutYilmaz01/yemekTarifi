<%@ Page Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yorumlar.aspx.cs" Inherits="YemekTarifi.Yorumlar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style7 {
        background-color: #CCFFFF;
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
        .auto-style11 {
            font-weight: bold;
            font-size: x-large;
        }
        .auto-style12 {
            width: 33px;
        }
        .auto-style13 {
            width: 32px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style7">
        <table class="auto-style6">
            <tr>
                <td class="auto-style12"><strong>
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style11" Height="30px" Text="+" Width="30px" OnClick="Button1_Click"/>
                    </strong></td>
                <td class="auto-style13"><strong>
                    <asp:Button ID="Button2" runat="server" CssClass="auto-style11" Height="30px" Text="-" Width="30px" OnClick="Button2_Click"/>
                    </strong></td>
                <td>ONAYLANAN YORUM LİSTESİ</td>
            </tr>
        </table>
    </asp:Panel>
<asp:Panel ID="Panel2" runat="server">
    <asp:DataList ID="DataList1" runat="server" Width="448px">
        <ItemTemplate>
            <table class="auto-style6">
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label1" runat="server" CssClass="auto-style10" Text='<%# Eval("YorumAdSoyad") %>'></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <a href ="Yorumlar.aspx?YorumId=<%# Eval("YorumId") %>&islem=sil"> <asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/Ikonlar/delete-icon-png-17.jpg" Width="30px" />
                        </a>
                    </td>
                    <td class="auto-style9">
                       <a href ="YorumDetay.aspx?YorumId=<%# Eval("YorumId") %>"><asp:Image ID="Image3" runat="server" Height="30px" ImageUrl="~/Ikonlar/kisspng-computer-icons-refresh-free-download-clip-art-one-button-reload-5b282ade8d1bf6.251990151529359070578.png" Width="30px" />
                        </a>                  
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Panel>
 <asp:Panel ID="Panel3" runat="server" CssClass="auto-style7">
        <table class="auto-style6">
            <tr>
                <td class="auto-style12"><strong>
                    <asp:Button ID="Button3" runat="server" CssClass="auto-style11" Height="30px" Text="+" Width="30px" OnClick="Button3_Click"/>
                    </strong></td>
                <td class="auto-style13"><strong>
                    <asp:Button ID="Button4" runat="server" CssClass="auto-style11" Height="30px" Text="-" Width="30px" OnClick="Button4_Click"/>
                    </strong></td>
                <td>ONAYLANMAYAN YORUM LİSTESİ</td>
            </tr>
        </table>
    </asp:Panel>
<asp:Panel ID="Panel4" runat="server">
    <asp:DataList ID="DataList2" runat="server" Width="448px">
        <ItemTemplate>
            <table class="auto-style6">
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label1" runat="server" CssClass="auto-style10" Text='<%# Eval("YorumAdSoyad") %>'></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <a href ="Yorumlar.aspx?YorumId=<%# Eval("YorumId") %>&islem=sil"> <asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/Ikonlar/delete-icon-png-17.jpg" Width="30px" />
                        </a>
                    </td>
                    <td class="auto-style9">
                       <a href ="YorumDetay.aspx?YorumId=<%# Eval("YorumId") %>"><asp:Image ID="Image3" runat="server" Height="30px" ImageUrl="~/Ikonlar/kisspng-computer-icons-refresh-free-download-clip-art-one-button-reload-5b282ade8d1bf6.251990151529359070578.png" Width="30px" />
                        </a>                  
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Panel>
</asp:Content>