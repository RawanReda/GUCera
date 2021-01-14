<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCreditCard.aspx.cs" Inherits="GUCera.AddCreditCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <style>
        h1 {
  color: black;
  font-size: 20px;
}
            </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1> Please Enter Credit Card Details :</h1>
        <div>
            <asp:Literal ID="error" runat="server"></asp:Literal>
            <br />
            <br />
            Number :<br />
            <br />
            <asp:TextBox ID="Number" runat="server" MaxLength ="15"></asp:TextBox>
            <asp:Literal ID="no" runat="server"></asp:Literal>
            <br />
            <br />
            Card Holder Name :<br />
            <br />
            <asp:TextBox ID="CHName" runat="server" MaxLength="16"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Literal ID="name" runat="server"></asp:Literal>
            <br />
            <br />
            Expiry Date :<br />
            <br />
            <asp:TextBox ID="EXDate" runat="server" MaxLength="10"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Literal ID="credit" runat="server"></asp:Literal>
            <br />
            <br />
            CVV :<br />
            <br />
            <asp:TextBox ID="CVV" runat="server" MaxLength ="3"></asp:TextBox>
            <asp:Literal ID="c" runat="server"></asp:Literal>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="add" Text="add" />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;
            <asp:Literal ID="txt" runat="server"></asp:Literal>
            <br />
        </div>
    </form>
</body>
</html>
