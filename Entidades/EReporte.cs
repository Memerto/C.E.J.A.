using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class EReporte
    {
        private int _id;
        private int _idPost;
        private int _idUsuarioReportado;
        private ETipoReporte _tipoReporte;
        private EUsuario _usuario;
        private DateTime _fechaCreacion;

        #region Getters y Setters

        public void setID(int id) { _id = id; }
        public void setIDPost(int idPost) { _idPost = idPost; }
        public void setIDUsuarioReportado(int idUsuarioReportado) { _idUsuarioReportado = idUsuarioReportado; }
        public void setTipoReporte(ETipoReporte tipoReporte) { _tipoReporte = tipoReporte; }
        public void setUsuario(EUsuario usuario) { _usuario = usuario; }
        public void setFechaCreacion(DateTime fechaCreacion) { _fechaCreacion = fechaCreacion; }
        public int getID() { return _id; }
        public int getIDPost() { return _idPost; }
        public int getIDUsuarioReportado() { return _idUsuarioReportado; }
        public ETipoReporte getTipoReporte() { return _tipoReporte; }
        public EUsuario getUsuario() { return _usuario; }
        public DateTime getFechaCreacion() { return _fechaCreacion; }

        #endregion
    }
}
