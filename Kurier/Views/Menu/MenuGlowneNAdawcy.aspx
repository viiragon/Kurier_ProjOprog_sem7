<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuGlowneNadawcy.aspx.cs" Inherits="Kurier.Views.Menu.MenuGlowneNadawcy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                Zalogowano jako : <asp:Label ID="lUser" runat="server"></asp:Label>
                <asp:Button Text="Wyloguj" OnClick="onClickBtWyloguj" runat="server" />
            </p>
            <h1>Menu</h1>
            <p>
                <asp:Button Text="Nadaj Paczkę" OnClick="onClickBtNadaj" runat="server" />
            </p>
        </div>
    </form>
</body>
</html>
