using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libreria
{
    public class Categoria
    {
        private int _id;
        private String _tipo;

        #region Getters y Setters

        public void setID(int id) { _id = id; }
        public void setTipo(String tipo) { _tipo = tipo; }

        public int getID() { return _id; }
        public String getTipo() { return _tipo; }

        #endregion

        public Categoria() {

            setID(0);
            setTipo("");
        }

        public Categoria(int id,String tipo) {

            if (id == 0)
            {
                throw new ArgumentNullException("Constructor Categoria - ID invalido.");
            }
            else
            {
                if (tipo == "" || tipo == null)
                {
                    throw new ArgumentNullException("Constructor Categoria - Tipo invalido.");
                }
                else
                {
                    setID(id);
                    setTipo(tipo);
                }
            } 
        }

        public void cambiarTipo(String tipo)
        {
            if (tipo != null || tipo != "")
            {
                setTipo(tipo);
            }
            else
            {
                throw new ArgumentException("Categoria Tema (Cambiar Tipo) - Ingrese un tipo valido");
            }
        }


    }
}
