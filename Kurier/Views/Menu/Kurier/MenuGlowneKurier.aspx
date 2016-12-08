<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuGlowneKurier.aspx.cs" Inherits="Kurier.Views.Menu.Kurier.MenuGlowneKurier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Zalogowano jako <asp:Label ID="lUser" runat="server"></asp:Label> <asp:Button Text="Wyloguj" OnClick="onClickLogout" runat="server"/></p>
            <h1>Kurier</h1>
            
            <asp:Button Text="Wydaj Paczkę" OnClick="onClickSendPackage" runat="server"/>
            <asp:Button Text="Przypisany Samochód" OnClick="onClickCar" runat="server"/>
            <p><asp:Label ID="lMessage" runat="server"></asp:Label></p>
            <table>
                <asp:Repeater ID="rptZlecenia" runat="server" OnItemCommand="onClickDetails">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("Id") %></td>
                            <td>
                                <p><%# Eval("Adres.Miasto") %> <%# Eval("Adres.KodPocztowy") %></p>
                                <p><%# Eval("Adres.Ulica") %> <%# Eval("Adres.NumerMieszkania") %></p>
                            </td>
                            <td>
                                <asp:PlaceHolder ID="placeholderBlaBlaBla" runat="server" Visible='<%# Convert.ToInt32(Eval("Status.KodStatusu")) == 1 %>'>Nadana
                                </asp:PlaceHolder>
                                <asp:PlaceHolder ID="placeholder1" runat="server" Visible='<%# Convert.ToInt32(Eval("Status.KodStatusu")) == 0 %>'>Doręczona
                                </asp:PlaceHolder>
                            </td>
                            <td>
                                <asp:Button Text="Szczegóły" ID="btDetails" data-id='<%# Eval("Id") %>' PaczkaId="costam" CommandName="details" runat="server"/>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </form>
</body>
</html>
