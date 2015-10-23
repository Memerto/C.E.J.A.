using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    [Serializable]
    public class ECalificacion
    {
        private int _id;
        private EUsuario _usuario;
        private EPropuesta _propuesta; //mmmm
        private Boolean _aprueba;
        private String _comentario;
        private DateTime _fechaCreacion;

        #region Getters y Setters

        public void setID(int id) { _id = id; }
        public void setUsuario(EUsuario usuario) { _usuario = usuario; }
        public void setPropuesta(EPropuesta propuesta) { _propuesta = propuesta; }
        public void setAprueba(Boolean aprueba) { _aprueba = aprueba; }
        public void setComentario(String comentario) { _comentario = comentario; }
        public void setFechaCreacion(DateTime fechaCreacion) { _fechaCreacion = fechaCreacion; }

        public int getID() { return _id; }
        public EUsuario getUsuario() { return _usuario; }
        public EPropuesta getPropuesta() { return _propuesta; }
        public Boolean getAprueba() { return _aprueba; }
        public String getComentario() { return _comentario; }
        public DateTime getFechaCreacion() { return _fechaCreacion; }

        #endregion
    }
}
