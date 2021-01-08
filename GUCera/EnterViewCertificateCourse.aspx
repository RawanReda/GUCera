<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnterViewCertificateCourse.aspx.cs" Inherits="GUCera.EnterViewCertificateCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
           <div>
            Course ID:
            <asp:TextBox ID="course_Id0" runat="server" Width="82px"></asp:TextBox>
            <asp:Button ID="course_Id" runat="server" Text="Enter" ForeColor="Black" OnClick="Button1_Click" />
               <br />
               <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            <br />
        </div>
    </form>
</body>
</html>
