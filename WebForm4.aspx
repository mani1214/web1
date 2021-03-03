<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication4.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 40%;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table align="center" class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="6">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="3">Employee ID</td>
                <td colspan="3">
                    <asp:TextBox ID="TxtID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="3">Employee Name</td>
                <td colspan="3">
                    <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="3">Employee Salary</td>
                <td colspan="3">
                    <asp:TextBox ID="TxtSalary" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="BtnCreate" runat="server" OnClick="BtnCreate_Click" Text="Create" />
                </td>
                <td>
                    <asp:Button ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" Text="Delete" />
                </td>
                <td colspan="2">
                    <asp:Button ID="BtnUpdate" runat="server" OnClick="BtnUpdate_Click" Text="Update" />
                </td>
                <td>
                    <asp:Button ID="BtnShow" runat="server" OnClick="BtnShow_Click" Text="Show" />
                </td>
                <td>
                    <asp:Button ID="BtnFind" runat="server" OnClick="BtnFind_Click" Text="Find" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
