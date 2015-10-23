using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Entidades
{
    [Serializable]
    public class EUsuario
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
        public void setIntereses(ArrayList intereses) { _intereses = new ArrayList(); _intereses = intereses; }
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
    }
}
