<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnterViewAssignCourse.aspx.cs" Inherits="GUCera.EnterCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <p> <asp:Literal ID="Literal1" runat="server"></asp:Literal></p>
            <br />
            Course ID:
            <asp:TextBox ID="course_Id" runat="server" Width="82px"></asp:TextBox>
            <asp:Button ID="course_Id1" runat="server" Text="Enter" ForeColor="Black" OnClick="Button1_Click" />
            <br />
        </div>
    </form>
</body>
</html>
