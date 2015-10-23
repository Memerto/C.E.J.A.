using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Entidades
{
    [Serializable]
    public class ETema
    {
        private int _id;
        private ArrayList _posts; //Contiene Posts.
        private ArrayList _propuestas; //Contiene Propuestas
        private ArrayList _tags; //Contiene Tags.
        private String _titulo;
        private ECategoria _categoria;
        private DateTime _fechaCreacion;
        private DateTime _fechaModificacion;

        #region Getters y Setters

        public void setID(int id) { _id = id; }
        public void setPosts(ArrayList posts) { _posts = posts; }
        public void setPropuestas(ArrayList propuestas) { _propuestas = propuestas; }
        public void setTags(ArrayList tags) { _tags = tags; }
        public void setTitulo(String titulo) { _titulo = titulo; }
        public void setCategoria(ECategoria categoria) { _categoria = categoria; }
        public void setFechaCreacion(DateTime fechaCreacion) { _fechaCreacion = fechaCreacion; }
        public void setFechaModificacion(DateTime fechaModificacion) { _fechaModificacion = fechaModificacion; }

        public int getID() { return _id; }
        public ArrayList getPosts() { return _posts; }
        public ArrayList getPropuestas() { return _propuestas; }
        public ArrayList getTags() { return _tags; }
        public String getTitulo() { return _titulo; }
        public ECategoria getCategoria() { return _categoria; }
        public DateTime getFechaCreacion() { return _fechaCreacion; }
        public DateTime getFechaModificacion() { return _fechaModificacion; }

        #endregion
    }
}
