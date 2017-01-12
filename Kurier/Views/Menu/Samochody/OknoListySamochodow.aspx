<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OknoListySamochodow.aspx.cs" Inherits="Kurier.Views.Menu.OknoListySamochodow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/css/main.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>Lista Samochodów</header>
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
                    <td></td>
                    <td></td> 
                </tr>
                <asp:Repeater ID="rptSamochody" runat="server" OnItemCommand="onClickDetails">
                    <ItemTemplate>
                         <tr>
                            <td>Id: <%# Eval("Id") %></td>
                            <td><%# Eval("Marka") %></td>
                            <td><%# Eval("Model") %></td>
                            <td><%# Eval("NumRejestracyjny") %></td>
                            <td>
                                <asp:Button Text="Szczegóły" ID="btDetails" CommandArgument='<%# Eval("Id") %>' CommandName="details" runat="server" />
                            </td>
                             <td>
                               <asp:Button Text="Usuń" CommandArgument='<%# Eval("Id") %>' CommandName="delete" runat="server" /></td>
                        </tr>
                    </ItemTemplate>
              </asp:Repeater>
            </table>
            <p>
                <asp:Button Text="Dodaj nowy samochód" OnClick="onClickBtAddCar" runat="server" /></p>
            <p>
               
        </article>
    </form>
</body>
</html>
