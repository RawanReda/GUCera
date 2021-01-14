<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentHome.aspx.cs" Inherits="GUCera.StudentHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p><asp:Literal ID="StName" runat="server"></asp:Literal></p>
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
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/StudentViewAssignments.aspx">View Course Assignment</asp:HyperLink>
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
            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/StudentViewCertificates.aspx">View Course Certificate</asp:HyperLink>
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
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
