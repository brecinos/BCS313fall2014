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

         <tr> <td>  <asp:Label ID="Label1" runat="server" Text="Product"></asp:Label>         </td>    
             <td class="auto-style1">
                     <asp:DropDownList ID="DropDownListProduct" runat="server"></asp:DropDownList>
             </td>
             <td>
                 
                 </td>
             <td>
                 
             </td>

         </tr>


        <tr>        <td> <asp:Label ID="Label3" runat="server" Text="Quantity "></asp:Label>  </td>    
                    <td class="auto-style1">  
                        <asp:TextBox ID="TextBoxQuantity" runat="server" Width="60px"></asp:TextBox> </td>
        </tr>
        
        <tr>        <td> .</td> 
                    <td class="auto-style1">.</td> 
        </tr>
        
        
        <tr>        
            <td> <asp:Button ID="ButtonGenerateOrder" runat="server" Text="Generate Order" BorderColor="#660066" OnClick="ButtonGenerateOrder_Click" />    </td>  
            <td class="auto-style1"></td>  
        </tr>

         <tr>
             <td>
              <asp:Button ID="ButtonAddProduct" runat="server" Text="Add Product to Order" BorderColor="#990000" OnClick="ButtonAddProduct_Click" />    
                 </td>
             <td></td>
             </tr>
        </table>


     <table>
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server"
                    autogenerateselectbutton="false"
                    datakeynames="OrderId"
                    selectedindex="0">

                    <selectedrowstyle BackColor="lightblue"/>

                </asp:GridView>
            </td>
        </tr>
        </table>

    
     <table>
        <tr>
            <td>
                <asp:HiddenField ID="HiddenFieldOrderId" runat="server" />
                <asp:GridView ID="GridView2" runat="server"
                    autogenerateselectbutton="false"
                    datakeynames="OrderDetailId"
                    selectedindex="0">

                    <selectedrowstyle BackColor="lightblue"/>

                </asp:GridView>
            </td>

        </tr>
        </table>


</asp:Content>
