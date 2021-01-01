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

           <%-- Rawan --%>
            Vew Assignments:<br />
            <asp:Button ID="ViewAssign" runat="server" Onclick="ViewAssign" Text="Check Assignments" />
            <br />
            <br />
            Submit Assignment:<br />
&nbsp;<asp:Button ID="SubmitAssign" runat="server" Onclick="SubmitAssign" Text="Submit Assignment" />
            <br />
            <br />
            Check Assignment grade:<br />
            <asp:Button ID="CheckGrade" runat="server" Onclick="CheckGrade" Text="Check Grade" />
            <br />
            <br />
            Add Course Feedback:<br />
            <asp:Button ID="CourseFeedback" runat="server" Onclick="Feedback" Text="Add Feedback" />
            <br />
            <br />
            Check obtained Certificates:<br />
            <asp:Button ID="CheckCertificates" runat="server" Onclick="Certificates" Text="Check Certificates" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
