<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegistration.aspx.cs" Inherits="GUCera.StudentRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
	
	<style>

	    .logincard {
	    
		
			Position: absolute;
			left: 50%;
			top: 50%;
			transform: translate(-50%, -80%);
			border: 5px solid lightgray;
			padding: 10px;
			background-color: lightgrey;
			/* box-shadow: 0.25px 0.5px; */
			box-shadow: 7px 10px 11px 0px rgb(139 137 137 / 15%);
		}

		

	    body {
	        background-image: url('bg1.jpg');
			background-repeat: no-repeat;
			background-attachment: fixed;
			background-size: cover;
	    }

	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="logincard">
            Sign Up as a Student <br />
           
              <br />

            <asp:Literal ID="txt" runat="server"></asp:Literal><br>
            <asp:Literal ID="redirect" runat="server"></asp:Literal>
			<br>
				<div >
                <table cellpadding="2" >
	            <tbody>
		            <tr>
			            <td><asp:Label ID="Label1" runat="server" Text="First Name:"  ></asp:Label>  </td>
			            <td> <asp:TextBox ID="firstname" runat="server"  required ></asp:TextBox> <br /> </td>
		            </tr>
					<tr>
			            <td><asp:Label ID="Label2" runat="server" Text="Last Name:"  ></asp:Label>  </td>
			            <td> <asp:TextBox ID="lastname" runat="server" required  ></asp:TextBox> <br /> </td>
		            </tr>
		            <tr>
			            <td> <asp:Label ID="lbl_password" runat="server" Text="Password:"  ></asp:Label> </td>
			            <td>   <asp:TextBox ID="password" runat="server" required TextMode="Password"  ></asp:TextBox><br /></td>
		            </tr>
		            <tr>
			            <td><asp:Label ID="lbl_email" runat="server" Text="Email:"  ></asp:Label> </td>
			            <td> <asp:TextBox ID="email" runat="server" required MaxLength = "10"  ></asp:TextBox> <br /></td>
		            </tr>
		            <tr>
			            <td><asp:Label ID="lbl_g" runat="server" Text="Gender(M/F):"  ></asp:Label></td>
			            <td> <asp:TextBox ID="gender" runat="server"  required ></asp:TextBox> <br /></td>
						
		            </tr>
					<tr>
			            <td><asp:Label ID="lbl_add" runat="server" Text="Address:"  ></asp:Label> </td>
			            <td> <asp:TextBox ID="address" runat="server"  ></asp:TextBox> <br /> </td>
		            </tr>

					
					
		            <tr>

			            <td>
							</td>
			            <td style="text-align:right"><br><asp:Button ID="Button1" runat="server" OnClick="Registration" Text="Register" /> </td>
		            </tr>
	            </tbody>
            </table>


            </div>
        </div>
    </form>
</body>
</html>
