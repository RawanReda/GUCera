<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegistration.aspx.cs" Inherits="GUCera.StudentRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Sign Up page for students <br />
            <br />
            First Name :<br />
            <br />
            <asp:TextBox ID="firstname" runat="server"></asp:TextBox>
            <br />
            <br />
            Last Name :<br />
            <br />
            <asp:TextBox ID="lastname" runat="server"></asp:TextBox>
            <br />
            <br />
            Password :<br />
            <br />
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            <br />
            Email :<br />
            <br />
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
            <br />
            <br />
            Gender (F/M:<br />
            <br />
            <asp:TextBox ID="gender" runat="server"></asp:TextBox>
            <br />
            <br />
            Address :<br />
            <br />
            <asp:TextBox ID="address" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Registration" Text="sign up" />
        </div>
    </form>
</body>
</html>
