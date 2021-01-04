<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminIssuePromo.aspx.cs" Inherits="GUCera.AdminIssuePromo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Student ID:<br />
            <asp:TextBox ID="stid" runat="server"></asp:TextBox>
            <br />
            <br />
            Code:<br />
            <asp:TextBox ID="codeB" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Issue" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
