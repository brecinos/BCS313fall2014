<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClientDataEntry.aspx.cs" Inherits="FaroCoffeShop.ClientDataEntry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 53px;
        }
        .auto-style2 {
            width: 157px;
        }
        .auto-style3 {
            height: 53px;
            width: 157px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table  >
        <tr>        <td class="auto-style2">  <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>         </td>    
                    <td>   <asp:TextBox ID="TextBox1" runat="server" BorderColor="Lime"></asp:TextBox>        </td>


        </tr>
        <tr>        <td class="auto-style3"> <asp:Label ID="Label2" runat="server" Text="E-mail"></asp:Label>    </td>           
                    <td class="auto-style1"> <asp:TextBox ID="TextBox2" runat="server" BorderColor="Lime"></asp:TextBox>          </td>
        </tr>
        <tr>        <td class="auto-style2"> <asp:Label ID="Label3" runat="server" Text="Payment Method:"></asp:Label> 

                    </td>  
                    <td>
                        <asp:DropDownList ID="DropDownListPayment"  AutoPostBack="true"   runat ="server"></asp:DropDownList>
                    </td>
        </tr>
        
        
        <tr>        <td class="auto-style2"> <asp:Button ID="Button1" runat="server" Text="Save Client" OnClick="Button1_Click" Width="144px" />          </td>  

        </tr>

        </table>

    <table>
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server"
                    autogenerateselectbutton="true"
                    datakeynames="idclient"
                    selectedindex="0">

                    <selectedrowstyle BackColor="lightblue"/>

                </asp:GridView>
            </td>


        </tr>
        </table>


</asp:Content>
