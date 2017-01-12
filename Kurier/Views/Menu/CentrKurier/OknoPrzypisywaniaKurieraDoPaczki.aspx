<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OknoPrzypisywaniaKurieraDoPaczki.aspx.cs" Inherits="Kurier.Views.Menu.OknoPrzypisywaniaKurieraDoPaczki" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/css/main.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>Lista Kurierów</header>
        <article>
            Brak przypisanego kuriera!
            <asp:PlaceHolder ID="phNIMA" Visible="false" runat="server">
                <div>Brak kurierów w bazie!</div>
            </asp:PlaceHolder>
            <asp:PlaceHolder ID="phLista" Visible="true" runat="server">
                <table>
                    <tr>
                        <td>Id</td>
                        <td>Imię</td>
                        <td>Nazwisko</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <asp:Repeater ID="rptKurierzy" runat="server" OnItemCommand="onClickButton">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("UserId") %></td>
                                <td>
                                    <%# Eval("Imie") %>
                                </td>
                                <td>
                                    <%# Eval("Nazwisko") %>
                                </td>
                                <td>
                                    <asp:Button Text="Szczegóły" ID="btDetails" CommandArgument='<%# Eval("UserId") %>' CommandName="details" runat="server" /></td>
                                <td>
                                    <asp:Button Text="Przypisz" ID="btPrzypisz" CommandArgument='<%# Eval("UserId") %>' CommandName="przypisz" runat="server" /></td>
                            </tr>

                        </ItemTemplate>
                    </asp:Repeater>
                </table>
            </asp:PlaceHolder>
        </article>
    </form>
</body>
</html>
