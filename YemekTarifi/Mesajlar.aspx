<%@ Page Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Mesajlar.aspx.cs" Inherits="YemekTarifi.Mesajlar" %>

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
                <td>MESAJ&nbsp; LİSTESİ</td>
            </tr>
        </table>
    </asp:Panel>
<asp:Panel ID="Panel2" runat="server">
    <asp:DataList ID="DataList1" runat="server" Width="448px">
        <ItemTemplate>
            <table class="auto-style6">
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label1" runat="server" CssClass="auto-style10" Text='<%# Eval("MesajGonderen") %>'></asp:Label>
                    </td>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style9">
                       <a href ="MesajDetay.aspx?MesajId=<%# Eval("MesajId") %>"><asp:Image ID="Image3" runat="server" Height="30px" ImageUrl="~/Ikonlar/kisspng-computer-icons-refresh-free-download-clip-art-one-button-reload-5b282ade8d1bf6.251990151529359070578.png" Width="30px" />
                        </a>                  
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Panel>
    </asp:Content>
