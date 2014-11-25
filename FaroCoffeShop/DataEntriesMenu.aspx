<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DataEntriesMenu.aspx.cs" Inherits="FaroCoffeShop.DataEntriesMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <table>
        <tr>
            <td> <asp:Button ID="ButtonClient" runat="server" Text="Client" BorderColor="#FF5050" OnClick="ButtonClient_Click" />    </td>
   
        </tr>
        <tr>

            <td> <asp:Button ID="ButtonPayment" runat="server" Text="Payment" BorderColor="#66FF33" OnClick="ButtonPayment_Click" />   </td>
      
        </tr>

        <tr>
            <td>  <asp:Button ID="ButtonEmployee" runat="server" Text="Employee" BorderColor="#00CCFF" OnClick="ButtonEmployee_Click" />   </td>
       
        </tr>
        <tr>
            <td>  <asp:Button ID="ButtonProduct" runat="server" Text="Product" BorderColor="#9900FF" OnClick="ButtonProduct_Click" />   </td>
       
        </tr>

        <tr>
          <td>  <asp:Button ID="ButtonGenerateOrder" runat="server" Text="Generate Order" BorderColor="#0066CC" Height="46px" Width="352px" OnClick="ButtonGenerateOrder_Click"  />  </td>
        </tr>

        </table>


</asp:Content>
