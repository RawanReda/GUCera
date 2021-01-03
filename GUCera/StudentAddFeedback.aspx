<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentAddFeedback.aspx.cs" Inherits="GUCera.StudentAddFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        <div>
        
        Please enter the required info to submit your assignment:<br />
        <asp:Literal ID="SubmitFeedbackMssg" runat="server"></asp:Literal>
        <br />
        <br />
            Course ID:<asp:TextBox ID="course_ID" runat="server"></asp:TextBox>
            <br />
        <br />
            Comment:<asp:TextBox ID="comment" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="FeedbackNow" runat="server" Text="Add Feedback" OnClick="AddNow_Click" />
            </div>
    </form>
</body>
</html>
