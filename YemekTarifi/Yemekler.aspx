<%@ Page Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yemekler.aspx.cs" Inherits="YemekTarifi.Yemekler" %>
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
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style11" Height="30px" Text="+" Width="30px" OnClick="Button1_Click" />
                    </strong></td>
                <td class="auto-style13"><strong>
                    <asp:Button ID="Button2" runat="server" CssClass="auto-style11" Height="30px" Text="-" Width="30px" OnClick="Button2_Click" />
                    </strong></td>
                <td>YEMEK LİSTESİ</td>
            </tr>
        </table>
    </asp:Panel>
<asp:Panel ID="Panel2" runat="server">
    <asp:DataList ID="DataList1" runat="server" Width="448px">
        <ItemTemplate>
            <table class="auto-style6">
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label1" runat="server" CssClass="auto-style10" Text='<%# Eval("YemekAd") %>'></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <a href ="Yemekler.aspx?YemekId=<%# Eval("YemekId") %>&islem=sil"> <asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/Ikonlar/delete-icon-png-17.jpg" Width="30px" />
                        </a>
                    </td>
                    <td class="auto-style9">
                       <a href ="YemekDuzenle.aspx?YemekId=<%# Eval("YemekId") %>"><asp:Image ID="Image3" runat="server" Height="30px" ImageUrl="~/Ikonlar/kisspng-computer-icons-refresh-free-download-clip-art-one-button-reload-5b282ade8d1bf6.251990151529359070578.png" Width="30px" />
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
                    <asp:Button ID="Button3" runat="server" CssClass="auto-style11" Height="30px" Text="+" Width="30px" OnClick="Button3_Click" />
                    </strong></td>
                <td class="auto-style13"><strong>
                    <asp:Button ID="Button4" runat="server" CssClass="auto-style11" Height="30px" Text="-" Width="30px" OnClick="Button4_Click" />
                    </strong></td>
                <td>YEMEK EKLEME</td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server">
        <table class="auto-style6">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Yemek Ad :</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Malzemeler:</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Height="100px" TextMode="MultiLine" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Yemek Tarifi:</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Height="200px" TextMode="MultiLine" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Kategori:</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="200px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" style="height: 26px" Text="Ekle" />
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
