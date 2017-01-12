<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OknoPrzypisaniaKuriera.aspx.cs" Inherits="Kurier.Views.Menu.Samochody.OknoPrzypisaniaKuriera" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/css/main.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>Wybierz kuriera</header>
        <article>
            <table>
                <tr>
                    <td>Id</td>
                    <td>Imię</td>
                    <td>Nazwisko</td>
                    <td>Przypisz</td> 
                </tr>
                <asp:Repeater ID="rptKurierzy" runat="server" OnItemCommand="onClickPrzypisz">
                    <ItemTemplate>
                         <tr>
                            <td>Id: <%# Eval("UserId") %></td>
                            <td><%# Eval("Imie") %></td>
                            <td><%# Eval("Nazwisko") %></td>
                            <td>
                                <asp:Button Text="Przypisz" ID="btPrzypisz" CommandArgument='<%# Eval("UserId") %>' CommandName="przypisz" runat="server" />
                            </td>
                        </tr>
                    </ItemTemplate>
              </asp:Repeater>
            </table>
            <p>
                <asp:Button Text="Brak przypisania" OnClick="onClickBrakPrzypisania" runat="server" /></p>
            <p>
               
        </article>
    </form>
</body>
</html>
