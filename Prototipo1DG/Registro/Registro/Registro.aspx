<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Registro.Registro1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title>Registro</title>
</head>
<body>
    <form id="form1" runat="server" style="background: #8A2BE2">
    
        <div style="background: #D3D3D3">
    
            <h1>Registro</h1>
    
        </div>
        
        <div style="background: #00ff7f">
            <table style="background: #a52a2a">
                <tr>
                    <td>
                        <asp:TextBox ID="txtNombre" runat="server" Width="200px" Placeholder="Nombre"></asp:TextBox>
                        &nbsp;
                        <asp:TextBox ID="txtApellido" runat="server" Width="200px" 
                            Placeholder="Apellido" ontextchanged="txtApellido_TextChanged"></asp:TextBox> 
                            
                        <br />
                            
                        <br />
                            
                    </td>
                    
                </tr>
                
                
                
                <tr>
                   <td><asp:TextBox ID="txtCorreo" runat="server" Width="415px" Placeholder="Correo electrónico"></asp:TextBox>
                       <br />
                       <br />
                    </td>
                </tr>
                
                <tr>
                    <td><asp:TextBox ID="txtArea" runat="server" Width="416px" Placeholder="Area"></asp:TextBox>
                        <br />
                        <br />
                    </td>
                </tr>
                
                <tr>
                    <td>
                        <select id="cmbDia" style="width: 132px">
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
                        <option valu e="10">10</option>
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
                        
                        <select id="cmbMes" style="width: 132px" name="D1">
                        <option value="">Mes</option>
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
                        
                        <select id="cmbAño" name="D2" class="auto-style2">
                        <option value="">Año</option>
                        <option value="1960">1960</option>
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
                        <br />
                        <br />
                    </td>
                </tr>
                
                <tr>
                    <td>
                        <select id="cmbPregunta" class="auto-style1">
                        <option value="1">Seleccionar una pregunta</option>
                        <option value="2">Cómo se llama mi profesor?</option>
                        <option value="3">Cuál es mi color favorito?</option>
                        <option value="4">Grupo musical favorito?</option>
                        </select>
                        <br />
                    </td>
                </tr>
                    
                <tr style="background: #F0FFFF">
                    <td><asp:TextBox ID="txtRespuesta" runat="server" placeholder="Respuesta" Width="200px"></asp:TextBox>
                        <br />
                    </td>
                </tr>
                

                
            </table>
        </div>

    <div>
        <table>
            <tr>
                <td><asp:Button ID="btnCrear" runat="server" Text="Crear" /></td>
            </tr>
        </table>
    </div>

    </form>
</body>
</html>
