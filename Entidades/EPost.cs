using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class EPost
    {
        private int _id;
        private String _titulo;
        private String _texto;
        private DateTime _fechaCreacion;
        private DateTime _fechaModificacion;


        #region Getters y Setters

        public void setID(int id) { _id = id; }
        public void setTitulo(String titulo) { _titulo = titulo; }
        public void setTexto(String texto) { _texto = texto; }
        public void setFechaCreacion(DateTime fechaCreacion) { _fechaCreacion = fechaCreacion; }
        public void setFechaModificacion(DateTime fechaModificacion) { _fechaModificacion = fechaModificacion; }
        public int getID() { return _id; }
        public String getTitulo() { return _titulo; }
        public String getTexto() { return _texto; }
        public DateTime getFechaCreacion() { return _fechaCreacion; }
        public DateTime getFechaModificacion() { return _fechaModificacion; }

        #endregion
    }
}
