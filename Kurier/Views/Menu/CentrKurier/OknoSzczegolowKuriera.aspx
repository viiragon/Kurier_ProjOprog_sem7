<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OknoSzczegolowKuriera.aspx.cs" Inherits="Kurier.Views.Menu.OknoSzczegolowKuriera" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/css/main.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>Szczegóły Kuriera</header>
        <article>            
            <asp:PlaceHolder ID="phMessage" Visible="false" runat="server">
                <div id="message">
                    <asp:Label ID="lMessage" runat="server"></asp:Label>
                </div>
            </asp:PlaceHolder>
            <div><b>Dane Kuriera:</b> </div>
            <div><b>Imię: </b>
                <asp:Label ID="lImie" runat="server"></asp:Label></div>
            <div><b>Nazwisko: </b>
                <asp:Label ID="lNazwisko" runat="server"></asp:Label></div>
            <div><b>Adres: </b>
                <asp:Label ID="LKurierAdres" runat="server"></asp:Label></div>
        </article>
    </form>
</body>
</html>
