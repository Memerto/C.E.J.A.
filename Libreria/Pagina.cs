using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Libreria
{
    class Pagina
    {
        private int _id;
        private String _titulo;
        private String _informacion;
        private int _cantidadAprobacion;
        private int _cantidadDesaprobacion;
        private Tema _tema;
        private ArrayList _idPropuestas;

        #region Getters y Setters

        public void setID(int id) { _id = id; }
        public void setTitulo(String titulo) { _titulo = titulo; }
        public void setInformacion(String informacion) { _informacion = informacion; }
        public void setCantidadAprobacion(int cantidadAprobacion) { _cantidadAprobacion = cantidadAprobacion; }
        public void setCantidadDesaprobacion(int cantidadDesaprobacion) { _cantidadDesaprobacion = cantidadDesaprobacion; }
        public void setTema(Tema tema) { _tema = tema; }
        public void setMejoresPropuestas(ArrayList mejoresPropuestas) { _idPropuestas = mejoresPropuestas; }

        public int getID() { return _id; }
        public String getTitulo() { return _titulo; }
        public String getInformacion() { return _informacion; }
        public int getCantidadAprobacion() { return _cantidadAprobacion; }
        public int getCantidadDesaprobacion() { return _cantidadDesaprobacion; }
        public Tema getTema() { return _tema; }
        public ArrayList getMejoresPropuestas() { return _idPropuestas; }

        #endregion

        public Pagina() {

            setID(0);
            setTitulo("");
            setInformacion("");
            setCantidadAprobacion(0);
            setCantidadDesaprobacion(0);
            setTema(new Tema());
        }

        public Pagina(int id, String titulo, String informacion, int cantidadAprobacion, int cantidadDesaprobacion, Tema tema) {

            if (id == 0)
            {
                throw new ArgumentNullException("Constructor Pagina - ID invalida.");
            }
            else
            {
                if (titulo == null || titulo == "")
                {
                    throw new ArgumentNullException("Constructor Pagina - Titulo invalido.");
                }
                else
                {
                    if (informacion == null || informacion == "")
                    {
                        throw new ArgumentNullException("Constructor Pagina - Informacion invalida.");
                    }
                    else
                    {
                        if (tema.getID().Equals(0))
                        {
                            throw new ArgumentNullException("Constructor Pagina - Tema invalido.");
                        }
                        else
                        {
                            setID(id);
                            setTitulo(titulo);
                            setInformacion(informacion);
                            setCantidadAprobacion(cantidadAprobacion);
                            setCantidadDesaprobacion(cantidadDesaprobacion);
                            setTema(tema);
                        }
                    }
                }
            }
        }

        public Boolean actualizarPagina(String informacion,String titulo) {

            Tema tema = getTema();
            
            if (informacion != null || informacion != "")
            {
                setInformacion(informacion);
            }
            if (titulo != null || titulo != "")
	        {
                setTitulo(titulo);
	        }

            actualizarCantidadesAprobDesaprob();


            return true;
        }

        public void agregarPropuesta(Propuesta propuesta) {

            getTema().agregarPropuesta(propuesta);
        }

        public void eliminarPropuesta(Propuesta propuesta) {

            getTema().eliminarPropuesta(propuesta);
        }

        public void actualizarCantidadesAprobDesaprob(TipoPropuesta tipo) {

            setCantidadAprobacion(getTema().obtenerCantidadAprobacion(getTema().obtenerMejorPropuesta(tipo)));
            setCantidadAprobacion(getTema().obtenerCantidadDesaprobacion(getTema().obtenerMejorPropuesta(tipo)));
        }

    }
}
