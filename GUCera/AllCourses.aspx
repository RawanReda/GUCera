<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllCourses.aspx.cs" Inherits="GUCera.AllCourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
            <style>
        h1 {
  color: black;
  font-size: 30px;
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
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div class="h" >
             <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Admin Page.aspx" ForeColor="White">Home</asp:HyperLink>
			<span id ="a" runat="server"> </span>
			
        </div>
        <h1> Available Courses: :</h1>
        <div>
            &nbsp;<asp:Literal ID="txt1" runat="server"></asp:Literal>
            <br />
            <asp:Literal ID="txt" runat="server"></asp:Literal>
            <br />
        </div>
    </form>
</body>
</html>
