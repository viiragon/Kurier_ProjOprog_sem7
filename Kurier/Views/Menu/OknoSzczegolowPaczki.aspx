<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OknoSzczegolowPaczki.aspx.cs" Inherits="Kurier.Views.Menu.OknoSzczegolowPaczki" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/css/main.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Repeater ID="rptPaczki" runat="server">
            <HeaderTemplate>
                <div id="divPaczki">
            </HeaderTemplate>
            <ItemTemplate>
                       <div><b>Adresat: </b><%# Eval("Adres.Ulica") %> <%# Eval("Adres.NumerMieszkania") %>, <%# Eval("Adres.KodPocztowy") %> <%# Eval("Adres.Miasto") %></div>
                       <div><b>Historia:</b></div>
                       <div>Nadana: <%# Eval("PoczatekObslugi") %></div>
                       <div>Odebrana: <%# Eval("KoniecObslugi") %></div>
            </ItemTemplate>
            <AlternatingItemTemplate>   
                       <div><b>Adresat: </b><%# Eval("Adres.Ulica") %> <%# Eval("Adres.NumerMieszkania") %>, <%# Eval("Adres.KodPocztowy") %> <%# Eval("Adres.Miasto") %></div>
                       <div><b>Historia:</b></div>
                       <div>Nadana: <%# Eval("PoczatekObslugi") %></div>
            </AlternatingItemTemplate>
            <FooterTemplate>
                </div>
            </FooterTemplate>
        </asp:Repeater>
     

        <asp:Repeater ID="rptKurier" runat="server">
            <HeaderTemplate>
                <div id="divPaczki">
            </HeaderTemplate>
            <ItemTemplate>
                <asp:PlaceHolder ID="placeholderBlaBlaBla" runat="server" Visible='<%# Convert.ToInt32(Eval("Id")) == 1 %>'>
                <div><b>Dane Kuriera:</b> </div>
                <div><b>Imię: </b> <%# Eval("Imie") %></div>
                <div><b>Nazwisko: </b> <%# Eval("Nazwisko") %></div>
                <div><b>Adres: </b> <%# Eval("Adres.Ulica") %>  <%# Eval("Adres.NumerMieszkania") %>, <%# Eval("Adres.KodPocztowy") %> <%# Eval("Adres.Miasto") %></div>
         </asp:placeholder>
         <asp:PlaceHolder ID="placeholder1" runat="server" Visible='<%# Convert.ToInt32(Eval("Id")) == 3 %>'>
              Brak przypisanego kuriera do paczki!
         </asp:placeholder>
                   </ItemTemplate>
            <AlternatingItemTemplate>   
                <asp:PlaceHolder ID="placeholderBlaBlaBla" runat="server" Visible='<%# Convert.ToInt32(Eval("Id")) == 1 %>'>
                <div><b>Dane Kuriera:</b> </div>
                <div><b>Imię: </b> <%# Eval("Imie") %></div>
                <div><b>Nazwisko: </b> <%# Eval("Nazwisko") %></div>
                <div><b>Adres: </b> <%# Eval("Adres.Ulica") %>  <%# Eval("Adres.NumerMieszkania") %>, <%# Eval("Adres.KodPocztowy") %> <%# Eval("Adres.Miasto") %></div>
     
         </asp:placeholder>
         <asp:PlaceHolder ID="placeholder1" runat="server" Visible='<%# Convert.ToInt32(Eval("Id")) == 3 %>'>
              Brak przypisanego kuriera do paczki!
         </asp:placeholder>

            </AlternatingItemTemplate>
            <FooterTemplate>
                </div>
            </FooterTemplate>
        </asp:Repeater>


     
        
    </div>
    </form>
</body>
</html>
