<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OknoPrzypisaniaSamochodu.aspx.cs" Inherits="Kurier.Views.Menu.Samochody.OknoPrzypisaniaSamochodu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            Przypisz Kuriera do Samochodu
        </header>
        <article>
            <table>
                <tr>
                    <td>ID</td>
                    <td>Imię</td>
                    <td>Nazwisko</td>
                    <td></td>
                </tr>
                <asp:Repeater ID="rptKurierzy" runat="server" OnItemCommand="onClickBind">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("Id") %></td>
                            <td><%# Eval("Imie") %></td>
                            <td><%# Eval("Nazwisko") %></td>
                            <td>
                                <asp:Button Text="Przypisz" ID="btBind" data-id='<%# Eval("Id") %>' PaczkaId="costam" CommandName="bind" runat="server" />
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </article>
</body>
</html>
