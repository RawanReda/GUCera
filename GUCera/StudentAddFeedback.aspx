<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentAddFeedback.aspx.cs" Inherits="GUCera.StudentAddFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <style>

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
        <div>
            <p>
        <asp:Literal ID="SubmitFeedbackMssg" runat="server"></asp:Literal></p>
       <p style="font-weight: bolder">Please enter the required information to submit course feedback:</p>
            Course ID:<asp:TextBox ID="course_ID" runat="server"></asp:TextBox>
        <br />
            Comment:<asp:TextBox ID="comment" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="FeedbackNow" runat="server" Text="Add Feedback" OnClick="AddNow_Click" />
            </div>
    </form>
</body>
</html>
