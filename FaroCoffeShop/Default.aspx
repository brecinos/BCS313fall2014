<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FaroCoffeShop._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <img src="Images/TASSE01.jpg" width="800" height="200" />
            <hgroup class="title">
                <h2> What makes a good coffee? What’s the best coffee in the world?  </h2>
            </hgroup>
            
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>We suggest the following:</h3>
    <ol class="round">
        <li class="one">
            <h5>Clerk Application</h5>
            <asp:Button ID="ButtonClerkApplication" runat="server" Text="Data Enter" Width="104px" OnClick="ButtonClerkApplication_Click" />
        </li>
        <li class="two">
            <h5>Assign internet to customer</h5>
            <asp:Button ID="ButtonInternetAssignment" runat="server" Text="Intenet" Width="100px" OnClick="ButtonInternetAssignment_Click" />
        </li>
        
    </ol>
</asp:Content>
