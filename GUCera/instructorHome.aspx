<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="instructorHome.aspx.cs" Inherits="GUCera.instructorHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Instructor Home</title>
</head>
<body>
    <form id="form1" runat="server">
        <div >

            <asp:Label ID="Name1" runat="server" Text=""></asp:Label>
            <div id ="Information"> </div>
            <asp:Button ID="Button1" runat="server" Text="View Courses" OnClick ="viewCourses" Width="219px"/>


        </div>
    </form>
</body>
</html>
