<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OknoSamochoduKuriera.aspx.cs" Inherits="Kurier.Views.Menu.OknoSamochoduKuriera" %>

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
                    <td>Data kontroli</td>
                </tr>
                <tr>
                    <td><asp:Label ID="lId" runat="server" /></td>
                    <td><asp:Label ID="lMarka" runat="server" /></td>
                    <td><asp:Label ID="lModel" runat="server" /></td>
                    <td><asp:Label ID="lRejestracja" runat="server" /></td>
                    <td><asp:Label ID="lStan" runat="server" /></td>
                    <td><asp:Label ID="lDataKontroli" runat="server" /></td>
                </tr>
            </table>
        </article>
    </form>
</body>
</html>
