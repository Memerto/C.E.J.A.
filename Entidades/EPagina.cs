using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class EPagina
    {
        private int _id;
        private String _titulo;
        private String _informacion;
        private int _cantidadAprobacion;
        private int _cantidadDesaprobacion;
        private ETema _tema;
        private ArrayList _idPropuestas; //nose todavia

        #region Getters y Setters

        public void setID(int id) { _id = id; }
        public void setTitulo(String titulo) { _titulo = titulo; }
        public void setInformacion(String informacion) { _informacion = informacion; }
        public void setCantidadAprobacion(int cantidadAprobacion) { _cantidadAprobacion = cantidadAprobacion; }
        public void setCantidadDesaprobacion(int cantidadDesaprobacion) { _cantidadDesaprobacion = cantidadDesaprobacion; }
        public void setTema(ETema tema) { _tema = tema; }
        public void setMejoresPropuestas(ArrayList mejoresPropuestas) { _idPropuestas = mejoresPropuestas; }

        public int getID() { return _id; }
        public String getTitulo() { return _titulo; }
        public String getInformacion() { return _informacion; }
        public int getCantidadAprobacion() { return _cantidadAprobacion; }
        public int getCantidadDesaprobacion() { return _cantidadDesaprobacion; }
        public ETema getTema() { return _tema; }
        public ArrayList getMejoresPropuestas() { return _idPropuestas; }

        #endregion
    }
}
