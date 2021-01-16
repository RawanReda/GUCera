<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentViewCertificates.aspx.cs" Inherits="GUCera.StudentViewCertificates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
  
<head runat="server">
    <style>
        h1 {
  color: black;
  font-size: 20px;
}
.card {
    background-color: yellow;
height: 300px;
font-size:20px;
  width: 700px;
  color:black;
  margin: auto;
border-radius:7px;
border: 8px solid black;
text-align:center;
display: flex;
justify-content:center;
line-height:300px;    
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
             <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/StudentHome.aspx" ForeColor="White">Home</asp:HyperLink>
			<span id ="a" runat="server"> </span>
			
        </div>
         <h1> Please enter a course ID:</h1>
       
          Course ID:
        <asp:TextBox ID="course_ID" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Enter" OnClick="Button1_Click" />
        
          
          <br />
        
          
          <br />
                 <asp:Literal ID="NoEntries" runat="server"></asp:Literal>
                 
          <br />
        <br />
            <div class="card"  runat="server" id="theDiv">
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                 
                <br />
                 
    </div>
  
       
    </form>
</body>
</html>
