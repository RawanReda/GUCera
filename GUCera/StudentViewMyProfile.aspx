<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentViewMyProfile.aspx.cs" Inherits="GUCera.StudentViewMyProfile" %>

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
<body style="height: 325px">
    <form id="form1" runat="server">
         <h1> My Profile</h1>
         <div style="font-family: 'Arial Rounded MT Bold'; font-size: medium; font-weight: lighter; font-style: oblique; color: #FFFFFF; background-color: #000080; height: 302px; width: 354px;">
            &nbsp;&nbsp;&nbsp;&nbsp;
             <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            First Name :&nbsp;
            <asp:Literal ID="firstn" runat="server"></asp:Literal>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;
            Last Name :&nbsp;
            <asp:Literal ID="lastn" runat="server"></asp:Literal>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;
            Gender :&nbsp;
            <asp:Literal ID="g" runat="server"></asp:Literal>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;
            ID :&nbsp;
            <asp:Literal ID="id" runat="server"></asp:Literal>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;
            Password :&nbsp;
            <asp:Literal ID="password" runat="server"></asp:Literal>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;
            GPA :&nbsp;
            <asp:Literal ID="GPA" runat="server"></asp:Literal>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;
            E-mail :&nbsp;
            <asp:Literal ID="Email" runat="server"></asp:Literal>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;
            Address :&nbsp;&nbsp;
            <asp:Literal ID="Address" runat="server"></asp:Literal>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
