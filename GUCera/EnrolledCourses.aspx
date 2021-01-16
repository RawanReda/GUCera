<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnrolledCourses.aspx.cs" Inherits="GUCera.EnrolledCourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
              <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
   <Columns>
      
      
        <asp:BoundField DataField="id" HeaderText="Course ID" />
       <asp:BoundField DataField="name" HeaderText="Course Name" />
        <asp:BoundField DataField="creditHours" HeaderText="Credit Hours" />
        <asp:BoundField DataField="courseDescription" HeaderText="Description" />
        <asp:BoundField DataField="price" HeaderText="Price" />
       <asp:BoundField DataField="content" HeaderText="Content" />
       <asp:BoundField DataField="instructorId" HeaderText="Instructor ID" />
       <asp:TemplateField HeaderText="Assignments"> 
           <ItemTemplate> 
           <%--<asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/AddMobileNumber.aspx" ForeColor="White">Add Mobile Number</asp:HyperLink>--%>
           <asp:LinkButton ID="ViewAssign" Text="View" runat="server" CommandArgument='<%#Eval("id")%>' OnClick="ViewAssignments" />
       </ItemTemplate>

       </asp:TemplateField>
        <asp:TemplateField HeaderText="Certificate"> 
           <ItemTemplate> 
           <%--<asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/AddMobileNumber.aspx" ForeColor="White">Add Mobile Number</asp:HyperLink>--%>
           <asp:LinkButton ID="ViewCert" Text=" Check Certificate" runat="server" CommandArgument='<%#Eval("id")%>' OnClick="ViewCertificates" />
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
        </div>

        <div id="show" runat="server">

        </div>
    </form>
</body>
</html>
