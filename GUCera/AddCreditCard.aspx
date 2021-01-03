<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCreditCard.aspx.cs" Inherits="GUCera.AddCreditCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Enter Credit Card Details :<br />
            <br />
            <br />
            Number :<br />
            <br />
            <asp:TextBox ID="Number" runat="server"></asp:TextBox>
            <br />
            <br />
            Card Holder Name :<br />
            <br />
            <asp:TextBox ID="CHName" runat="server"></asp:TextBox>
            <br />
            <br />
            Expiry Date :<br />
            <br />
            <asp:TextBox ID="EXDate" runat="server"></asp:TextBox>
            <br />
            <br />
            CVV :<br />
            <br />
            <asp:TextBox ID="CVV" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="add" Text="add" />
        </div>
    </form>
</body>
</html>
