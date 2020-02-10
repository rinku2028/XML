<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addtogrid.aspx.cs" Inherits="xmlapp.addtogrid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnclick" runat="server" Text="Click" OnClick="btnclick_Click" /> </br>
            <asp:GridView ID="gdview1" runat="server"></asp:GridView>
            <asp:Label ID="lblmessage" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
