<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentHome.aspx.cs" Inherits="GUCera.StudentHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            View my profile :<br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="myprofile" Text="my profile" />
            <br />
            <br />
            <br />
            All courses accepted by the admin :<br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="allcourses" Text="all courses" />
            <br />
            <br />
            <br />
            Enroll in a course :<br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="enroll" Text="enroll" />
            <br />
            <br />
            <br />
            Add credit card :<br />
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="creditcard" Text="credit card" />
            <br />
            <br />
            <br />
            View my promocodes :<br />
            <br />
            <asp:Button ID="Button5" runat="server" Onclick="promocodes" Text="promocodes" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
