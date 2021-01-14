<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentViewAssignments.aspx.cs" Inherits="GUCera.StudentViewAssignments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
     <style>
        h1 {
  color: black;
  font-size: 20px;
}</style>
<head runat="server">
    <title></title>
</head>
<body> 
    <form id="form1" runat="server">
        <h1> Please enter a course ID:</h1>
        Course ID:
        <asp:TextBox ID="course_ID" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Enter" OnClick="Button1_Click" />
        <br />
        <asp:Literal  ID="NoEntries" runat="server"></asp:Literal>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
   <Columns>
      
      
        <asp:BoundField DataField="number" HeaderText="Number" />
        <asp:BoundField DataField="type" HeaderText="Type" />
        <asp:BoundField DataField="fullGrade" HeaderText="Full Grade" />
        <asp:BoundField DataField="weight" HeaderText="Weight" />
        <asp:BoundField DataField="deadline" HeaderText="Deadline" />
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
