<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vFeedback.aspx.cs" Inherits="GUCera.vFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Feedback</title>
    <style>
	    .card {

			background-color: lightgray;
	    }

            .h {
	        background-image: url('loginbg.jpg');
			background-repeat: no-repeat;
			background-attachment: fixed;
			background-size: cover;
			color: white;
			text-shadow: 0.5px 0.5px #0000004d;
              height: 10px;
        line-height: 10px;
        padding: 15px;        
        
        }

	</style>
</head>

<body>
    <form id="form1" runat="server">
       <p class="h">
        <asp:Literal ID="redir" runat="server"></asp:Literal></p>
      <h2>Feedback </h2>
       <asp:Literal ID="title" runat="server"></asp:Literal>

    </form>
</body>
</html>
