<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentSubmitAssignment.aspx.cs" Inherits="GUCera.StudentSubmitAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Please enter the required info to submit your assignment:<br />
        <asp:Literal ID="SubmitAssignMssg" runat="server"></asp:Literal>
        <br />
        <br />
        Assignment Type:<asp:TextBox ID="Assigntype" runat="server"></asp:TextBox>
        <br />
        <br />
        Assignment Number: <asp:TextBox ID="AssignNo" runat="server"></asp:TextBox>
        <br />
        <br />
        Course ID:<asp:TextBox ID="CourseID" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="SubmitNow" runat="server" Text="Submit" OnClick="SubmitNow_Click" />
    </form>
</body>
</html>
