<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentViewMyProfile.aspx.cs" Inherits="GUCera.StudentViewMyProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please enter your ID :<br />
            <br />
            <asp:TextBox ID="input" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="enter" Text="Enter" />
        </div>
    </form>
</body>
</html>
