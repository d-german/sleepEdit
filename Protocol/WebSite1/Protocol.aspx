<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Protocol.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Hello World"></asp:Label>
        <asp:Xml ID="Xml1" runat="server"></asp:Xml></div>
        <asp:TreeView ID="TreeView1" runat="server" Height="386px" ImageSet="Events" ShowLines="True"
            Width="551px">
            <ParentNodeStyle Font-Bold="False" />
            <HoverNodeStyle Font-Underline="False" ForeColor="Red" />
            <SelectedNodeStyle Font-Underline="True" HorizontalPadding="0px" VerticalPadding="0px" />
            <Nodes>
                <asp:TreeNode NavigateUrl="~/Protocol.aspx" ShowCheckBox="True" Text="Google" Value="Google">
                </asp:TreeNode>
            </Nodes>
            <NodeStyle Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" HorizontalPadding="5px"
                NodeSpacing="0px" VerticalPadding="0px" />
        </asp:TreeView>
    </form>
</body>
</html>
