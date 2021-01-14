<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructorRegistration.aspx.cs" Inherits="GUCera.InstructorRegistration" %>

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


	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="logincard">
            Sign Up as an Instructor <br />
            <asp:Literal ID="txt" runat="server"></asp:Literal>
            <asp:Literal ID="redirect" runat="server"></asp:Literal>
              <br />

				<div>
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
			            <td>   <asp:TextBox ID="password" runat="server" TextMode="Password" required ></asp:TextBox><br /></td>
		            </tr>
		            <tr>
			            <td><asp:Label ID="lbl_email" runat="server" Text="Email:"  ></asp:Label> </td>
			            <td> <asp:TextBox ID="email" runat="server" MaxLength = "10" required  ></asp:TextBox> <br /></td>
		            </tr>
		            <tr>
			            <td><asp:Label ID="lbl_g" runat="server" Text="Gender(M/F):"  ></asp:Label></td>
			            <td><asp:TextBox ID="gender" runat="server" required></asp:TextBox> <br /></td>
						
		            </tr>
					<tr>
			            <td><asp:Label ID="lbl_add" runat="server" Text="Address:"  ></asp:Label> </td>
			            <td> <asp:TextBox ID="address" runat="server" required ></asp:TextBox> <br /></td>
		            </tr>
					
					
		            <tr>
			            <td><br> <asp:Button ID="Button1" runat="server" OnClick="Registration" Text="Sign-up" /></td>
			            <td> </td>
		            </tr>
	            </tbody>
            </table>


            </div>
        </div>
    </form>
</body>
</html>




