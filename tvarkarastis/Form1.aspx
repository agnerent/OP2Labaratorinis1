<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form1.aspx.cs" Inherits="tvarkarastis.Form1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Mokinių tvarkaraštis"></asp:Label>
            <br />
            <asp:Table ID="Table1" runat="server">
            </asp:Table>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Mokytojų tvarkaraštis"></asp:Label>
            <br />
            <br />
            <asp:Table ID="Table2" runat="server">
            </asp:Table>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Tvarkarštis" />
        </div>
    </form>
</body>
</html>
