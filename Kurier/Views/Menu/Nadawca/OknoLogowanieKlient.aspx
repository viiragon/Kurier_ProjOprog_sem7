<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OknoLogowanieKlient.aspx.cs" Inherits="Kurier.Views.Menu.LogowanieKlient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/css/main.css" />
    <title></title>

</head>

<body>
    <form id="form1" runat="server">
        <header>Logowanie Klient</header>
        <article>
            <p>
                <asp:Label ID="lError" runat="server"></asp:Label>
            </p>
            <p>
                Login :
                <asp:TextBox ID="tbLogin" runat="server"></asp:TextBox>
            </p>
            <p>
                Hasło :
                <asp:TextBox ID="tbPassword" type="password" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button Text="Zaloguj" OnClick="SignIn" runat="server" />
            </p>
            <p>
                <asp:Button Text="Nadaj paczkę bez logowania" OnClick="onClickBtNoLogin" runat="server" />
            </p>
        </article>
    </form>
</body>
</html>
