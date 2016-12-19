<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuGlowneNadawcy.aspx.cs" Inherits="Kurier.Views.Menu.MenuGlowneNadawcy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/css/main.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>Menu</header>
        <nav>
            Zalogowano jako :
            <asp:Label ID="lUser" runat="server"></asp:Label>
            <asp:Button Text="Wyloguj" OnClick="onClickBtWyloguj" runat="server" />
        </nav>
        <article>
            <p>
                <asp:Button Text="Nadaj Paczkę" OnClick="onClickBtNadaj" runat="server" />
            </p>
        </article>
    </form>
</body>
</html>
