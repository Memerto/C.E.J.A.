using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class EForo
    {

        private int _id;
        private ArrayList _secciones;
        private DateTime _fechaCreacion;
        private DateTime _fechaModificacion;

        #region Setters y Getters

        public void setID(int id) { _id = id; }
        public void setSecciones(ArrayList secciones) { _secciones = secciones; }
        public void setFechaCreacion(DateTime fechaCreacion) { _fechaCreacion = fechaCreacion; }
        public void setFechaModificacion(DateTime fechaModificacion) { _fechaModificacion = fechaModificacion; }
        public int getID() { return _id; }
        public ArrayList getSecciones() { return _secciones; }
        public DateTime getFechaCreacion() { return _fechaCreacion; }
        public DateTime getFechaModificacion() { return _fechaModificacion; }

        #endregion



    }
}
