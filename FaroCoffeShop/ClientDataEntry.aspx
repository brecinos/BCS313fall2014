<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClientDataEntry.aspx.cs" Inherits="FaroCoffeShop.ClientDataEntry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 53px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table  >
        <tr>        <td>  <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>         </td>    
                    <td>   <asp:TextBox ID="TextBox1" runat="server" BorderColor="Lime"></asp:TextBox>        </td>


        </tr>
        <tr>        <td class="auto-style1"> <asp:Label ID="Label2" runat="server" Text="E-mail"></asp:Label>    </td>           
                    <td class="auto-style1"> <asp:TextBox ID="TextBox2" runat="server" BorderColor="Lime"></asp:TextBox>          </td>
        </tr>
        <tr>        <td> <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>          </td>  
        </tr>
        
        
        <tr>        <td> <asp:Button ID="Button1" runat="server" Text="Save Client" OnClick="Button1_Click" />          </td>  

        </tr>

        </table>

    <table>
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </td>


        </tr>
        </table>


</asp:Content>
