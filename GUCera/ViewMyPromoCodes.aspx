<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewMyPromoCodes.aspx.cs" Inherits="GUCera.ViewMyPromoCodes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            My PromoCodes :
            <asp:Literal ID="txt" runat="server"></asp:Literal>
        </div>
          <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
   <Columns>
      
      
        <asp:BoundField DataField="code" HeaderText="Code" />
        <asp:BoundField DataField="isuueDate" HeaderText="Issue Date" />
        <asp:BoundField DataField="expiryDate" HeaderText="Expiry Date" />
        <asp:BoundField DataField="discount" HeaderText="Discount" />
        <asp:BoundField DataField="adminId" HeaderText="Admin ID " />
 
       </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
      
    </form>
</body>
</html>
