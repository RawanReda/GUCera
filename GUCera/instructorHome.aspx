<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="instructorHome.aspx.cs" Inherits="GUCera.instructorHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Instructor Home</title>

	<style>
	    .cards {

			background-color: lightgray;
			margin: 4px;

	    }

			 .h  {
	        background-image: url('images/bg.jpg');
			background-repeat: no-repeat;
			background-attachment: fixed;
			background-size: cover;
			color: white;
			text-shadow: 1px 1px black;
	    }

	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="h" >
            <asp:Label ID="Name1" runat="server" Text="" ></asp:Label> 
        </div>
		<br>
        <details>
			<summary> Mobile Number </summary>
			<br>
			
            <asp:Button ID="Button6" runat="server" Text="Add" OnClick="addMobile" Width="167px"/> <br><br>

		</details>
		
		<hr>
        <div>
		<details>
        <summary>Add a Course</summary>
        <p>
                 
               <table cellpadding="2" >
                             
	            <tbody>
		            <tr>
			            <td><asp:Label ID="Label1" runat="server" Text="Course Name:"></asp:Label>  </td>
			            <td> <asp:TextBox ID="cname" runat="server" ></asp:TextBox> <br /> </td>
		            </tr>
		            <tr>
			            <td> <asp:Label ID="Label2" runat="server" Text="Credit Hours:"></asp:Label> </td>
			            <td> <asp:TextBox ID="chours" runat="server" ></asp:TextBox><br /></td>
		            </tr>
		            <tr>
			            <td><asp:Label ID="Label3" runat="server" Text="Price:" type="number"></asp:Label> </td>
			            <td> <asp:TextBox ID="price" runat="server" ></asp:TextBox> </td>
		            </tr> 
                     <tr>
			            <td><asp:Button ID="Button1" runat="server" Text="Add Course" OnClick="addCourse"/></td>
			            <td></td>
		            </tr>
	            </tbody>
            </table>


        </p>

        </details>

        </div>
        <asp:Literal ID="msg" runat="server"></asp:Literal>
		<hr>

		<div>

		<asp:Button ID="Button2" runat="server" Text="View Accepted Courses" OnClick="viewaccCourses"/>
		<asp:Button ID="Button3" runat="server" Text="View my Courses" OnClick="viewmyCourses"/>


			<br>
			<br>
			<asp:Literal ID="title" runat="server" Text=""></asp:Literal>
			<asp:Panel ID="CourseList" runat="server"></asp:Panel>


		</div>

    </form>
</body>
</html>
