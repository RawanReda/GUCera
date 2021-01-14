<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsgradeAssignment.aspx.cs" Inherits="GUCera.InsgradeAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grade Assignment</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style='text-align: center'>

            <asp:Literal ID="head" runat="server"></asp:Literal>
            <br>
            <br>
            <asp:TextBox ID="TextBox1" runat="server" required Width="117px"></asp:TextBox>
            <asp:Literal ID="Literal2" runat="server"></asp:Literal>
            <br>
            <br>
            <asp:Button ID="Button1" runat="server" Text="Confirm" OnClick="Button1_Click" />
            <br>
           
            <asp:Literal ID="msg" runat="server"></asp:Literal>
            <br>
            
            
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
