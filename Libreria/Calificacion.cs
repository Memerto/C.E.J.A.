using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libreria
{
    [Serializable]
    class Calificacion
    {
        private int _id;
        private Usuario _usuario;
        private Propuesta _propuesta; //mmmm
        private Boolean _aprueba;
        private String _comentario;
        private DateTime _fechaCreacion;

        #region Getters y Setters

        public void setID(int id) { _id = id; }
        public void setUsuario(Usuario usuario) { _usuario = usuario; }
        public void setPropuesta(Propuesta propuesta) { _propuesta = propuesta; }
        public void setAprueba(Boolean aprueba) { _aprueba = aprueba; }
        public void setComentario(String comentario) { _comentario = comentario; }
        public void setFechaCreacion(DateTime fechaCreacion) { _fechaCreacion = fechaCreacion; }

        public int getID() { return _id; }
        public Usuario getUsuario() { return _usuario; }
        public Propuesta getPropuesta() { return _propuesta; }
        public Boolean getAprueba() { return _aprueba; }
        public String getComentario() { return _comentario; }
        public DateTime getFechaCreacion() { return _fechaCreacion; }

        #endregion

        public Calificacion() {

            setID(0);
            setComentario("");
            setUsuario(new Usuario());
            setPropuesta(new Propuesta());
            setAprueba(false);
            setFechaCreacion(DateTime.Now);

        }

        public Calificacion(int id,Boolean aprueba,String comentario) {

            if (id == 0)
            {
                throw new ArgumentNullException("Constructor Calificacion - ID invalida.");
            }
            else
            {
                if (aprueba != true && aprueba != false)
                {
                    throw new ArgumentNullException("Constructor Calificacion - Valor Aprobacion invalido.");
                }
                else
                {
                    if (comentario == null)
                    {
                        throw new ArgumentNullException("Constructor Calificacion - Comentario invalido.");
                    }
                    else
                    {
                        setID(id);
                        setUsuario(new Usuario());
                        setPropuesta(new Propuesta());
                        setAprueba(aprueba);
                        setComentario(comentario);
                        setFechaCreacion(DateTime.Now);
                    }
                }
            }
    }

        public void agregarUsuario(Usuario usuario) {
            if (usuario.getID() != "0000" || usuario != null)
            {
                if (usuario.getID() == getUsuario().getID() || usuario.Equals(getUsuario()))
                {
                    throw new ArgumentException("Calficicacion (Agregar Usuario) - La calificacion ya esta relacionada con ese usuario.");
                }
                else
                {
                    setUsuario(usuario);
                }                
            }
            else
            {
                throw new ArgumentNullException("Calificacion (Agregar Usuario) - Usuario invalido");
            }
        }
    }
}
