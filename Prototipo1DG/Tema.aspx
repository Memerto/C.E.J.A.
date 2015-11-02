<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Tema.aspx.cs" Inherits="Prototipo1DG.Tema" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <!--
    
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.4.4/jquery.min.js"></script>
    <script type="text/javascript">

        $(document).ready(function () {

            $("#toShowHide").hide();
            $("#showHide").show();

            $('#showHide').click(function () {
                $("#toShowHide").slideToggle();
            });

        });

        </script>
        -->
    
     
    
    <style type="text/css">
        
        .gapVertical
         {
            
             width: 550px;
             height: 20px;
            
         }

        .generalWidth {
            width: 550px;
        }

        .especificWidth {
            width: 150px;
        }
        
        .widthTD{
            width: 100px;

        }
        
        .commentSize {
            width: 300px;
            height: 30px;
        }

        .horizontalLine {
            border: none;
            height: 1px;
            background: #a8a8a8;
            
            margin-left: 10px;
            margin-right: 10px;

        }

        .generalColor {
            background: #3c8dbc;
            width: 550px;
            border: 2px;
            border-radius: 5px;
            color: #ffffff;
            
        }

        .generalBox {
            border: 1px solid;
            border-radius: 5px;
        }

        .marginLeft {
            margin-left: 10px;
            
        }

        .marginRight {
            margin-right: 10px;
        }

        .marginTop {
            margin-top: 10px;
        }

        .marginBottom {
            margin-bottom: 10px;
        }
        
        .marginLeftRight{
            margin-right: 10px;
            margin-left: 10px;
        }
        
        .totalWidth
        {
            width:1107px;
        

    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
    

        
         

        <section class="content-header" >
          
          <ol class="breadcrumb" >

          
          <li>
            <a href="#"><button type="button" class="btn btn-primary btn-lg" data-toggle="modal" data-target="#modalPropuesta" aria-hidden="false">
            <span class="glyphicon glyphicon-comment"> Proponer</span></button></a>
            </li>
            
            
            <!--Dropdownlist de Postear-->
            <li><a href="#"><button type="button" class="btn btn-primary btn-lg" data-toggle="modal" data-target="#modalPostear" aria-hidden="false">
                <span class="glyphicon glyphicon-envelope"> Postear</span></button></a>
            </li>
            
            
            <!--Dropdownlist de Propuesta
            <li>
            <div class="dropdown"> 
            <button class="btn btn-primary dropdown-toggle" style="height:46px" type="button" data-toggle="dropdown" style="font-weight: bold"><span class="glyphicon glyphicon-comment"></span> Propuestas
            <span class="caret" ></span></button>
            <ul class="dropdown-menu">
            <li><a href="#"  data-toggle="modal" data-target="#modalPropuesta" aria-hidden="false">Proponer</a></li>
            <li><a href="#" data-toggle="modal" data-target="#modalVerPropuestas" aria-hidden="false">Ver Propuestas</a></li>
            </ul>
            </div>
            </li>
            -->
            </ol>
        </section>
        
    

        
      
                
        

            
    
        <div class="gapVertical"></div>
        

    
   
        
    
    
    
    <div>
        <table >
            <tr class="breadcrumb">
                <td class="generalColor" ><asp:Label ID="lblTema" runat="server" text="<h1>.NET</h1>"></asp:Label></td>
            </tr>
        </table>

    </div>
        
        
    <div class="totalWidth"> <!--1107px style="width: 1107px"-->     
    
    <div>
             
             <div class="gapVertical"></div>
        <!--
             <table>
            <tr>
                <td>Posts<asp:Label ID="lblCantRespuestas" runat="server">
                <span> +<asp:Label ID="lblContadorPost" runat="server" Text="2"></asp:Label></span></asp:Label></td>
            </tr>
        </table>
        -->
        
        <div class="generalBox">
            
            <div class="marginLeft" style="margin-top: 10px;">
            <div class="row">
                <div class="col-lg-5">
                    <div class="media">
                        <a class="pull-left" href="#">
                            <img class="media-object dp img-circle" src="http://www.huffmancode.com/img/hardik.jpg" style="width: 100px;height:100px;">

                        </a>
                        <div class="media-body">
                            <h4 class="media-heading"><asp:Label ID="lblNombreUsuario" runat="server" Text="Petrovich Madnar"></asp:Label></h4>
                            <h5><asp:Label  ID="lblActividadUsuario" runat="server" Text="Programador ASP.NET"></asp:Label></h5>
                            <h5>Posts: <asp:Label  ID="lblCantPostUsuario" runat="server" Text="1200"></asp:Label></h5>
                            <h5>Registrado: <asp:Label  ID="lblRegistradoDesde" runat="server" Text="25/12/2000"></asp:Label></h5>
                            

                        </div>

                    </div>

                </div>

            </div> 

        </div>
        
        
        
       
            <hr class="horizontalLine"/>
        
        
        <div>
            <p id="txtComentario" class="marginLeftRight" style="width: 1107px">
               Microsoft started development of .NET Framework in the late 1990s, 
               originally under the name of Next Generation Windows Services (NGWS). 
               By late 2000, the first beta versions of .NET 1.0 were released.
            </p>
        </div>
        
        <hr class="horizontalLine"/>

        <div class="marginLeft">
            <a href="#" data-toggle="modal" data-target="#modalVerPropuestas" aria-hidden="false">Ver Propuesta</a>
        
        </div>
        
        
       
        <!--
            <div>
            <table class="marginLeft">
            <tr>
            <td style="width: 85px"><a href="javascript:void(0);" id="showHide">Responder...</a></td> 
            
            <td align="left"class="widthTD"><asp:LinkButton ID="lnkApruebo" runat="server"><span class="glyphicon glyphicon-thumbs-up"></span> Apruebo<span> +<asp:Label ID="lblSumaA" runat="server" Text="10"></asp:Label></span></asp:LinkButton></td>
                
           <td style="width: 120px" align="left"><asp:LinkButton ID="lnkDesapruebo" runat="server"><span class="glyphicon glyphicon-thumbs-down"></span> Desapruebo<span> +<asp:Label ID="lblSumaD" runat="server" Text="5"></asp:Label></span></asp:LinkButton></td>
            </tr>

            </table>

        </div>
        -->
        
        <div style="height: 10px"></div>
           
        
        
        
        
        <!--
        <div class="generalWidth" id="toShowHide" style="display: none"> 
            <table class="marginLeft">
                <tr>
                    <td ><a href="#" class="glyphicon glyphicon-file"></a></td>
                    <td class="marginLeft"><textarea  id="txtRespuesta" placeholder="Responder..." class="commentSize"></textarea></td>
                    <td style="width: 50px" align="right" ><a href="#" class="btn btn-primary btn-xs">Enviar</a> </td>
                </tr>
            </table>
            
        </div>

    </div>
    -->
        
       
        
    <!--
    <div>
        <textarea id="txaRespuesta"  class="generalWidth" rows="10" placeholder="Escribe tu post..."></textarea>
    </div>
    
    <div class="gapVertical"></div>
    
    <div>
        <table class="especificWidth">
            <tr>
            <td><a href="#" class="btn btn-primary">Postear</a></td>
            
            <td>
                <asp:LinkButton ID="lnkAdjuntar" runat="server">Adjuntar</asp:LinkButton></td>
            </tr>
            
        </table>
    </div>
        -->
            
        </div>
        
        
        

    </div>
       

</asp:Content>



