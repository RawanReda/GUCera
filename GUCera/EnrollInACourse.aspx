<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnrollInACourse.aspx.cs" Inherits="GUCera.EnrollInACourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <style>
        h1 {
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
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div class="h" >
             <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/StudentHome.aspx" ForeColor="White">Home</asp:HyperLink>
			<span id ="a" runat="server"> </span>
			
        </div>
                <h1> Please Enter :</h1>
        <div>
&nbsp;The Course ID :<br />
&nbsp;<br />
&nbsp;<asp:TextBox ID="cid" runat="server" Height="16px"></asp:TextBox>
            <br />
            <br />
            The Instructor ID :<br />
            <br />
            <asp:TextBox ID="instrid" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Enroll" Text="Enroll" />
            <br />
            <br />
            <asp:Literal ID="txt" runat="server"></asp:Literal>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
