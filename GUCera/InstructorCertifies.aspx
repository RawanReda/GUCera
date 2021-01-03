<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructorCertifies.aspx.cs" Inherits="GUCera.InstructorCertifies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style='text-align:center'>
            <h2 id="h" runat="server">
                Issue a Certificate to a Student taking this course</h2>

            <p>Student ID </p>
            <asp:TextBox ID="inputID" runat="server"></asp:TextBox>
            <br><br>
                        <asp:Literal ID="msg" runat="server"></asp:Literal>

            <br>
            <asp:Button ID="Button1" runat="server" Text="Certify" OnClick="certify"/>
            <br>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>


        </div>
    </form>
</body>
</html>
