<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Registro.Registro" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href=EstiloRegistro.css>
</head>
<body>
     <form id="form1" runat="server">
    <div >
    <h1><font color=#fab732>Crear cuenta</font></h1>
    <br>
    <table>
    <tr>
        <td><font color=#fab732>Nombre</font></td>
        <td><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></td>
    </tr>
        
    <tr>
        <td><font color=#fab732>Apellido</font></td>
        <td><asp:TextBox ID="txtApellido" runat="server"></asp:TextBox></td>
    </tr>
        
    <tr>
        <td><font color=#fab732>Correo</font></td>
        <td><asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox></td>
    </tr>
        
    <tr>
        <td><font color=#fab732>Area</font></td>
        <td><asp:TextBox ID="txtArea" runat="server"></asp:TextBox></td>
    </tr>
        
    <!---
    <tr>
        <td>Sede</td>
        <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
    </tr>
    --->
        
    <tr>
        <td><font color=#fab732>Fecha de nacimiento</font></td>
        <td>
        <select id="cmbDia" placeholder="Día" style="width: 61px">
            <option value="">Día</option>
            <option value="1">1</option>
            <option value="2">2</option>
            <option value="3">3</option>
            <option value="4">4</option>
            <option value="5">5</option>
            <option value="6">6</option>
            <option value="7">7</option>
            <option value="8">8</option>
            <option value="9">9</option>
            <option value="10">10</option>
            <option value="11">11</option>
            <option value="12">12</option>
            <option value="13">13</option>
            <option value="14">14</option>
            <option value="15">15</option>
            <option value="16">16</option>
            <option value="17">17</option>
            <option value="18">18</option>
            <option value="19">19</option>
            <option value="20">20</option>
            <option value="21">21</option>
            <option value="22">22</option>
            <option value="23">23</option>
            <option value="24">24</option>
            <option value="25">25</option>
            <option value="26">26</option>
            <option value="27">27</option>
            <option value="28">28</option>
            <option value="29">29</option>
            <option value="30">30</option>
            <option value="31">31</option>


        </select>
        </td>
      
        <td>
        <select  id="cmbMes" style="width: 90px">
            <option value="Enero">Enero</option>
            <option value="Febrero">Febrero</option>
            <option value="Marzo">Marzo</option>
            <option value="Abril">Abril</option>
            <option value="Mayo">Mayo</option>
            <option value="Junio">Junioo</option>
            <option value="Julio">Julio</option>
            <option value="Agosto">Agosto</option>
            <option value="Septiembre">Septiembre</option>
            <option value="Octubre">Octubre</option>
            <option value="Noviembre">Noviembre</option>
            <option value="Diciembre">Diciembre</option>
        </select>    
        </td>
        
        <td>
        <select id="cmbAño" style="width: 55px">
            <option value="1960">1960</option>
            <option value="1961">1961</option>
            <option value="1962">1962</option>
            <option value="1963">1963</option>
            <option value="1964">1964</option>
            <option value="1965">1965</option>
            <option value="1966">1966</option>
            <option value="1967">1967</option>
            <option value="1968">1968</option>
            <option value="1969">1969</option>
            <option value="1970">1970</option>
            <option value="1971">1971</option>
            <option value="1972">1972</option>
            <option value="1973">1973</option>
            <option value="1974">1974</option>
            <option value="1975">1975</option>
            <option value="1976">1976</option>
            <option value="1977">1977</option>
            <option value="1978">1978</option>
            <option value="1979">1979</option>
            <option value="1980">1980</option>
            <option value="1981">1981</option>
            <option value="1982">1982</option>
            <option value="1983">1983</option>
            <option value="1984">1984</option>
            <option value="1985">1985</option>
            <option value="1986">1986</option>
            <option value="1987">1987</option>
            <option value="1988">1988</option>
            <option value="1989">1989</option>
            <option value="1990">1990</option>
            <option value="1991">1991</option>
            <option value="1992">1992</option>
            <option value="1993">1993</option>
            <option value="1994">1994</option>
            <option value="1995">1995</option>
        </select>    
        </td>
    </tr>
        
        <tr>
                    <td><font color=#fab732>Pregunta y respuesta secreta</font></td>

                    <td>
                        <select id="cmbPregunta" style="width: 200px">
                        <option value="1">Cómo se llama mi profesor?</option>
                        <option value="2">Cuál es mi color favorito?</option>
                        <option value="3">Grupo musical favorito?</option>
                        
                        </select>
                    </td>
            <td>
                <asp:TextBox ID="txtRespuesta" runat="server" placeholder="Respuesta"></asp:TextBox>    
            </td>
                </tr>
        
        <tr><td><font color=#fab732>Temas de interés</font></td></tr>
        <tr>
            <td>
            <asp:CheckBox Text="Java" ID="chk1" runat="server"/>

            </td>
            
            <td>
            <asp:CheckBox Text=".NET" ID="chk2" runat="server" />

            </td>
            
            <td>
            <asp:CheckBox Text="Web" ID="chk3" runat="server" />

            </td>
        </tr>
        
        <tr>
        <td>
            <asp:CheckBox Text="Charlas" ID="chk4" runat="server" />

            </td>       
            
            <td>
            <asp:CheckBox Text="Robótica" ID="chk5" runat="server" />

            </td>
            
            <td>
            <asp:CheckBox Text="Desarrolo Móvil" ID="chk6" runat="server" />

            </td>
            </tr>
        
        <tr>
            <td><asp:Button ID="btnCrear" runat="server" Text="Crear" /></td>
            </tr>
    </table>
        
 

    </div>
    </form>
</body>
</html>
