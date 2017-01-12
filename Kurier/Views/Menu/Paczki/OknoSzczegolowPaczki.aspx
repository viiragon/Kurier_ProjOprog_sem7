<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OknoSzczegolowPaczki.aspx.cs" Inherits="Kurier.Views.Menu.OknoSzczegolowPaczki" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/css/main.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>Szczegóły Paczki</header>
        <article>
            <div><b>Adresat: </b><asp:Label ID="lAdresat" runat="server"></asp:Label></div>
            <div><b>Historia:</b></div>
            <div>Nadana: <asp:Label ID="lNadana" runat="server"></asp:Label></div>
            <div>Odebrana: <asp:Label ID="lOdebrana" runat="server"></asp:Label></div>

            <asp:PlaceHolder ID="phKurier" runat="server" Visible="true">
                <div><b>Dane Kuriera:</b> </div>
                <div><b>Imię: </b><asp:Label ID="lImie" runat="server"></asp:Label></div>
                <div><b>Nazwisko: </b><asp:Label ID="lNazwisko" runat="server"></asp:Label></div>
                <div><b>Adres: </b><asp:Label ID="LKurierAdres" runat="server"></asp:Label></div>
            </asp:PlaceHolder>
            <asp:PlaceHolder ID="phBrakKuriera" runat="server" Visible="false">
                Brak przypisanego kuriera do paczki!
            </asp:PlaceHolder>
        </article>
    </form>
</body>
</html>
