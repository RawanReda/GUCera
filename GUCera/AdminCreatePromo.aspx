<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminCreatePromo.aspx.cs" Inherits="GUCera.AdminCreatePromo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Code:<br />
            <asp:TextBox ID="CodeB" runat="server"></asp:TextBox>
            <br />
            <br />
            Issue Date: (M/D/Y)<br />
            <asp:TextBox ID="issueDateB" runat="server"></asp:TextBox>
            <br />
            <br />
            Expiry Date: (M/D/Y)<br />
            <asp:TextBox ID="expiryDateB" runat="server"></asp:TextBox>
            <br />
            <br />
            Discount:<br />
            <asp:TextBox ID="discountB" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Create" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin Page.aspx">Back to home page</asp:HyperLink>
            <br />
        </div>
    </form>
</body>
</html>
