using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Entidades
{
    [Serializable]
    public class EPropuesta
    {
        private String _id; //ID compuesta, primeros 4 digitos es su id, los otros 4 es la posicion en el ArrayList.
        private String _idPropRelacionada;
        private ETipoPropuesta _tipoPropuesta;
        private ArrayList _calificaciones; //Calificaciones
        private ArrayList _adminVotaron;  //Administradores que votaron. Maximo 3
        private int _votosAprobarAdmin;
        private Boolean _preAprobada;
        private Boolean _aprobada;
        private String _texto;
        private DateTime _fechaCreacion;
        private DateTime _fechaModificacione;

        #region Setters y Getters

        public void setID(String id) { _id = id; }
        public void setIdPropuestaRelacionada(String id) { _idPropRelacionada = id; }
        public void setTipoPropuesta(ETipoPropuesta tipoPropuesta) { _tipoPropuesta = tipoPropuesta; }
        public void setCalificaciones(ArrayList calificaciones) { _calificaciones = calificaciones; }
        public void setAdminVotaron(ArrayList adminVotaron) { _adminVotaron = adminVotaron; }
        public void setVotosAprobarAdmin(int votos) { _votosAprobarAdmin = votos; }
        public void setPreAprobada(Boolean preAprobada) { _preAprobada = preAprobada; }
        public void setAprobada(Boolean aprobada) { _aprobada = aprobada; }
        public void setTexto(String texto) { _texto = texto; }
        public void setFechaCreacion(DateTime fechaCreacion) { _fechaCreacion = fechaCreacion; }
        public void setFechaModificacion(DateTime fechaModificacion) { _fechaModificacione = fechaModificacion; }

        public String getID() { return _id; }
        public String getIdPropuestaRelacionada() { return _idPropRelacionada; }
        public ETipoPropuesta getTipoPropuesta() { return _tipoPropuesta; }
        public ArrayList getCalificaciones() { return _calificaciones; }
        public ArrayList getAdminVotaron() { return _adminVotaron; }
        public int getVotosAprobarAdmin() { return _votosAprobarAdmin; }
        public Boolean getPreAprobada() { return _preAprobada; }
        public Boolean getAprobada() { return _aprobada; }
        public String getTexto() { return _texto; }
        public DateTime getFechaCreacion() { return _fechaCreacion; }
        public DateTime getFechaModificacion() { return _fechaModificacione; }

        #endregion
    }
}
