s<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Prototipo1DG.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<title>Inicio Foro</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" >
  <div class="page-header page-heading">
    <h1 class="pull-left">Foros</h1>
    <div class="clearfix"></div>
  </div>
  <p class="lead">Unete a la discucion!.</p>
  <table class="table forum table-striped">
    <thead>
      <tr>
        <th class="cell-stat"></th>
        <th>
          <h3>Importante</h3>
        </th>
        <th class="cell-stat text-center hidden-xs hidden-sm">Temas</th>
        <th class="cell-stat text-center hidden-xs hidden-sm">Posts</th>
        <th class="cell-stat-2x hidden-xs hidden-sm">Ultimo Post</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td class="text-center"><i class="fa fa-question fa-2x text-primary"></i></td>
        <td>
          <h4><a href="#">FAQ</a><br><small>Preguntas Frecuentes</small></h4>
        </td>
        <td class="text-center hidden-xs hidden-sm"><a href="#">3</a></td>
        <td class="text-center hidden-xs hidden-sm"><a href="#">10</a></td>
        <td class="hidden-xs hidden-sm">por <a href="#">Lucho Gatica</a><br><small><i class="fa fa-clock-o"></i> 3 dias atras</small></td>
      </tr>
      <tr>
        <td class="text-center"><i class="fa fa-exclamation fa-2x text-danger"></i></td>
        <td>
          <h4><a href="#">Cambios Importantes</a><br><small>Cambios en el sistema</small></h4>
        </td>
        <td class="text-center hidden-xs hidden-sm"><a href="#">572</a></td>
        <td class="text-center hidden-xs hidden-sm"><a href="#">152123</a></td>
        <td class="hidden-xs hidden-sm">por <a href="#">Juanito Perez</a><br><small><i class="fa fa-clock-o"></i> 1 dia atras</small></td>
      </tr>
    </tbody>
  </table>
  <table class="table forum table-striped">
    <thead>
      <tr>
        <th class="cell-stat"></th>
        <th>
          <h3>Informatica</h3>
        </th>
        <th class="cell-stat text-center hidden-xs hidden-sm">Temas</th>
        <th class="cell-stat text-center hidden-xs hidden-sm">Posts</th>
        <th class="cell-stat-2x hidden-xs hidden-sm">Ultimo Post</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td class="text-center"><i class="fa fa-code fa-2x text-primary"></i></td>
        <td>
          <h4><a href="#">.NET</a><br><small>Framework de microsoft</small></h4>
        </td>
        <td class="text-center hidden-xs hidden-sm"><a href="#">45</a></td>
        <td class="text-center hidden-xs hidden-sm"><a href="#">1521</a></td>
        <td class="hidden-xs hidden-sm">por <a href="#">Jaun Romero</a><br><small><i class="fa fa-clock-o"></i> 3 dias atras</small></td>
      </tr>
      <tr>
        <td class="text-center"><i class="fa fa-code fa-2x text-primary"></i></td>
        <td>
          <h4><a href="#">Java</a><br><small>Famoso lenguaje Java</small></h4>
        </td>
        <td class="text-center hidden-xs hidden-sm"><a href="#">65</a></td>
        <td class="text-center hidden-xs hidden-sm"><a href="#">2921</a></td>
        <td class="hidden-xs hidden-sm">por <a href="#">Elber Galarga</a><br><small><i class="fa fa-clock-o"></i> 1 semana atras</small></td>
      </tr>
      <tr>
        <td class="text-center"><i class="fa fa-code fa-2x text-primary"></i></td>
        <td>
          <h4><a href="#">Python</a><br><small>Lenguaje python</small></h4>
        </td>
        <td class="text-center hidden-xs hidden-sm"><a href="#">12</a></td>
        <td class="text-center hidden-xs hidden-sm"><a href="#">221</a></td>
        <td class="hidden-xs hidden-sm">por <a href="#">Elber Galarga</a><br><small><i class="fa fa-clock-o"></i> 2 semana atras</small></td>
      </tr>
      <tr>
        <td class="text-center"><i class="fa fa-cogs fa-2x text-primary"></i></td>
        <td>
          <h4><a href="#">Arduino</a><br><small>Todo con Arduino</small></h4>
        </td>
        <td class="text-center hidden-xs hidden-sm"><a href="#">33</a></td>
        <td class="text-center hidden-xs hidden-sm"><a href="#">5621</a></td>
        <td class="hidden-xs hidden-sm">por <a href="#">Elber Galarga</a><br><small><i class="fa fa-clock-o"></i> 3 semana atras</small></td>
      </tr>
    </tbody>
  </table>
  <table class="table forum table-striped">
    <thead>
      <tr>
        <th class="cell-stat"></th>
        <th>
          <h3>Gastronomia</h3>
        </th>
        <th class="cell-stat text-center hidden-xs hidden-sm">Temas</th>
        <th class="cell-stat text-center hidden-xs hidden-sm">Posts</th>
        <th class="cell-stat-2x hidden-xs hidden-sm">Ultimo Post</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td class="text-center"><i class="fa fa-coffee fa-2x text-primary"></i></td>
        <td>
          <h4><a href="#">Reposteria</a><br><small>Todo lo relacionado con postres</small></h4>
        </td>
        <td class="text-center hidden-xs hidden-sm"><a href="#">45</a></td>
        <td class="text-center hidden-xs hidden-sm"><a href="#">1521</a></td>
        <td class="hidden-xs hidden-sm">por <a href="#">Jaun Romero</a><br><small><i class="fa fa-clock-o"></i> 1 dias atras</small></td>
      </tr>
      <tr>
        <td class="text-center"><i class="fa fa-cutlery fa-2x text-primary"></i></td>
        <td>
          <h4><a href="#">Cocina</a><br><small>Todo lo que sucede en una cocina</small></h4>
        </td>
        <td class="text-center hidden-xs hidden-sm"><a href="#">65</a></td>
        <td class="text-center hidden-xs hidden-sm"><a href="#">2921</a></td>
        <td class="hidden-xs hidden-sm">por <a href="#">Elber Galarga</a><br><small><i class="fa fa-clock-o"></i> 2 semana atras</small></td>
      </tr>
    </tbody>
  </table>
</div>
</div>

</asp:Content>
