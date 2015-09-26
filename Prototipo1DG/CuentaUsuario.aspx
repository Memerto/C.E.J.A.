<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="CuentaUsuario.aspx.cs" Inherits="Prototipo1DG.CuentaUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        
    <div class="col-xs-12 col-sm-12 col-md-offset-1 col-md-10 col-lg-offset-2 col-lg-8">

              <!-- Profile Image -->
              <div class="box box-primary">
                <div class="box-body box-profile">
                  <img class="profile-user-img img-responsive img-circle" src="../../dist/img/user4-128x128.jpg" alt="User profile picture">
                  <h3 class="profile-username text-center">Juanita</h3>
                  <p class="text-muted text-center">Estudiante</p>

                  <ul class="list-group list-group-unbordered">
                    <li class="list-group-item">
                      <b>Post</b> <a class="pull-right">540</a>
                    </li>
                    <li class="list-group-item">
                      <b>Propuestas Calificadas</b> <a class="pull-right">26</a>
                    </li>
                    <li class="list-group-item">
                      <b>Propuestas Hechas</b> <a class="pull-right">5</a>
                    </li>
                  </ul>
                </div><!-- /.box-body -->
              </div><!-- /.box -->

              <!-- About Me Box -->
              <div class="box box-primary">
                <div class="box-header with-border">
                  <h3 class="box-title">Sobre Mi</h3>
                </div><!-- /.box-header -->
                <div class="box-body">
                  <strong><i class="fa fa-book margin-r-5"></i>  Education</strong>
                  <p class="text-muted">
                    B.S. in Computer Science from the University of Tennessee at Knoxville
                  </p>

                  <hr>

                  <strong><i class="fa fa-map-marker margin-r-5"></i>Ubicacion</strong>
                  <p class="text-muted">Santiago,Chile</p>

                  <hr>

                  <strong><i class="fa fa-pencil margin-r-5"></i>Intereses</strong>
                  <p>
                    
                    <span class="label label-info">ASP.NET</span>
                    <span class="label label-info">C#</span>
                    <span class="label label-info">Javascript</span>
                    <span class="label label-info">PHP</span>
                    <span class="label label-info">Unity</span>
                    <span class="label label-warning">Reposteria</span>
                    <span class="label label-warning">Comida Chilena</span>
                    <span class="label label-danger">Electronica</span>
                  </p>

                  <hr>

                  <strong><i class="fa fa-file-text-o margin-r-5"></i> Comentarios</strong>
                  <p>Lo que mas me gusta es la escritura</p>
                </div><!-- /.box-body -->
              </div><!-- /.box -->
            </div><!-- /.col -->
    
    
    
    </div>



</asp:Content>
