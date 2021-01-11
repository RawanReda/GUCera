<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUCera.Login" %>

<!DOCTYPE html>

<%--<html xmlns="http://www.w3.org/1999/xhtml">--%>
<head runat="server">
    <title>Log-in</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Welcome to our GUCera website :) </h3>
            
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
