<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Accept Course.aspx.cs" Inherits="GUCera.Accept_Course" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Course Id:<br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Accept" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
