using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Libreria
{
    [Serializable]
    class Usuario : Visitante
    {
        private String _id;
        private Boolean _admin;
        private Boolean _activo;
        private String _contrasena;
        private String _apodo;
        private String _correo;
        private String _ocupacion;
        private ArrayList _intereses;
        private DateTime _fechaCreacion;
        private DateTime _fechaModificacion;

        #region Getters y setters

        public void setID(String id) { _id = id; }       
        public void setAdmin(Boolean admin) { _admin = admin; }
        public void setActivo(Boolean activo) { _activo = activo; }
        public void setContrasena(String contrasena) { _contrasena = contrasena; }
        public void setApodo(String apodo) { _apodo = apodo; }
        public void setOcupacion(String ocupacion) { _ocupacion = ocupacion; }
        public void setCorreo(String correo) { _correo = correo; }
        public void setIntereses(ArrayList intereses) { _intereses = new ArrayList();_intereses = intereses; }
        public void setFechaCreacion(DateTime fechaCreacion) { _fechaCreacion = fechaCreacion; }
        public void setFechaModificacion(DateTime fechaModificacion) { _fechaModificacion = fechaModificacion; }
        public String getID() { return _id; }
        public Boolean getAdmin() { return _admin; }
        public Boolean getActivo() { return _activo; }
        public String getContrasena() { return _contrasena; }
        public String getApodo() { return _apodo; }
        public String getCorreo() { return _correo; }
        public String getOcupacion() { return _ocupacion; }
        public ArrayList getIntereses() { return _intereses; }
        public DateTime getFechaCreacion() { return _fechaCreacion; }
        public DateTime getFechaModificacion() { return _fechaModificacion; }

        #endregion

        public Usuario() {

            setID("0000");
            setAdmin(false);
            setActivo(false);
            setContrasena("");
            setApodo("");
            setCorreo("");
            setOcupacion("");
            setIntereses(new ArrayList());
            setFechaCreacion(DateTime.Now);
            setFechaModificacion(DateTime.Now);
        }

        public Usuario(String id, Boolean admin, Boolean activo, String contrasena, String apodo, String correo)
        {

            if (id == "0000")
            {
                throw new ArgumentNullException("Constructor Usuario - ID invalida.");
            }
            else
            {
                if (admin != true && admin != false)
                {
                    throw new ArgumentNullException("Constructor Usuario - Valor Administrador invalido.");
                }
                else
                {
                    if (activo != true && activo != false)
                    {
                        throw new ArgumentNullException("Constructor Usuario - Valor Activo invalido.");
                    }
                    else
                    {
                        if (contrasena == null || contrasena == "")
                        {
                            throw new ArgumentNullException("Constructor Usuario - Contraseña invalida.");
                        }
                        else
                        {
                            if (apodo == null || apodo == "")
                            {
                                throw new ArgumentNullException("Constructor Usuario - Apodo invalido.");
                            }
                            else
                            {
                                if (correo == null || correo == "")
                                {
                                    throw new ArgumentNullException("Constructor Usuario - Correo invalido.");
                                }
                                else
                                {
                                        setID(id);
                                        setAdmin(admin);
                                        setActivo(activo);
                                        setContrasena(contrasena);
                                        setApodo(apodo);
                                        setCorreo(correo);
                                        setOcupacion("");
                                        setIntereses(new ArrayList());
                                        setFechaCreacion(DateTime.Now);
                                        setFechaModificacion(DateTime.Now);
                                }
                            }
                        }
                    }
                }
            }

        }

        public Usuario(String id, Boolean admin, Boolean activo, String contrasena, String apodo, String correo, String ocupacion)
        {

            if (id == "0000")
            {
                throw new ArgumentNullException("Constructor Usuario - ID invalida.");
            }
            else
            {
                if (admin != true && admin != false)
                {
                    throw new ArgumentNullException("Constructor Usuario - Valor Administrador invalido.");
                }
                else
                {
                    if (activo != true && activo != false)
                    {
                        throw new ArgumentNullException("Constructor Usuario - Valor Activo invalido.");
                    }
                    else
                    {
                        if (contrasena == null || contrasena == "")
                        {
                            throw new ArgumentNullException("Constructor Usuario - Contraseña invalida.");
                        }
                        else
                        {
                            if (apodo == null || apodo == "")
                            {
                                throw new ArgumentNullException("Constructor Usuario - Apodo invalido.");
                            }
                            else
                            {
                                if (correo == null || correo == "")
                                {
                                    throw new ArgumentNullException("Constructor Usuario - Correo invalido.");
                                }
                                else
                                {
                                    if (ocupacion == null || ocupacion == "")
                                    {
                                        throw new ArgumentNullException("Constructor Usuario - Ocupacion invalido.");
                                    }
                                    else
                                    {
                                            setID(id);
                                            setAdmin(admin);
                                            setActivo(activo);
                                            setContrasena(contrasena);
                                            setApodo(apodo);
                                            setCorreo(correo);
                                            setOcupacion(ocupacion);
                                            setIntereses(new ArrayList());
                                            setFechaCreacion(DateTime.Now);
                                            setFechaModificacion(DateTime.Now);
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        public Usuario(String id,Boolean admin, Boolean activo,String contrasena, String apodo, String correo,String ocupacion, ArrayList intereses) {

            if (id == "0000")
            {
                throw new ArgumentNullException("Constructor Usuario - ID invalida.");
            }
            else
            {
                if (admin != true && admin != false)
                {
                    throw new ArgumentNullException("Constructor Usuario - Valor Administrador invalido.");
                }
                else
                {
                    if (activo != true && activo != false)
                    {
                        throw new ArgumentNullException("Constructor Usuario - Valor Activo invalido.");
                    }
                    else
                    {
                        if (contrasena == null || contrasena == "")
                        {
                            throw new ArgumentNullException("Constructor Usuario - Contraseña invalida.");
                        }
                        else
                        {
                            if (apodo == null || apodo == "")
                            {
                                throw new ArgumentNullException("Constructor Usuario - Apodo invalido.");
                            }
                            else
                            {
                                if (correo == null || correo == "")
                                {
                                    throw new ArgumentNullException("Constructor Usuario - Correo invalido.");
                                }
                                else
                                {
                                    if (ocupacion == null || ocupacion == "")
                                    {
                                        throw new ArgumentNullException("Constructor Usuario - Ocupacion invalido.");
                                    }
                                    else
                                    {
                                        if (intereses.Count == 0 || intereses == null)
                                        {
                                            throw new ArgumentNullException("Constructor Usuario - Intereses invalido.");
                                        }
                                        else
                                        {
                                            setID(id);
                                            setAdmin(admin);
                                            setActivo(activo);
                                            setContrasena(contrasena);
                                            setApodo(apodo);
                                            setCorreo(correo);
                                            setOcupacion(ocupacion);
                                            setIntereses(intereses);
                                            setFechaCreacion(DateTime.Now);
                                            setFechaModificacion(DateTime.Now);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
        }

        public Usuario(String id, Boolean admin, Boolean activo, String contrasena, String apodo, String correo, String ocupacion, ArrayList intereses,DateTime fechaCreacion,DateTime fechaModificacion)
        {

            if (id == "0000")
            {
                throw new ArgumentNullException("Constructor Usuario - ID invalida.");
            }
            else
            {
                if (admin != true && admin != false)
                {
                    throw new ArgumentNullException("Constructor Usuario - Valor Administrador invalido.");
                }
                else
                {
                    if (activo != true && activo != false)
                    {
                        throw new ArgumentNullException("Constructor Usuario - Valor Activo invalido.");
                    }
                    else
                    {
                        if (contrasena == null || contrasena == "")
                        {
                            throw new ArgumentNullException("Constructor Usuario - Contraseña invalida.");
                        }
                        else
                        {
                            if (apodo == null || apodo == "")
                            {
                                throw new ArgumentNullException("Constructor Usuario - Apodo invalido.");
                            }
                            else
                            {
                                if (correo == null || correo == "")
                                {
                                    throw new ArgumentNullException("Constructor Usuario - Correo invalido.");
                                }
                                else
                                {
                                    if (ocupacion == null || ocupacion == "")
                                    {
                                        throw new ArgumentNullException("Constructor Usuario - Ocupacion invalido.");
                                    }
                                    else
                                    {
                                        if (intereses.Count == 0 || intereses == null)
                                        {
                                            throw new ArgumentNullException("Constructor Usuario - Intereses invalido.");
                                        }
                                        else
                                        {
                                            setID(id);
                                            setAdmin(admin);
                                            setActivo(activo);
                                            setContrasena(contrasena);
                                            setApodo(apodo);
                                            setCorreo(correo);
                                            setOcupacion(ocupacion);
                                            setIntereses(intereses);
                                            setFechaCreacion(DateTime.Now);
                                            setFechaModificacion(DateTime.Now);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        public Propuesta crearPropuesta(String id,Tema tema, String idPropuestaRelacionada, TipoPropuesta tipoPropuesta, Boolean preAprobada, Boolean aprobada, String texto)
        {
            Propuesta propuesta;
            String idProp = tema.generarIDPropuestaPosicion(); //Obtiene el sufijo de la posicion de la propuesta

            if (idPropuestaRelacionada == "0000")
            {
                propuesta = new Propuesta(id+idProp,tipoPropuesta,preAprobada,aprobada,texto);
            }
            else
            {
                propuesta = new Propuesta(id+idProp, idPropuestaRelacionada, tipoPropuesta, preAprobada, aprobada, texto);
            }
            return propuesta;
        }

        public void crearPost() { }

        public Calificacion crearCalificacion(int id,Boolean aprueba,String comentario) {

            Usuario yo = new Usuario(getID(),getAdmin(),getActivo(),getContrasena(),getApodo(),getCorreo(),getOcupacion(),getIntereses(),getFechaCreacion(),getFechaModificacion());
            Calificacion cali = new Calificacion(id, aprueba, comentario);
            cali.agregarUsuario(yo);
            return cali;
        }

        public void reportarUsuario(int id,int idPost,int idUsuarioReportado,TipoReporte tipoReporte,Usuario usuario) {

            Usuario yo = new Usuario(getID(), getAdmin(), getActivo(), getContrasena(), getApodo(), getCorreo(), getOcupacion(), getIntereses(), getFechaCreacion(), getFechaModificacion());
            Reporte reporte = new Reporte(id, idPost, idUsuarioReportado, tipoReporte, yo);
        
        }

        public Boolean agregarIntereses(String interes) {

            ArrayList inte = getIntereses();
            if (inte.Contains(interes))
            {
                throw new ArgumentException("Usuario (Agregar Interes) - Ya se encuentra el interes.");
            }
            else
            {
                inte.Add(interes);
                setIntereses(inte);
                return true;
            }
        }

        public Boolean eliminarInteres(String interes) {

            ArrayList inte = getIntereses();
            if (inte.Contains(interes))
            {
                inte.Remove(interes);
                setIntereses(inte);
                return true;
            }
            else 
            {
                throw new ArgumentException("Usuario (Agregar Interes) - No se encontró el interes a eliminar.");
            }
        }

        public void modificarPost(int idP) { }
    }
}
