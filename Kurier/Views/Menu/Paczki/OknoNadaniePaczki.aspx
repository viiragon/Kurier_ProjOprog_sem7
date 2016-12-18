<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OknoNadaniePaczki.aspx.cs" Inherits="Kurier.Views.Menu.NadaniePaczki" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/css/main.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>Nadaj Paczkę</header>
        <article>
            <p>
                <asp:Label ID="lError" runat="server"></asp:Label>
            </p>
            <p>
                Adresat :
            <asp:TextBox ID="tbAdresat" runat="server"></asp:TextBox>
            </p>
            <p>
                Adres Adresata :
            <asp:TextBox ID="tbAdresAdresata" runat="server"></asp:TextBox>
            </p>
            <p>
                Nadawca :
            <asp:TextBox ID="tbNadawca" runat="server"></asp:TextBox>
            </p>
            <p>
                Adres Nadawcy :
            <asp:TextBox ID="tbAdresNadawcy" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button Text="Nadaj" OnClick="onClickBtNadaj" runat="server" />
            </p>
        </article>
    </form>
</body>
</html>
