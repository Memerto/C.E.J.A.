<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Tema.aspx.cs" Inherits="Prototipo1DG.Tema" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <!--Algunos valores que van fijos los puse para indicar que ahí va un label
        que va a cambiar.-->
    
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
            width: 550px;
            margin-left: 1px;
            margin-right: 1px;

        }

    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	
    <div>

    <div>
		<table>
			<tr>
				<td><asp:Label ID="lblTema" runat="server" text="<h1>.NET</h1>"></asp:Label></td>
			</tr>
		</table>
	</div>
        
        <hr class="horizontalLine"/>
        
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
	
	<div class="gapVertical"></div>
        
        
        
	
	<div>
		<table>
			<tr>
				<td>Posts<asp:Label ID="lblCantRespuestas" runat="server">
				<span> +<asp:Label ID="lblPostCounter" runat="server" Text="2"></asp:Label></span></asp:Label></td>
			</tr>
		</table>
		
		<hr class="horizontalLine"/>
        
		
        <div>
            <div class="row">
                <div class="col-lg-5">
                    <div class="media">
                        <a class="pull-left" href="#">
                            <img class="media-object dp img-circle" src="http://www.huffmancode.com/img/hardik.jpg" style="width: 100px;height:100px;">

                        </a>
                        <div class="media-body">
                            <h4 class="media-heading">Petrovid Madgar <small> Russia</small></h4>
                            <h5>Software Developer</h5>
                            <hr style="margin:8px auto">

                        </div>

                    </div>

                </div>

            </div> 

        </div>
        
        
        
       
        <hr class="horizontalLine"/>
		
		
		<div class="generalWidth">
			<p>Microsoft started development of .NET Framework in the late 1990s, 
               originally under the name of Next Generation Windows Services (NGWS). 
               By late 2000, the first beta versions of .NET 1.0 were released.</p>
		</div>
        
        
        <hr class="horizontalLine"/>
        
        <div>
		    <table>
			<tr>
            <td style="width: 85px"><a href="javascript:void(0);" id="showHide">Responder...</a></td> <!--#hideDiv id="hide/show"-->
			
			<td align="left"class="widthTD"><asp:LinkButton ID="lnkApruebo" runat="server"><span class="glyphicon glyphicon-thumbs-up"></span> Apruebo<span> +<asp:Label ID="lblSumaA" runat="server" Text="10"></asp:Label></span></asp:LinkButton></td>
                
            <td style="width: 120px" align="left"><asp:LinkButton ID="lnkDesapruebo" runat="server"><span class="glyphicon glyphicon-thumbs-down"></span> Desapruebo<span> +<asp:Label ID="lblSumaD" runat="server" Text="5"></asp:Label></span></asp:LinkButton></td>
			</tr>

		    </table>

		</div>
        
        <div style="height: 10px"></div>
           
        
        
        
        
        <div class="generalWidth" id="toShowHide" style="display: none"> 
            <table>
                <tr>
                    <td><a href="#" class="glyphicon glyphicon-file"></a></td>
                    <td><textarea id="Textarea1" placeholder="Responder..." class="commentSize"></textarea></td>
                    <td style="width: 50px" align="right"><a href="#" class="btn btn-primary btn-xs">Enviar</a> </td>
                </tr>
            </table>
            
        </div>

	</div>

    </div>

</asp:Content>



