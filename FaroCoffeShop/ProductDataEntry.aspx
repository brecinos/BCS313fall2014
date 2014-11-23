<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDataEntry.aspx.cs" Inherits="FaroCoffeShop.ProductDataEntry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
<table  >
        <tr>        <td>  <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>         </td>    
                    <td>   <asp:TextBox ID="TextBox1" runat="server" BorderColor="Lime"></asp:TextBox>        </td>


        </tr>
        <tr>        <td class="auto-style1"> <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>    </td>           
                    <td class="auto-style1"> <asp:TextBox ID="TextBoxDesc" runat="server" BorderColor="Lime"></asp:TextBox>          </td>
        </tr>
        <tr>        <td class="auto-style1"> <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>    </td>           
                    <td class="auto-style1"> <asp:TextBox ID="TextBoxPrice" runat="server" Width="40" BorderColor="Lime"></asp:TextBox>          </td>
        </tr>
         <tr>        <td class="auto-style1"> <asp:Label ID="Label5" runat="server" Text="Inventory"></asp:Label>    </td>           
                    <td class="auto-style1"> <asp:TextBox ID="TextBoxInventory" Width="40" runat="server" BorderColor="Lime"></asp:TextBox>          </td>
        </tr>

        <tr>        <td> <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>          </td>  
        </tr>
        
        
        <tr>        
            <td> <asp:Button ID="Button1" runat="server" Text="Save" Width="80" OnClick="Button1_Click" />          </td>  
            <td> <asp:Button ID="Button2" runat="server" Text="Delete" Width="80" OnClick="Button1_Click" />          </td>  
        </tr>

        </table>

    <table>
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server"
                    autogenerateselectbutton="true"
                    datakeynames="CustomerID"
                    selectedindex="0">

                    <selectedrowstyle BackColor="lightblue"/>

                </asp:GridView>
            </td>


        </tr>
        </table>

</asp:Content>
