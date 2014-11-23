<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="FaroCoffeShop.Contact" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Brûleries FARO.</h2>
    </hgroup>

    <section class="contact">
        <header>
            <h3>Phone:</h3>
        </header>
        <p>
            <span class="label">Main:</span>
            <span>819 564 8844</span>
        </p>
     

    <section class="contact">
        <header>
            <h3>Email:</h3>
        </header>
        <p>
            <span class="label">Main:</span>
            <span><a href="mfabi@cafefaro.com">mfabi@cafefaro.com</a></span>
        </p>
       
    </section>

    <section class="contact">
        <header>
            <h3>Address:</h3>
        </header>
        <p>
            
            930 Rue Blais Sherbrooke, <br> Québec Canada
        </p>
    </section>
</asp:Content>