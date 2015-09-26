<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdministrador.Master" AutoEventWireup="true" CodeBehind="HijoAD1.aspx.cs" Inherits="Prototipo1DG.HijoAD1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="ContenidoIntereses" ContentPlaceHolderID="InteresesUsuario" runat="server">
    <ul class="treeview-menu">
                <li><a href="../charts/chartjs.html"><i class="fa fa-circle-o"></i> Java</a></li>
                <li><a href="../charts/morris.html"><i class="fa fa-circle-o"></i> Cocina</a></li>
                <li><a href="../charts/flot.html"><i class="fa fa-circle-o"></i> Reposteria</a></li>
                <li><a href="../charts/inline.html"><i class="fa fa-circle-o"></i> Economia</a></li>
              </ul>
    </asp:Content>
<asp:Content ID="ContenidoPendientes" ContentPlaceHolderID="Pendientes" runat="server">
<li>
              <a href="#">
                <i class="fa fa-question"></i> <span>Pendientes</span> <i class="fa fa-angle-left pull-right"></i>
              </a>
</li>
</asp:Content>
<asp:Content ID="ContenidoAdministrador" ContentPlaceHolderID="Administrador" runat="server">
<li class="treeview">
            <a href="#">
            <i class="fa fa-edit"></i><span>Administrador</span>
            <i class="fa fa-angle-left pull-right"></i>
            </a>
            <ul class="treeview-menu">
            <li><a ><i class="fa fa-circle-o"></i> Control de Usuario</a></li>
            <li><a ><i class="fa fa-circle-o"></i> Evaluar Propuestas</a></li>
            <li><a ><i class="fa fa-circle-o"></i> Nose</a></li>
            </ul>
            </li>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p>         Pagina del administrador
    </p>

    </asp:Content>
