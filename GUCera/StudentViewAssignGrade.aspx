<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentViewAssignGrade.aspx.cs" Inherits="GUCera.StudentViewAssignGrade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
        <style>
        h1 {
  color: blue;
  font-size: 20px;
}</style>
<head runat="server">
    <title></title>
</head>
<body>
       <form id="form1" runat="server">
       <p style="font-size: medium; font-weight: bolder">&nbsp;</p>
           <p style="font-size: medium; font-weight: bolder">Please enter the required info to check your assignment grade:</p>
     
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
           <h1>
           <asp:Literal ID="Grade" runat="server"></asp:Literal></h1>
           <br />
  
    </form>
</body>
</html>
