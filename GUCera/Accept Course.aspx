<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Accept Course.aspx.cs" Inherits="GUCera.Accept_Course" %>

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
             <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Admin Page.aspx" ForeColor="White">Home</asp:HyperLink>
			<span id ="a" runat="server"> </span>
			
        </div>
        <div>
            Course Name:<br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Accept" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
