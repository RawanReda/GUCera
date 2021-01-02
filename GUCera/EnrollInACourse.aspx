<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnrollInACourse.aspx.cs" Inherits="GUCera.EnrollInACourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please enter the course id :<br />
            <br />
            <asp:TextBox ID="en" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Enroll" Text="Enroll" />
        </div>
    </form>
</body>
</html>
