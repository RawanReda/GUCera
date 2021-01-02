<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructorAssignments.aspx.cs" Inherits="GUCera.InstructorAssignments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Assignments</title>

	<style>
	    .card {
	        background-color: lightgray;
	    }
	</style>
</head>

</head>
<body>
    <form id="form1" runat="server">
        <asp:Literal ID="title" runat="server"></asp:Literal>
		<br>
		<br>

        <details>
        <summary>Define an Assignment of a Certain Type</summary>
        <p>
                 <table cellpadding="2" >
	            <tbody>
		            
					<tr>
			            <td>Number</td>
			            <td> <asp:TextBox ID="ano" runat="server"   ></asp:TextBox> <br /> </td>
		            </tr>
		            <tr>
			            <td> Type</td>
			            <td>   <asp:TextBox ID="ty" runat="server" ></asp:TextBox><br /></td>
		            </tr>
					
					 <tr>
			            <td> <asp:Label ID="lbl_grade" runat="server" Text="Full Grade"  ></asp:Label> </td>
			            <td>   <asp:TextBox ID="full" runat="server" ></asp:TextBox><br /></td>
		            </tr>
					
					<tr>
			            <td> Weight</td>
			            <td>   <asp:TextBox ID="wgt" runat="server" ></asp:TextBox><br /></td>
		            </tr>
					
					<tr>
			            <td> Deadline</td>
			            <td>   <asp:TextBox ID="dead" runat="server" ></asp:TextBox><br />

                        </td>
		            </tr>
					
					<tr>
			            <td> <asp:Label ID="lbl_content" runat="server" Text="Content"  ></asp:Label> </td>
			            <td>   <asp:TextBox ID="cnt" runat="server" Height="155px" Width="461px" ></asp:TextBox><br /></td>
		            </tr>
					
					
					
		            <tr>
			            <td><asp:Button ID="defAss" runat="server" OnClick="define" Text="Add Assignment" /></td>
			            <td> </td>
		            </tr>
					
					
	            </tbody>
            </table>

        </p>
        </details>

		<hr>
		
        <asp:Button ID="Button1" runat="server" Text="View Student Submissions" OnClick="viewSubmissions" />
        <br>
		<asp:Literal ID="Literal1" runat="server"></asp:Literal>

		<div id="slist" runat="server">


		</div>

	


       
    </form>
</body>
</html>
