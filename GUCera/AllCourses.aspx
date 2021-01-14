<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllCourses.aspx.cs" Inherits="GUCera.AllCourses" %>

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
        <h1> All Course :</h1>
        <div>
            &nbsp;<asp:Literal ID="txt1" runat="server"></asp:Literal>
            <br />
            <asp:Literal ID="txt" runat="server"></asp:Literal>
            <br />
        </div>
    </form>
</body>
</html>
