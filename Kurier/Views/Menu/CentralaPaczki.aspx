<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CentralaPaczki.aspx.cs" Inherits="Kurier.Views.Menu.CentralaPaczki" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>CENTRALA Paczki</h1>
       
       <asp:Button Text="Szczegóły" OnClick="onClickDetails" runat="server"/>
        <table>
            <asp:Repeater ID="rptPaczki" runat="server">
            <HeaderTemplate>
                <div id="divPaczki">
            </HeaderTemplate>
            <ItemTemplate>
                   <tr>
                       <td><%# Eval("Id") %></td>
                       <td>
                           <asp:PlaceHolder ID="placeholderBlaBlaBla" runat="server" Visible='<%# Convert.ToInt32(Eval("Status.KodStatusu")) == 1 %>'>
                               Nadana
                            </asp:placeholder>
                           <asp:PlaceHolder ID="placeholder1" runat="server" Visible='<%# Convert.ToInt32(Eval("Status.KodStatusu")) == 0 %>'>
                               Doręczona
                            </asp:placeholder>
                       </td>
                       <td><asp:Button Text="Szczegóły" OnClick="onClickDetails" runat="server"/></td>
                       <td><asp:Button Text="Kurier" OnClick="onClickKurier" runat="server"/></td>
                   </tr>
               
            </ItemTemplate>
            <AlternatingItemTemplate>   
                   <tr>
                       <td><%# Eval("Id") %></td>
                       <td>
                           <asp:PlaceHolder ID="placeholderBlaBlaBla" runat="server" Visible='<%# Convert.ToInt32(Eval("Status.KodStatusu")) == 0 %>'>
                               Nadana
                            </asp:placeholder>
                           <asp:PlaceHolder ID="placeholder1" runat="server" Visible='<%# Convert.ToInt32(Eval("Status.KodStatusu")) == 1 %>'>
                               Doręczona
                            </asp:placeholder>
                       </td>
                       <td><asp:Button Text="Szczegóły" OnClick="onClickDetails" runat="server"/></td>
                       <td><asp:Button Text="Kurier" OnClick="onClickKurier" runat="server"/></td>
                   </tr>
            </AlternatingItemTemplate>
            <FooterTemplate>
                </div>
            </FooterTemplate>
        </asp:Repeater>
        </table>
    </div>
    </form>
</body>
</html>
