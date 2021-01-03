<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inscourseUpdate.aspx.cs" Inherits="GUCera.inscourseUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 82px;
            width: 273px;
        }
        #TextArea2 {
            height: 79px;
            width: 265px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style='text-align:center'>
            <asp:Literal ID="redir" runat="server"></asp:Literal>
            <asp:Literal ID="title" runat="server"></asp:Literal>
            <div>
            <h4>Update Content</h4>
            <asp:TextBox ID="cont" runat="server"></asp:TextBox>
                <br>
            <asp:Button ID="Button1" runat="server" Text="Confirm" Onclick="updateContent" />

            </div>
            <div>
            <h4>Update Description</h4>

            <asp:TextBox ID="desc" runat="server"></asp:TextBox>
            <br>
            <asp:Button ID="Button2" runat="server" Text="Confirm" Onclick="updateDescription" />
         

            </div>

            <asp:Literal ID="msg" runat="server"></asp:Literal>

        </div>
    </form>
</body>
</html>
