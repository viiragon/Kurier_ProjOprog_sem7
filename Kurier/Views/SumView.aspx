<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SumView.aspx.cs" Inherits="Kurier.SumView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aplikacja testowa</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>
            Dodawanie!
        </h1>
        <p>
            <asp:TextBox ID="tbElementA" type="number" runat="server"></asp:TextBox>
            +
            <asp:TextBox ID="tbElementB" type="number" runat="server"></asp:TextBox>
            =
            <asp:Label ID="lSum" runat="server" ForeColor="red"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btSum" Text="Oblicz" OnClick="onClickBtSum" runat="server"/>
        </p>
    </form>
</body>
</html>
