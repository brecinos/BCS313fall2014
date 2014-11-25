<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GenerateOrder.aspx.cs" Inherits="FaroCoffeShop.GenerateOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 452px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

     <table  >


         <tr>  <td>  <asp:Label ID="Label2" runat="server" Text="Client"></asp:Label>         </td>    
         
             <td class="auto-style1">
                     <asp:DropDownList ID="DropDownListClient" runat="server"></asp:DropDownList>
             </td>

         </tr>

         <tr>        <td>  <asp:Label ID="Label4" runat="server" Text="Employee"></asp:Label>         </td>    
         
             <td class="auto-style1">
                     <asp:DropDownList ID="DropDownListEmployee" runat="server"></asp:DropDownList>
             </td>

         </tr>

        <tr>        <td>  &nbsp;</td>    
                    <td class="auto-style1">  
                        &nbsp;</td>
        </tr>
        
        <tr>        <td> &nbsp;</td> 
                    <td class="auto-style1"></td> 
        </tr>
        
        
        <tr>        
            <td> <asp:Button ID="ButtonSave" runat="server" Text="Save" Width="80"   />          </td>  
            <td class="auto-style1"> &nbsp;</td>  
        </tr>

        </table>


</asp:Content>
