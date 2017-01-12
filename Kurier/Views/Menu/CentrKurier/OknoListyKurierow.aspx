<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OknoListyKurierow.aspx.cs" Inherits="Kurier.Views.Menu.OknoListyKurierow" %>

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
            <table>
                <tr>
                    <td>Id</td>
                    <td>Imię</td>
                    <td>Nazwisko</td>
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
                        </tr>

                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </article>
    </form>
</body>
</html>
