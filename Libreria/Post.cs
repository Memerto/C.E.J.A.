using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libreria
{
    class Post
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

        public Post() {

            setID(0);
            setTitulo("");
            setTexto("");
            setFechaCreacion(DateTime.Now);
            setFechaModificacion(DateTime.Now);
        }

        public Post(int id, String titulo, String texto) {

            if (id == 0)
            {
                throw new ArgumentNullException("Constructor Post - ID invalida.");
            }
            else
            {
                if (titulo == "" || titulo == null)
                {
                    throw new ArgumentNullException("Constructor Post - Titulo invalido.");
                }
                else
                {
                    if (texto == "" || texto == null)
                    {
                        throw new ArgumentNullException("Constructor Post - Textp invalido.");
                    }
                    else
                    {
                        setID(id);
                        setTitulo(titulo);
                        setTexto(texto);
                        setFechaCreacion(DateTime.Now);
                        setFechaModificacion(DateTime.Now);
                    }
                }
            }
        }



    }
}
