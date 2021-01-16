<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentViewAssignGrade.aspx.cs" Inherits="GUCera.StudentViewAssignGrade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
        <style>
        h1 {
  color: black;
  font-size: 20px;
}
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
       <p style=" font-weight: bolder">&nbsp;Please enter the required info to check your assignment grade:</p>
     
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
