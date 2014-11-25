<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeDataEntry.aspx.cs" Inherits="FaroCoffeShop.EmployeeDataEntry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
     <table  >
        <tr>        <td>  <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>         </td>    
                    <td>   <asp:TextBox ID="TextBoxName" runat="server" Width="80" BorderColor="Lime"></asp:TextBox>        </td>
        </tr>
        
        <tr>        <td> <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>          </td> 
                    <td></td> 
        </tr>
        
        
        <tr>        
            <td> <asp:Button ID="ButtonSave" runat="server" Text="Save" Width="80" OnClick="ButtonSave_Click"   />          </td>  
            <td> &nbsp;</td>  
        </tr>

        </table>

    <table>
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server"
                    autogenerateselectbutton="true"
                    datakeynames="IdEmployee"
                    selectedindex="0">

                    <selectedrowstyle BackColor="lightblue"/>

                </asp:GridView>
            </td>


        </tr>
        </table>

</asp:Content>
