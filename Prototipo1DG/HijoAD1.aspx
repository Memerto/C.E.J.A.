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
            <li><a class="btn-app" ><i class="fa fa-circle-o"></i> Control de Usuario</a></li>
            <li><a class="btn-info"><i class="fa fa-circle-o"></i> Evaluar Propuestas</a></li>
            <li><a class="btn-toolbar btn-primary"><i class="fa fa-circle-o"></i> Nose</a></li>
            </ul>
            </li>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p>         Pagina del administrador
    </p>

    </asp:Content>
    <asp:Content ID="Login" ContentPlaceHolderID="ModalLogin" runat="server">
    
    <link href="Login.css" rel="stylesheet" type="text/css" />
<link href="Modal-List.css" rel="stylesheet" type="text/css" />
<script src="Modal-Lista.js" type="text/javascript"></script>
    
    <div class="modal fade" id="loginModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
     <div class="modal-dialog" role="document">
        <div class="modal-content">

        <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="false">&times;</span></button>
        <div class="text-center">
        <!--botones de registro y logeo-->
        <a href="#new" role="tab" data-toggle="tab" class="big btn btn-primary"><i class="fa fa-plus"></i> Nuevo Usuario</a>

        <a href="#user" role="tab" data-toggle="tab" class="big btn btn-danger"><i class="fa fa-user"></i> Ya tengo una cuenta</a>
        <!--botones de registro y logeo-->
      </div>
      </div>

        <div class="container sign-in-up">
         <div class="row">
             <div class="col-md-4 col-md-offset-1">
      
      <!-- Nav tabs -->

      <!--
      <div class="text-center">
      
        <div class="btn-group">
          <a href="#new" role="tab" data-toggle="tab" class="big btn btn-primary"><i class="fa fa-plus"></i> Nuevo Usuario</a>
          <a href="#user" role="tab" data-toggle="tab" class="big btn btn-danger"><i class="fa fa-user"></i> Ya tengo una cuenta</a>
          
        </div>
        
      </div>
      -->
      <div class="tab-content">
        <div class="tab-pane fade in active" id="new">
          <br>
          <fieldset>
            <div class="form-group">
              <div class="right-inner-addon">
                <i class="fa fa-envelope"></i>
                <asp:TextBox class="form-control input-lg" runat="server" ID="txtCorreo" placeholder="Correo Electronico"/>
                <asp:RequiredFieldValidator runat="server" id="pideCorreo" ControlToValidate="txtCorreo" ForeColor="Red"
                ValidationGroup="crearUsuarioValidar" ErrorMessage="Ingrese su correo!" />
                <asp:RegularExpressionValidator runat="server" ID="revisaCorreo" ErrorMessage="No es un email Valido" 
                ControlToValidate="txtCorreo" ValidationGroup="crearUsuarioValidar" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                </asp:RegularExpressionValidator>
              </div>
            </div>
            <div class="form-group">
              <div class="right-inner-addon">
                <i class="fa fa-key"></i>
                <asp:TextBox class="form-control input-lg" runat="server" ID="contraseña" type="password" placeholder="Contraseña" />
                <asp:RequiredFieldValidator runat="server" ID="pidecontraseña" ControlToValidate="contraseña" ErrorMessage="Ingrese una contraseña" />
              </div>
            </div>
            <div class="form-group">
              <div class="right-inner-addon">
                <i class="fa fa-key"></i>
                <asp:TextBox class="form-control input-lg" runat="server" ID="confirmarContraseña" type="password" placeholder="Repita Contraseña" />
                <asp:CompareValidator runat="server" ID="comparaContraseñas" ControlToValidate="contraseña" ControlToCompare="confirmarContraseña" Operator="Equal" type="String" ErrorMessage="Las contraseñas no coinciden" />
              </div>
            </div>
            <div class="form-group">
                <div class="right-inner-addon">
                    <i class="fa fa-pencil"></i>
                    <asp:TextBox class="form-control input-lg" runat="server" ID="apodo" placeholder="Apodo" />
                    <asp:RequiredFieldValidator runat="server" ID="pideApodo" ControlToValidate="apodo" ErrorMessage="Ingrese un apodo" />
                </div>
            </div>
            <!--
            <div class="form-group">
            -->
                <div class="right-inner-addon">
                      
            <h2 class="text-center">Elija una o mas intereses</h2>
            <br />
            <div class="well" style="max-height: 300px;overflow: auto; width: ;">
            	<ul id="check-list-box" class="list-group checked-list-box">
                  <li class="list-group-item" data-color="info">Arduino</li>
                  <li class="list-group-item" data-color="info">ASP.NET</li>
                  <li class="list-group-item" data-color="info">C#</li>
                  <li class="list-group-item" data-color="info">Javascript</li>
                  <li class="list-group-item" data-color="info">Software</li>
                  <li class="list-group-item" data-color="info">Desarrollo Web</li>
                  <li class="list-group-item" data-color="info">Software</li>
                  <li class="list-group-item" data-color="warning">Reposteria</li>
                  <li class="list-group-item" data-color="warning">Comida Chilena</li>
                  <li class="list-group-item" data-color="danger">Electronica</li>
                </ul>
            </div>
        <!--
         
          </div>
            </div>
            -->
          </fieldset>
         <div class=" text-center">
             <asp:Button class="btn btn-primary" Text="Crear Cuenta" runat="server" 
                 ID="CrearCuenta" onclick="CrearCuenta_Click" />
            <!-- <button class="btn btn-primary" id="crear-cuenta">Crear Cuenta</button> -->
          </div>
          <hr>
        </div>
        <div class="tab-pane fade" id="user">
          <br>
          <fieldset>
            <div class="form-group">
              <div class="right-inner-addon">
                <i class="fa fa-envelope"></i>
                <asp:TextBox class="form-control input-lg" runat="server" ID="correoLogin" text="Correo Electronico"/>
                <asp:RequiredFieldValidator runat="server" id="pideCorreoLogin" ControlToValidate="correoLogin" ErrorMessage="Ingrese su correo!" />
              </div>
            </div>
            <div class="form-group">
              <div class="right-inner-addon">
                <i class="fa fa-key"></i>
                <input class="form-control input-lg" placeholder="Contraseña" type="password">
              </div>
            </div>
          </fieldset>
          <div class=" text-center">
            <button class="btn btn-primary">LOGIN</button>
          </div>
          <hr>
        </div>
      </div>
    </div>
  </div>
</div>
    </div>
  </div>
</div>
    

    </asp:Content>
