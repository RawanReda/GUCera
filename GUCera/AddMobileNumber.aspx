<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMobileNumber.aspx.cs" Inherits="GUCera.AddMobileNumber" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Type Number to Add: <br>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
           <br>
            <asp:Literal ID="msg" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
