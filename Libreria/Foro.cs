using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Libreria
{
    class Foro
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

        public void agregarSeccion(Seccion seccion) {

            if (seccion.getID().Equals(0) || seccion.Equals(null))
            {
                throw new ArgumentNullException("Foro (Agregar Seccion) - Seccion invalida.");
            }
            else
            {
                Seccion secc;
                ArrayList secciones = getSecciones();
                for (int i = 0; i < secciones.Count; i++)
                {
                    secc = (Seccion)secciones[i];
                    if (secc.getID().Equals(seccion.getID()))
                    {
                        throw new ArgumentException("Foro (Agregar Seccion) - Seccion duplicada, ya está.");
                    }
                }
                secciones.Add(seccion);
                setSecciones(secciones);
                setFechaModificacion(DateTime.Now);
            }
        }

        public void actualizarPagina() { }

        public void listarSecciones() { }

        
    }
}
