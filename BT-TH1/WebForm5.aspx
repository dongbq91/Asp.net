<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="BT_TH1.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;" border="1">
                           <tr>
                <td class="auto-style8">
                    <asp:Label ID="maNV" runat="server" Text="Mã NV"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtmaNV" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="lbBL" runat="server" Text="Bậc Lương"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtBacLuong" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label3" runat="server" Text="Ngày công"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtNgayCong" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="Chức vụ"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:DropDownList ID="listCV" runat="server" Height="20px" Width="123px">
                        <asp:ListItem Value="tp">Trưởng Phòng</asp:ListItem>
                        <asp:ListItem Value="pp">Phó phòng</asp:ListItem>
                        <asp:ListItem Value="nv">Nhân Viên</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label5" runat="server" Text="Giới tính"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:RadioButton ID="nam" Text="Nam" Checked GroupName="gt" runat="server"/>
                    <asp:RadioButton ID="nu" GroupName="gt" Text="Nu" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label6" runat="server" Text="Ngoại ngữ"></asp:Label>
                </td>
                <td class="auto-style1" >
                    <asp:CheckBox ID="anh" Text="Anh" runat="server" />
                    <asp:CheckBox ID="phap"  Text="Pháp" runat="server" />
                    <asp:CheckBox ID="nga"  Text="Nga" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label7" runat="server" Text="Tiền Lĩnh"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="lbTienLinh" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:center"  colspan="2" >
                    <asp:Button ID="Button1" runat="server" Text="Tính" CssClass="auto-style2" Width="83px" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="Xóa" Width="83px" OnClick="Button2_Click" />
                </td>
            </tr>
            </table>
        </div>
    </form>
</body>
</html>
