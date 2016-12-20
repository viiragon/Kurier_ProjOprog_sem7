<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OknoSzczegolowSamochodu.aspx.cs" Inherits="Kurier.Views.Menu.OknoSzczegolowSamochodu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/css/main.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>Szczegóły samochodu</header>
        <article>
            <asp:PlaceHolder ID="phMessage" Visible="false" runat="server">
                <div id="message">
                    <asp:Label ID="lMessage" runat="server"></asp:Label>
                </div>
            </asp:PlaceHolder>
            <table>
                <tr>
                    <td>Id</td>
                    <td>Marka</td>
                    <td>Model</td>
                    <td>Nr rejestracyjny</td>
                    <td>stan</td>
                    <td>Kurier</td>
                    <td>Data kontroli</td>
                </tr>
                <tr>
                    <td><asp:Label ID="lId" runat="server" /></td>
                    <td><asp:Label ID="lMarka" runat="server" /></td>
                    <td><asp:Label ID="lModel" runat="server" /></td>
                    <td><asp:Label ID="lRejestracja" runat="server" /></td>
                    <td><asp:Label ID="lStan" runat="server" /></td>
                    <td><asp:Label ID="lKurier" runat="server" /></td>
                    <td><asp:Label ID="lDataKontroli" runat="server" /></td>
                </tr>
            </table>
            <asp:Button Text="Edytuj" OnClick="onClickBtCarEdit" runat="server" />
            <asp:Button Text="Usuń" OnClick="onClickBtDelete" runat="server" />
            <asp:Button Text="Przypisz kuriera" OnClick="onClickBtBindKurier" runat="server" />
            <asp:Button Text="Wyślij zlecenie do serwisu" OnClick="onClickBtSend" runat="server" />
        </article>
    </form>
</body>
</html>
