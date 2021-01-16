<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminNonAcc.aspx.cs" Inherits="GUCera.AdminNonAcc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <style>
        h2 {

            font-size:20px; 
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
        <h2>  Non Accepted Courses:</h2>  
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
   <Columns>
      
      
        <asp:BoundField DataField="name" HeaderText="Course Name" />
        <asp:BoundField DataField="creditHours" HeaderText="Credit Hours" />
        <asp:BoundField DataField="price" HeaderText="Full Grade" />
        <asp:BoundField DataField="content" HeaderText="Content" />
    
 
       </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </form>
</body>
</html>
