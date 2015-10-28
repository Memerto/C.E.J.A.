<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Crear_Propuesta.aspx.cs" Inherits="Prototipo1DG.Crear_Propuesta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>
                <asp:Label ID="lblTitulo" runat="server" Text="Ingrese el titulo de la propuesta"></asp:Label>
                <br>
                <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            <br>
                <asp:Label ID="lblTipoPropuesta" runat="server" Text="Tipo Propuesta"></asp:Label>
                <br>
                <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Oficial</asp:ListItem>
                <asp:ListItem>Simple</asp:ListItem>
                <asp:ListItem>Muy Simple</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
            <br>
            <asp:Label ID="lblDescBreve" runat="server" Text="Descripcion Breve de la propuesta"></asp:Label>
            <br>
                <asp:TextBox ID="txtDescripcionBreve" runat="server" TextMode="MultiLine" 
                    Height="77px" Width="548px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            <br>
                <asp:Label ID="lblDescripcionCompleta" runat="server" Text="Descripcion Completa"></asp:Label>
                <br>
                <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Height="211px" 
                    Width="545px"></asp:TextBox>
            </td>
        </tr>
    </table>
    <br>
    <asp:Button ID="bntGuardar" runat="server" Text="Guardar" 
        onclick="bntGuardar_Click" />
</asp:Content>
