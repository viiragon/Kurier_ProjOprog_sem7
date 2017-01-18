<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuGlowneKurier.aspx.cs" Inherits="Kurier.Views.Menu.Kurier.MenuGlowneKurier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/css/main.css" />
    <title></title>
</head>
<body>
    <form runat="server">
        <header>
            Kurier
        </header>
        <nav>
            Zalogowano jako
            <asp:Label ID="lUser" runat="server"></asp:Label>
            <asp:Button Text="Wyloguj" OnClick="onClickLogout" runat="server" />
        </nav>
        <article>
            <asp:Button Text="Przypisany Samochód" OnClick="onClickCar" runat="server" />
            <asp:PlaceHolder ID="phMessage" Visible="false" runat="server">
                <div id="message">
                    <asp:Label ID="lMessage" runat="server"></asp:Label>
                </div>
            </asp:PlaceHolder>
            <asp:PlaceHolder ID="phResult" Visible="false" runat="server">
                <div><asp:Label ID="lSuccess" runat="server"></asp:Label></div>
            </asp:PlaceHolder>
            <asp:PlaceHolder ID="phTableNadane" runat="server">
                <table>
                    <tr>
                        <td>ID</td>
                        <td>Adres docelowy</td>
                        <td>Status</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <asp:Repeater ID="rptNadane" runat="server" OnItemCommand="onClickDetails">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("Id") %></td>
                                <td>
                                    <p><%# Eval("AdresAdresata.Miasto") %> <%# Eval("AdresAdresata.KodPocztowy") %></p>
                                    <p><%# Eval("AdresAdresata.Ulica") %> <%# Eval("AdresAdresata.NumerMieszkania") %></p>
                                </td>
                                <td>Nadana
                                </td>
                                <td>
                                    <asp:Button Text="Szczegóły" ID="btDetails" data-id='<%# Eval("Id") %>' PaczkaId="costam" CommandName="details" runat="server" />
                                </td>
                                <td>
                                    <asp:Button Text="Wydaj" ID="btWydaj" CommandArgument='<%# Eval("Id") %>' PaczkaId="costam" CommandName="wydaj" runat="server" />
                                </td>
                            </tr>
                            <asp:PlaceHolder ID="phDetails" runat="server" Visible="false">
                                <tr>
                                    <th colspan="4">
                                        <div>
                                            <em>Adresat : <%# Eval("Adresat.Imie") + " " + Eval("Adresat.Nazwisko") %>: </em>
                                            <p><%# Eval("Adresat.Adres.Ulica") + " " + Eval("Adresat.Adres.NumerMieszkania") + ", " + Eval("Adresat.Adres.Miasto") + " " +  Eval("Adresat.Adres.KodPocztowy") %></p>
                                        </div>
                                        <div>
                                            <em>Nadawca : <%# Eval("Nadawca.Imie") + " " + Eval("Nadawca.Nazwisko") %>: </em>
                                            <p><%# Eval("Nadawca.Adres.Ulica") + " " + Eval("Nadawca.Adres.NumerMieszkania") + ", " + Eval("Nadawca.Adres.Miasto") + " " +  Eval("Nadawca.Adres.KodPocztowy") %></p>
                                        </div>
                                        <div>
                                            <em>Nadana : </em><%# Eval("PoczatekObslugi") %>
                                        </div>
                                        <div>
                                            <em>Odebrana : </em><%# Eval("KoniecObslugi") %>
                                        </div>
                                    </th>
                                </tr>
                            </asp:PlaceHolder>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
            </asp:PlaceHolder>
            <asp:PlaceHolder ID="phPustaNadane" Visible="false" runat="server">
                <div id="message">
                    Brak nadanych paczek
                </div>
            </asp:PlaceHolder>
            <asp:PlaceHolder ID="phTableWDrodze" runat="server">
                <table>
                    <tr>
                        <td>ID</td>
                        <td>Adres docelowy</td>
                        <td>Status</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <asp:Repeater ID="rptWDrodze" runat="server" OnItemCommand="onClickDetails">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("Id") %></td>
                                <td>
                                    <p><%# Eval("AdresAdresata.Miasto") %> <%# Eval("AdresAdresata.KodPocztowy") %></p>
                                    <p><%# Eval("AdresAdresata.Ulica") %> <%# Eval("AdresAdresata.NumerMieszkania") %></p>
                                </td>
                                <td>W drodze
                                </td>
                                <td>
                                    <asp:Button Text="Szczegóły" ID="btDetails" data-id='<%# Eval("Id") %>' PaczkaId="costam" CommandName="details" runat="server" />
                                </td>
                                <td>
                                    <asp:Button Text="Doręcz" ID="btDorecz" CommandArgument='<%# Eval("Id") %>' PaczkaId="costam" CommandName="dorecz" runat="server" />
                                </td>
                            </tr>
                            <asp:PlaceHolder ID="phDetails" runat="server" Visible="false">
                                <tr>
                                    <th colspan="4">
                                        <div>
                                            <em>Adresat : <%# Eval("Adresat.Imie") + " " + Eval("Adresat.Nazwisko") %>: </em>
                                            <p><%# Eval("Adresat.Adres.Ulica") + " " + Eval("Adresat.Adres.NumerMieszkania") + ", " + Eval("Adresat.Adres.Miasto") + " " +  Eval("Adresat.Adres.KodPocztowy") %></p>
                                        </div>
                                        <div>
                                            <em>Nadawca : <%# Eval("Nadawca.Imie") + " " + Eval("Nadawca.Nazwisko") %>: </em>
                                            <p><%# Eval("Nadawca.Adres.Ulica") + " " + Eval("Nadawca.Adres.NumerMieszkania") + ", " + Eval("Nadawca.Adres.Miasto") + " " +  Eval("Nadawca.Adres.KodPocztowy") %></p>
                                        </div>
                                        <div>
                                            <em>Nadana : </em><%# Eval("PoczatekObslugi") %>
                                        </div>
                                        <div>
                                            <em>Odebrana : </em><%# Eval("KoniecObslugi") %>
                                        </div>
                                    </th>
                                </tr>
                            </asp:PlaceHolder>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
            </asp:PlaceHolder>
            <asp:PlaceHolder ID="phPustaWDrodze" Visible="false" runat="server">
                <div id="message">
                    Brak paczek w drodze
                </div>
            </asp:PlaceHolder>
            <asp:PlaceHolder ID="phTableDoreczone" runat="server">
                <table>
                    <tr>
                        <td>ID</td>
                        <td>Adres docelowy</td>
                        <td>Status</td>
                        <td></td>
                    </tr>
                    <asp:Repeater ID="rptDoreczone" runat="server" OnItemCommand="onClickDetails">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("Id") %></td>
                                <td>
                                    <p><%# Eval("AdresAdresata.Miasto") %> <%# Eval("AdresAdresata.KodPocztowy") %></p>
                                    <p><%# Eval("AdresAdresata.Ulica") %> <%# Eval("AdresAdresata.NumerMieszkania") %></p>
                                </td>
                                <td>Doręczona
                                </td>
                                <td>
                                    <asp:Button Text="Szczegóły" ID="btDetails" data-id='<%# Eval("Id") %>' PaczkaId="costam" CommandName="details" runat="server" />
                                </td>
                            </tr>
                            <asp:PlaceHolder ID="phDetails" runat="server" Visible="false">
                                <tr>
                                    <th colspan="4">
                                        <div>
                                            <em>Adresat : <%# Eval("Adresat.Imie") + " " + Eval("Adresat.Nazwisko") %>: </em>
                                            <p><%# Eval("Adresat.Adres.Ulica") + " " + Eval("Adresat.Adres.NumerMieszkania") + ", " + Eval("Adresat.Adres.Miasto") + " " +  Eval("Adresat.Adres.KodPocztowy") %></p>
                                        </div>
                                        <div>
                                            <em>Nadawca : <%# Eval("Nadawca.Imie") + " " + Eval("Nadawca.Nazwisko") %>: </em>
                                            <p><%# Eval("Nadawca.Adres.Ulica") + " " + Eval("Nadawca.Adres.NumerMieszkania") + ", " + Eval("Nadawca.Adres.Miasto") + " " +  Eval("Nadawca.Adres.KodPocztowy") %></p>
                                        </div>
                                        <div>
                                            <em>Nadana : </em><%# Eval("PoczatekObslugi") %>
                                        </div>
                                        <div>
                                            <em>Odebrana : </em><%# Eval("KoniecObslugi") %>
                                        </div>
                                    </th>
                                </tr>
                            </asp:PlaceHolder>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
            </asp:PlaceHolder>
            <asp:PlaceHolder ID="phPustaDoreczone" Visible="false" runat="server">
                <div id="message">
                    Brak doręczonych paczek
                </div>
            </asp:PlaceHolder>
        </article>
    </form>
</body>
</html>
