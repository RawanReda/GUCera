<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentSubmitAssignment.aspx.cs" Inherits="GUCera.StudentSubmitAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <style>
        p {
            color: black;
            font-size: 20px;
        }
    .h {
	        background-image: url('loginbg.jpg');
			background-repeat: no-repeat;
			background-attachment: fixed;
			background-size: cover;
			color: white;
			text-shadow: 0.5px 0.5px #0000004d;
/*            height: 10px;
			line-height: 10px;
*/			padding: 5px;        
        
        }
        
    </style>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div class="h" >
             <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/StudentHome.aspx" ForeColor="White">Home</asp:HyperLink>
			<span id ="a" runat="server"> </span>
			
        </div>
      
        <asp:Literal ID="SubmitAssignMssg" runat="server"></asp:Literal>
        
        <p style="font-weight: bolder"> Please enter the required information to submit your assignment:</p>
      
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
