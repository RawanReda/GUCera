<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentHome.aspx.cs" Inherits="GUCera.StudentHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Student Home page :<br />
            <br />
            <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/StudentViewMyProfile.aspx">View My Profile</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/AddMobileNumber.aspx">Add Mobile Number</asp:HyperLink>
            <br/>
            <br/>
            <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/AllCourses.aspx">All Courses</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink12" runat="server" NavigateUrl="~/EnrollInACourse.aspx">Enroll</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink10" runat="server" NavigateUrl="~/AddCreditCard.aspx">Add Credit Card</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink11" runat="server" NavigateUrl="~/ViewMyPromoCodes.aspx">View PromoCodes</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/EnterViewAssignCourse.aspx">View Course Assignment</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/StudentSubmitAssignment.aspx">Submit Assignment</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/StudentViewAssignGrade.aspx">Check Grade</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/StudentAddFeedback.aspx">Add Course Feedback</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/EnterViewCertificateCourse.aspx">View Course Certificate</asp:HyperLink>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <%--<br />
            To submit an Assignment, please enter the required info:<br />
&nbsp;<asp:Button ID="SubmitAssign1" runat="server" Onclick="SubmitAssign" Text="Submit Assignment" />

            <br />
            <br />
            Check Assignment grade:<br />
            <asp:Button ID="CheckGrade1" runat="server" Onclick="CheckGrade" Text="Check Grade" />
            <br />
            <br />
            Add Course Feedback:<br />
            <asp:Button ID="CourseFeedback" runat="server" Onclick="Feedback" Text="Add Feedback" />
            <br />
            <br />
            To check obtained Certificates for a specific course, please enter Course ID:<br />
            Course Id: <asp:TextBox ID="course_Id0" runat="server" Height="16px" Width="30px" OnTextChanged="course_Id_TextChanged1"></asp:TextBox>
             
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="CheckCertificates" runat="server" Onclick="Certificates" Text="Check Certificates" />
             
            <br />--%>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
