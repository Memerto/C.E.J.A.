using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Entidades
{
    [Serializable]
    public class ESeccion
    {
        private int _id;
        private String _nombre;
        private ArrayList _tags; //Contiene Tags : String
        private ArrayList _temas;  //Contiene Temas
        private DateTime _fechaCreacion;
        private DateTime _fechaModificacione;

        #region Getters y Setters

        public void setID(int id) { _id = id; }
        public void setNombre(String nombre) { _nombre = nombre; }
        public void setTags(ArrayList tags) { _tags = tags; }
        public void setTemas(ArrayList temas) { _temas = temas; }
        public void setFechaCreacion(DateTime fechaCreacion) { _fechaCreacion = fechaCreacion; }
        public void setFechaModificacion(DateTime fechaModificacion) { _fechaModificacione = fechaModificacion; }
        public int getID() { return _id; }
        public String getNombre() { return _nombre; }
        public ArrayList getTags() { return _tags; }
        public ArrayList getTemas() { return _temas; }
        public DateTime getFechaCreacion() { return _fechaCreacion; }
        public DateTime getFechaModificacion() { return _fechaModificacione; }

        #endregion
    }
}
