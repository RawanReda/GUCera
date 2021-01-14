<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUCera.Login" %>

<!DOCTYPE html>

<%--<html xmlns="http://www.w3.org/1999/xhtml">--%>
<head runat="server">
    <title>Log-in</title>

	<style>

	    .logincard {
	        Position: absolute;
	        left: 50%;
	        top: 50%;
	        transform: translate(-50%, -80%);
	        border: 5px solid lightgray;
	        padding: 10px;
	        background-color: lightgrey;
	    }

		
	    body {
	        background-image: url('images/loginbg.jpg');
			background-repeat: no-repeat;
			background-attachment: fixed;
			background-size: cover;
	    }
	


	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="logincard">
            <h3>

				<span >Welcome to our</span>
    <span style="color:black">G</span><span style="color:red">U</span><span style="color:yellow">C</span><span >era website :)</span>



            </h3>
            
           <p style="font-weight: bolder">   Please Log In </p>
				<div>
                <table cellpadding="2" >
	            <tbody>
		            <tr>
			            <td><asp:Label ID="usrID" runat="server" Text="ID:"  ></asp:Label>  </td>
			            <td> <asp:TextBox ID="ID" runat="server" type="number" ></asp:TextBox> <br /> </td>
		            </tr>
					
		            <tr>
			            <td> <asp:Label ID="lbl_password" runat="server" Text="Password:"  ></asp:Label> </td>
			            <td>   <asp:TextBox ID="Password" runat="server" TextMode="Password" ></asp:TextBox><br /></td>
		            </tr>
		       	
		            <tr>
			            <td><asp:Button ID="signin" runat="server" OnClick="login" Text="Log in" /></td>
			            <td> </td>
		            </tr>
					
					<tr>
			            <td><asp:Button ID="Button1" runat="server" OnClick="InstructorReg" Text="Register as an Instructor" /></td>
			            <td> <asp:Button ID="Button2" runat="server" OnClick="StudentReg" Text="Register as an Student" /><br /></td>
		            </tr>
                    
					
	            </tbody>

            </table>

					<asp:Literal ID="error" runat="server"></asp:Literal>


            </div>
        </div>
    </form>
</body>
</html>
