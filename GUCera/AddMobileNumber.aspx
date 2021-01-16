<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMobileNumber.aspx.cs" Inherits="GUCera.AddMobileNumber" %>

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
           GUCera
			<span id ="a" runat="server"> </span>
			
        </div>
        <h1>Type Number to Add:</h1>
        <div>
            <br/>
            <asp:TextBox ID="TextBox1" runat="server" MaxLength="11" required/>
             <br/>
            <br/>
            </asp:TextBox><asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
           <br>
            <asp:Literal ID="msg" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
