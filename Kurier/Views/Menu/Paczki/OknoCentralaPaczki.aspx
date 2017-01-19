<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OknoCentralaPaczki.aspx.cs" Inherits="Kurier.Views.Menu.CentralaPaczki" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/css/main.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>Lista Paczek</header>
        <article>
            <table>                
                <tr>
                    <td>Id</td>
                    <td>Status</td>
                    <td></td>
                    <td></td>
                </tr>
                <asp:Repeater ID="rptPaczki" runat="server" OnItemCommand="onClickButton">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("IdPaczki") %></td>
                            <td>
                                <asp:PlaceHolder ID="placeholderBlaBlaBla" runat="server" Visible='<%# Convert.ToInt32(Eval("Status.KodStatusu")) == 1 %>'>Nadana
                                </asp:PlaceHolder>
                                <asp:PlaceHolder ID="placeholder1" runat="server" Visible='<%# Convert.ToInt32(Eval("Status.KodStatusu")) == 0 %>'>Doręczona
                                </asp:PlaceHolder>
                            </td>
                            <td>
                                <asp:Button Text="Szczegóły" ID="btDetails" CommandArgument='<%# Eval("Id") %>' CommandName="details" runat="server" /></td>
                            <td>
                                <asp:Button Text="Kurier" ID="btKurier" CommandArgument='<%# Eval("Id") %>' CommandName="kurier"  runat="server" /></td>
                        </tr>

                    </ItemTemplate>
                </asp:Repeater>
            </table>
            <asp:Button Text="Statystyki dostarczonych paczek" OnClick="onClickBtStatystykiDostarczonychPaczek" runat="server" />
        </article>
    </form>
</body>
</html>
