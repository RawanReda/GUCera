<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnrollInACourse.aspx.cs" Inherits="GUCera.EnrollInACourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Enter<br />
&nbsp;<br />
            The Course ID :<br />
&nbsp;<br />
&nbsp;<asp:TextBox ID="cid" runat="server" Height="16px"></asp:TextBox>
            <br />
            <br />
            The Admin ID :<br />
            <br />
            <asp:TextBox ID="instrid" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Enroll" Text="Enroll" />
            <br />
            <br />
            <asp:Literal ID="txt" runat="server"></asp:Literal>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
