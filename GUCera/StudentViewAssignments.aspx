<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentViewAssignments.aspx.cs" Inherits="GUCera.StudentViewAssignments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
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
<head runat="server">
    <title></title>
</head>
<body> 
    <form id="form1" runat="server">
            <div class="h" >
             <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/StudentHome.aspx" ForeColor="White">Home</asp:HyperLink>
			<span id ="a" runat="server"> </span>
			
        </div>
        <br />
        <asp:Literal  ID="NoEntries" runat="server"></asp:Literal>
            <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
   <Columns>
      
      
        <asp:BoundField DataField="number" HeaderText="Number" />
        <asp:BoundField DataField="type" HeaderText="Type" />
        <asp:BoundField DataField="fullGrade" HeaderText="Full Grade" />
        <asp:BoundField DataField="weight" HeaderText="Weight" />
        <asp:BoundField DataField="deadline" HeaderText="Deadline" />
       <asp:BoundField DataField="content" HeaderText="Content" />
       <asp:TemplateField HeaderText="Submit Status"> 
           <ItemTemplate> 
            <asp:Label ID="Label1" runat="server" >
          <%# Check(Eval("type").ToString(), Eval("number").ToString(), Eval("cid").ToString()) %>
        </asp:Label> </ItemTemplate> </asp:TemplateField>
        <asp:TemplateField HeaderText="Check Grade"> 
           <ItemTemplate> 

            <asp:Label ID="lblCalc" runat="server" >
          <%# Calculate(Eval("type").ToString(), Eval("number").ToString(), Eval("cid").ToString(), Eval("fullGrade").ToString()) %>
        </asp:Label>
           </ItemTemplate>
            </asp:TemplateField>
 
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
