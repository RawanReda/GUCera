<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentViewAssignGrade.aspx.cs" Inherits="GUCera.StudentViewAssignGrade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
       <form id="form1" runat="server">
        <div>
        </div>
        Please enter the required info to check your assignment grade:<br />
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
        <asp:Button ID="CheckGrade" runat="server" Text="Check Grade" OnClick="CheckNow_Click" />
           <br />
           <br />
        <asp:Literal ID="Grade" runat="server"></asp:Literal>
    </form>
</body>
</html>
