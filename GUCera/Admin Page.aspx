<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin Page.aspx.cs" Inherits="GUCera.Admin_Page" %>

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
          h1 {
              color: white;
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
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <h1> Welcome!</h1>
        <div class="options">
            
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AdminAllCourses.aspx" ForeColor="White">View All Courses</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/AdminNonAcc.aspx" ForeColor="White">View Non-accepted Courses</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Accept Course.aspx" ForeColor="White">Accept A Course</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/AdminCreatePromo.aspx" ForeColor="White">Create Promocode</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/AdminIssuePromo.aspx" ForeColor="White">Issue A Promocode</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/AddMobileNumber.aspx" ForeColor="White">Add Phone Number</asp:HyperLink>
        </div>
    </form>
</body>
</html>
