<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewMyPromoCodes.aspx.cs" Inherits="GUCera.ViewMyPromoCodes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        h1 {
  color: blue;
  font-size: 20px;
}
            </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1> My PromoCodes :</h1>
        <div>
            <asp:Literal ID="txt" runat="server"></asp:Literal>
        </div>

          <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" GridLines="None">
              <AlternatingRowStyle BackColor="White" />
   <Columns>
      
        <asp:BoundField DataField="code" HeaderText="Code" />
        <asp:BoundField DataField="isuueDate" HeaderText="Issue Date" />
        <asp:BoundField DataField="expiryDate" HeaderText="Expiry Date" />
        <asp:BoundField DataField="discount" HeaderText="Discount" />
        <asp:BoundField DataField="adminId" HeaderText="Admin ID " />
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
