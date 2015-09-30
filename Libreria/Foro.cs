using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libreria
{
    class Foro
    {
        private int _id;
        private Seccion[] _secciones;
        private DateTime _fechaCreacion;
        private DateTime _fechaModificacion;


        public void setID(int id) { _id = id; }
        public void setSecciones(Seccion[] secciones) { _secciones = secciones; }
        public void setFechaCreacion(DateTime fechaCreacion) { _fechaCreacion = fechaCreacion; }
        public void setFechaModificacion(DateTime fechaModificacion) { _fechaModificacion = fechaModificacion; }
        public int getID() { return _id; }
        public DateTime getFechaCreacion() { return _fechaCreacion; }
        public DateTime getFechaModificacion() { return _fechaModificacion; }

        public void agregarSeccion() { }

        public void actualizarPagina() { }

        public void listarSecciones() { }

        public void identificarMejorPropuesta() { }

    }
}
