<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentAddFeedback.aspx.cs" Inherits="GUCera.StudentAddFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">   
       
        <div>
            <p>
        <asp:Literal ID="SubmitFeedbackMssg" runat="server"></asp:Literal></p>
       <p style="font-weight: bolder">Please enter the required info to submit your assignment</p>
            Course ID:<asp:TextBox ID="course_ID" runat="server"></asp:TextBox>
        <br />
            Comment:<asp:TextBox ID="comment" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="FeedbackNow" runat="server" Text="Add Feedback" OnClick="AddNow_Click" />
            </div>
    </form>
</body>
</html>
