<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="BT_TH1.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 509px;
        }
        .auto-style2 {
            width: 20%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1" cellpadding="0" cellspacing="0">
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" Text="Nhập hệ số A:" Width="100px"></asp:Label>
            </td>
            <td class="auto-style1"> <asp:TextBox ID="txtSoA" runat="server" Width="100px"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style2"> <asp:Label ID="Label2" runat="server" Text="Nhập hệ số B:" Width="100px"></asp:Label> </td>
            <td class="auto-style1"> <asp:TextBox ID="txtSoB" runat="server" Width="100px"></asp:TextBox> </td>
        </tr>
        <tr>
            <td class="auto-style2"> <asp:Label ID="Label3" runat="server" Text="Nhập hệ số C:" Width="100px"></asp:Label> </td>
            <td class="auto-style1"> <asp:TextBox ID="txtSoC" runat="server" Width="100px"></asp:TextBox> </td>
        </tr>
        <tr>
            <td class="auto-style2"> <asp:Label ID="Label4" runat="server" Text="Kết quả:"></asp:Label> </td>
            <td class="auto-style1"> <asp:TextBox ID="txtkp" runat="server" Width="495px"></asp:TextBox> </td>
        </tr>
         <tr>
            <td colspan="2" align="center">
                <asp:Button ID="ButTinh" runat="server" Text="Giải" OnClick="ButTinh_Click" />
            </td>
        </tr>
        </table>
        </div>
    </form>
</body>
</html>
