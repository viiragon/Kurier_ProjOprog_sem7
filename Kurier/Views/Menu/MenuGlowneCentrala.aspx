<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuGlowneCentrala.aspx.cs" Inherits="Kurier.Views.Menu.MenuGlowneCentrala" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/css/main.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            Menu
        </header>
        <nav>
            Zalogowano jako :
            <asp:Label ID="lUser" runat="server"></asp:Label>
            <asp:Button Text="Wyloguj" OnClick="onClickBtWyloguj" runat="server" />
        </nav>
        <article>
            <p>
                <asp:Button Text="Lista Kurierów" OnClick="onClickBtListaKurierow" runat="server" />
            </p>
            <p>
                <asp:Button Text="Lista Paczek" OnClick="onClickBtListaPaczek" runat="server" />
            </p>
            <p>
                <asp:Button Text="Lista Samochodów" OnClick="onClickBtListaSamochodow" runat="server" />
            </p>
            <p>
                <asp:Button Text="Najczęstsi klienci" OnClick="onClickBtNajczestsiKlienci" runat="server" />
            </p>
            <p>
                <asp:Button Text="Najczestsze miasta docelowe" OnClick="onClickBtNajczestszeMiasta" runat="server" />
            </p>
            <p>
                <asp:Button Text="Obciążenie kurierów" OnClick="onClickBtObciazenie" runat="server" />
            </p>
        </article>
    </form>
</body>
</html>
