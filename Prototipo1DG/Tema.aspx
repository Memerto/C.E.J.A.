<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Tema.aspx.cs" Inherits="Prototipo1DG.Tema" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        
        #rcorners1
        {
            border-radius: 30px 30px 30px 30px;
            border:1px solid #3c8dbc;
            padding: 25px; 
            width: 400px;
            height: 10px; 
        }
        
        .labelSize
        {
            font-size:15px;
            text-align:left;
            vertical-align:middle;
            
            
        }
        
        .rightAlign
        {
            float:right;
            align:"right";
            
        }
        
        .gapHorizontal 
        {
            padding-right: 5px;
        }
        
        .gapVertical
        {
            background-color:#ecf0f5;
            padding-top: 5px;
            padding-right: 25px;
            padding-bottom: 5px;
            padding-left: 10px;
        }
        
        .gapCell
        {
            cellspacing="10";
         }
    
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--<div class="box">-->

    <div id="rcorners1" class="labelSize">
        <table>
            <tr>
                <td>Tema:<asp:Label ID="lblTema" runat="server" Text="Tema"></asp:Label></td>
                <td>Autor:<asp:Label ID="lblAutor" runat="server" Text="Autor" class="rightAlign"></asp:Label></td>
             </tr>
                 
        </table>
        </div>

        <div class="gapVertical"></div>
        
        <div id="#rcorners1">
            <table>
                <tr>
                <td>Pregunta:<asp:Label class="labelSize" ID="lblPregunta" runat="server" Text="Pregunta"></asp:Label></td>
                </tr>
            </table>
        </div>
    
    <div class="gapVertical"></div> 

    <div>
        <textarea id="txaComentario" cols="100" rows="10"></textarea>
    </div>
    
    <div class="gapVertical"></div>
    
    <div>
        <table cellspacing="10">
            <tr>
            
            <td>
            <a href="#" class="fa fa-thumbs-o-up"></a>
            <asp:Label ID="lblBien" runat="server" Text="20"></asp:Label>
            </td>
            
            <td><a href="#" class="fa fa-thumbs-o-down"></a>
            <asp:Label ID="lblMal" runat="server" Text="15"></asp:Label>
            </td>
            </tr>
            
            <!--<div class="gapVertical"></div>-->
            
            <tr>
                <td class="gapHorizontal"><a href="#" class="btn btn-default">Comentar</a></td>
                <td><a href="#" class="btn btn-default">Adjuntar</a></td>
                
                
            </tr>

            <tr>
                
            </tr>
        </table>
    </div>


<!--</div>-->

</asp:Content>
