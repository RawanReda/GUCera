<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentHome.aspx.cs" Inherits="GUCera.StudentHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <style>
        p {
            color:white; 
            font-size: 20px;
        }
        body {
            background-image: url("Student HomePage.jpg");
           
  	background-repeat: no-repeat;
			background-attachment: fixed;
			background-size: cover;
        }
        .options {
    font-size:20px;
  width: 700px;
  color:black;
  margin: auto;


text-align:center;

justify-content:center;
  
        }
    </style>
<%--<head runat="server">--%>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p><asp:Literal ID="StName" runat="server"></asp:Literal></p>
        <div class="options">
           
            <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/StudentViewMyProfile.aspx" ForeColor="White">View My Profile</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/AddMobileNumber.aspx" ForeColor="White">Add Mobile Number</asp:HyperLink>
            <br/>
            <br/>
            <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/AllCourses.aspx" ForeColor="White">All Courses</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink12" runat="server" NavigateUrl="~/EnrollInACourse.aspx" ForeColor="White">Enroll</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink10" runat="server" NavigateUrl="~/AddCreditCard.aspx" ForeColor="White">Add Credit Card</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink11" runat="server" NavigateUrl="~/ViewMyPromoCodes.aspx" ForeColor="White">View PromoCodes</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/StudentViewAssignments.aspx" ForeColor="White">View Course Assignment</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/StudentSubmitAssignment.aspx" ForeColor="White">Submit Assignment</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/StudentViewAssignGrade.aspx" ForeColor="White">Check Grade</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/StudentAddFeedback.aspx" ForeColor="White">Add Course Feedback</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/StudentViewCertificates.aspx" ForeColor="White">View Course Certificate</asp:HyperLink>
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
