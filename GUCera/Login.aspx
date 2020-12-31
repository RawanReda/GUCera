<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUCera.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  <%--  Hi Hadeer--%>
</head>
<body>
    <form id="form1" runat="server">
        Welcome to our GUCera website :) <br />
        <br />
        Please Log In <br />
        <br />
        ID :<br />
        <br />
        <asp:TextBox ID="ID" runat="server"></asp:TextBox>
        <br />
        <br />
        Password :<br />
        <br />
        <asp:TextBox ID="Password" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="signin" runat="server" OnClick="login" Text="log in" />
        <br />
        <br />

        <asp:Button ID="Button1" runat="server" OnClick="StudentReg" Text="Register as an Instructor" />
        <br />
        <br/>
        <asp:Button ID="Button2" runat="server" OnClick="InstructorReg" Text="Register as an Student" />
        <br />
        <br />
        <br />
        <br />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
