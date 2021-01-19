<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnrolledCourses.aspx.cs" Inherits="GUCera.EnrolledCourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<head runat="server">
    <style>
        .Background 
{
    background-color:Gray;
    filter:alpha(opacity=40);
    opacity:0.4;
}
.Pnl 
{
    position:fixed;
    top:0;
    left:0;
    width:300px;
    height:100px;
    text-align:center;
    background-color:White;
    border:solid 3px black;
        }
    </style>
    <title></title>
</head>
<body>     

    <form id="form1" runat="server">    <asp:ScriptManager ID="ToolkitScriptManager1" runat="server">
</asp:ScriptManager>
        <div>
    
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
              <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
   <Columns>
      
      
        <asp:BoundField DataField="id" HeaderText="Course ID" />
       <asp:BoundField DataField="name" HeaderText="Course Name" />
        <asp:BoundField DataField="creditHours" HeaderText="Credit Hours" />
        <asp:BoundField DataField="courseDescription" HeaderText="Description" />
        <asp:BoundField DataField="price" HeaderText="Price" />
       <asp:BoundField DataField="content" HeaderText="Content" />
       <asp:BoundField DataField="instructorId" HeaderText="Instructor ID" />
       <asp:TemplateField HeaderText="Assignments"> 
           <ItemTemplate> 
           <%--<asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/AddMobileNumber.aspx" ForeColor="White">Add Mobile Number</asp:HyperLink>--%>
           <asp:LinkButton ID="ViewAssign" Text="View" runat="server" CommandArgument='<%#Eval("id")%>' OnClick="ViewAssignments" />
       </ItemTemplate>

       </asp:TemplateField>
        <asp:TemplateField HeaderText="Certificate"> 
           <ItemTemplate> 
           <%--<asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/AddMobileNumber.aspx" ForeColor="White">Add Mobile Number</asp:HyperLink>--%>
           <asp:LinkButton ID="ViewCert" Text=" Check Certificate" runat="server" CommandArgument='<%#Eval("id")%>' OnClick="ViewCertificates" />
       </ItemTemplate>

       </asp:TemplateField> 
<asp:TemplateField HeaderText="Delete">
<ItemTemplate>
<asp:LinkButton ID="lnkDel" runat="server" 
                CommandName="Delete" Text="Delete"/>
    
<asp:ConfirmButtonExtender ID="ConfirmButtonExtender1" 
                           runat="server" 
                           TargetControlID="lnkDel"
                           DisplayModalPopupID="ModalPopupExtender1"/>
                                        
<asp:ModalPopupExtender ID="ModalPopupExtender1" 
                        runat="server"
                        TargetControlID="lnkDel"
                        PopupControlID="pnlModal"
                        BackgroundCssClass="Background"
                        OkControlID="btnYes"
                        CancelControlID="btnNo"
                        />
 
<asp:Panel runat="Server" ID="pnlModal" CssClass="Pnl">
<br />         
Do you want to delete this record
<br /><br />
<asp:Button ID="btnYes" runat="server" Text="Yes"/>
<asp:Button ID="btnNo" runat="server" Text="No"/>
</asp:Panel>
</ItemTemplate>
</asp:TemplateField>
       </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        </div>

        <div id="show" runat="server">

        </div>
    </form>
</body>
</html>
