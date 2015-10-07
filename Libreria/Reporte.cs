using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libreria
{
    class Reporte
    {
        private int _id;
        private int _idPost;
        private int _idUsuarioReportado;
        private TipoReporte _tipoReporte;
        private Usuario _usuario;
        private DateTime _fechaCreacion;

        #region Getters y Setters

        public void setID(int id) { _id = id; }
        public void setIDPost(int idPost) { _idPost = idPost; }
        public void setIDUsuarioReportado(int idUsuarioReportado) { _idUsuarioReportado = idUsuarioReportado; }
        public void setTipoReporte(TipoReporte tipoReporte) { _tipoReporte = tipoReporte; }
        public void setUsuario(Usuario usuario) { _usuario = usuario; }
        public void setFechaCreacion(DateTime fechaCreacion) { _fechaCreacion = fechaCreacion; }
        public int getID() { return _id; }
        public int getIDPost() { return _idPost; }
        public int getIDUsuarioReportado() { return _idUsuarioReportado; }
        public TipoReporte getTipoReporte() { return _tipoReporte; }
        public Usuario getUsuario() { return _usuario; }
        public DateTime getFechaCreacion() { return _fechaCreacion; }

        #endregion

        public Reporte(int id,int idPost,int idUsuarioReportado,TipoReporte tipoReporte,Usuario usuario) {

            if (id == 0)
            {
                throw new ArgumentNullException("Constructor Reporte - ID invalida.");
            }
            else
            {
                if (idPost == 0)
                {
                    throw new ArgumentNullException("Constructor Reporte - IDPost invalida.");
                }
                else
                {
                    if (idUsuarioReportado == 0)
                    {
                        throw new ArgumentNullException("Constructor Reporte - ID Usuario Reportado invalida.");
                    }
                    else
                    {
                        if (tipoReporte == null || tipoReporte.getID().Equals(0))
                        {
                            throw new ArgumentNullException("Constructor Reporte - Tipo Reporte invalido.");
                        }
                        else
                        {
                            if (usuario == null || usuario.getID().Equals(0))
                            {
                                throw new ArgumentNullException("Constructor Reporte - Usuario invalido.");
                            }
                            else
                            {
                                setID(id);
                                setIDPost(idPost);
                                setIDUsuarioReportado(idUsuarioReportado);
                                setTipoReporte(tipoReporte);
                                setUsuario(usuario);
                                setFechaCreacion(DateTime.Now);
                            }
                        }
                    }
                }
            }
        
        }

        public void agregarUsuario(Usuario usuario) {

            if (usuario.getID() != "0000")
            {
                setUsuario(usuario);
            }
            else
            {
                throw new ArgumentNullException("El usuario es invalido");
            }
        }
    }
}
