<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaymentDataEntry.aspx.cs" Inherits="FaroCoffeShop.PaymentDataEntry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table  >
        <tr>        <td>  <asp:Label ID="Label1" runat="server" Text="Payment Method"></asp:Label>         </td>    
                    <td>   <asp:TextBox ID="TextBoxPayment" runat="server" Width="80" BorderColor="Lime"></asp:TextBox>        </td>
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
