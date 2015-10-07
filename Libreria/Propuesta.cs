using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Libreria
{
    [Serializable]
    class Propuesta
    {
        private String _id;
        private String _idPropRelacionada;
        private TipoPropuesta _tipoPropuesta;
        private ArrayList _calificaciones; //Calificaciones
        private ArrayList _adminVotaron;  //Administradores que votaron. Maximo 3
        private int _votosAprobarAdmin;
        private Boolean _preAprobada;
        private Boolean _aprobada;
        private String _texto;
        private DateTime _fechaCreacion;
        private DateTime _fechaModificacione;

        #region Setters y Getters

        public void setID(String id) { _id = id; }
        public void setIdPropuestaRelacionada(String id) { _idPropRelacionada = id; }
        public void setTipoPropuesta(TipoPropuesta tipoPropuesta) { _tipoPropuesta = tipoPropuesta; }
        public void setCalificaciones(ArrayList calificaciones) { _calificaciones = calificaciones; }
        public void setAdminVotaron(ArrayList adminVotaron) { _adminVotaron = adminVotaron;}
        public void setVotosAprobarAdmin(int votos) { _votosAprobarAdmin = votos; }
        public void setPreAprobada(Boolean preAprobada) { _preAprobada = preAprobada; }
        public void setAprobada(Boolean aprobada) { _aprobada = aprobada; }
        public void setTexto(String texto) { _texto = texto; }
        public void setFechaCreacion(DateTime fechaCreacion) { _fechaCreacion = fechaCreacion; }
        public void setFechaModificacion(DateTime fechaModificacion) { _fechaModificacione = fechaModificacion; }
        public String getID() { return _id; }
        public String getIdPropuestaRelacionada() { return _idPropRelacionada; }
        public TipoPropuesta getTipoPropuesta() { return _tipoPropuesta; }
        public ArrayList getCalificaciones() { return _calificaciones; }
        public ArrayList getAdminVotaron(){ return _adminVotaron;}
        public int getVotosAprobarAdmin() { return _votosAprobarAdmin; }
        public Boolean getPreAprobada() { return _preAprobada; }
        public Boolean getAprobada() { return _aprobada; }
        public String getTexto() { return _texto; }
        public DateTime getFechaCreacion() { return _fechaCreacion; }
        public DateTime getFechaModificacion() { return _fechaModificacione; }

        #endregion

        public Propuesta() {

            setID("0000");
            setIdPropuestaRelacionada("0000");
            setTipoPropuesta(new TipoPropuesta());
            setCalificaciones(new ArrayList());
            setAdminVotaron(new ArrayList());
            setVotosAprobarAdmin(0);
            setPreAprobada(false);
            setAprobada(false);
            setTexto("");
            setFechaCreacion(DateTime.Now);
            setFechaModificacion(DateTime.Now);
        
        }

        public Propuesta(String id, TipoPropuesta tipoPropuesta, Boolean preAprobada, Boolean aprobada, String texto)
        {
            if (id == "0000")
            {
                throw new ArgumentNullException("Constructor Propuesta - ID invalido.");
            }
            else
            {
                if (tipoPropuesta == null || tipoPropuesta.getID() == 0)
                {
                    throw new ArgumentNullException("Constructor Propuesta - Tipo invalida.");
                }
                else
                {
                    if (preAprobada != true && preAprobada != false)
                    {
                        throw new ArgumentNullException("Constructor Propuesta - Valor Pre Aprobada invalido");
                    }
                    else
                    {
                        if (aprobada != true && aprobada != false)
                        {
                            throw new ArgumentNullException("Constructor Propuesta . Valor Aprobacion invalido.");
                        }
                        else
                        {
                            if (texto == null || texto == "")
                            {
                                throw new ArgumentNullException("Constructor Propuesta - Texto invalido.");
                            }
                            else
                            {
                                setID(id);
                                setIdPropuestaRelacionada("0000");
                                setTipoPropuesta(tipoPropuesta);
                                setCalificaciones(new ArrayList());
                                setAdminVotaron(new ArrayList());
                                setVotosAprobarAdmin(0);
                                setPreAprobada(preAprobada);
                                setAprobada(aprobada);
                                setTexto(texto);
                                setFechaCreacion(DateTime.Now);
                                setFechaModificacion(DateTime.Now);
                            }
                        }
                    }
                }
            }
            
        }

        public Propuesta(String id, String idPropuestaRelacionada, TipoPropuesta tipoPropuesta, Boolean preAprobada, Boolean aprobada, String texto)
        {
            if (id == "00000")
            {
                throw new ArgumentNullException("Constructor Propuesta - ID invalido.");
            }
            else
            {
                if (idPropuestaRelacionada == "0000")
                {
                    throw new ArgumentNullException("Constructor Propuesta - ID de la Propuesta relacionada invalido.");
                }
                else
                {
                    if (tipoPropuesta == null || tipoPropuesta.getID() == 0)
                    {
                        throw new ArgumentNullException("Constructor Propuesta - Tipo invalida.");
                    }
                    else
                    {
                        if (preAprobada != true && preAprobada != false)
                        {
                            throw new ArgumentNullException("Constructor Propuesta - Valor Pre Aprobada invalido");
                        }
                        else
                        {
                            if (aprobada != true && aprobada != false)
                            {
                                throw new ArgumentNullException("Constructor Propuesta . Valor Aprobacion invalido.");
                            }
                            else
                            {
                                if (texto == null || texto == "")
                                {
                                    throw new ArgumentNullException("Constructor Propuesta - Texto invalido.");
                                }
                                else
                                {
                                    setID(id);
                                    setIdPropuestaRelacionada(idPropuestaRelacionada);
                                    setTipoPropuesta(tipoPropuesta);
                                    setCalificaciones(new ArrayList());
                                    setAdminVotaron(new ArrayList());
                                    setVotosAprobarAdmin(0);
                                    setPreAprobada(preAprobada);
                                    setAprobada(aprobada);
                                    setTexto(texto);
                                    setFechaCreacion(DateTime.Now);
                                    setFechaModificacion(DateTime.Now);
                                }
                            }
                        }
                    }
                }
            }
        }

        public Boolean agregarCalificacion(Calificacion calificacion) {
            if (calificacion == null || calificacion.getID() == 0)
            {
                throw new ArgumentNullException("Propuesta (Agregar Calificaion) - Calificacion invalida");
            }
            else
            {
                Calificacion cali;
                for (int i = 0; i < getCalificaciones().Count; i++)
                {
                    cali = (Calificacion)getCalificaciones()[i];
                    if (cali.getID().Equals(calificacion.getID()) || cali.Equals(calificacion))
                    {
                        throw new ArgumentOutOfRangeException("Propuesta (Agregar Calificaion) - Ya se encuentra esa calificacion en este tema.");
                    }
                }

                _calificaciones.Add(calificacion);
                setFechaModificacion(DateTime.Now);
                return true;
            } 
        }

        public Boolean elminiarCalificacion(int id)
        {

            if (id != 0 && id > 0)
            {
                for (int i = 0; i < getCalificaciones().Count; i++)
                {
                    Calificacion cali = new Calificacion();
                    cali = (Calificacion)_calificaciones[i];
                    if (cali.getID() == id)
                    {
                        _calificaciones.RemoveAt(i);
                        setFechaModificacion(DateTime.Now);
                        return true;
                    }
                }
                throw new ArgumentException("Propuesta (Eliminar Calificacion) - No se encontro la calificacion a eliminar");
            }
            else
            {
                throw new Exception("Propuesta (Eliminar Calificacion) - Ingrese una id valida");
            }

        }

        public Boolean modificarIDPropuestaRelacionada(Propuesta propuestaRelacionada) {

            String idRelacionada = propuestaRelacionada.getID();
            if (idRelacionada == "0000")
            {
                throw new ArgumentNullException("Propuesta (Mod. ID Prop. Relacionada) - La ID Relacionada es invalida");
            }
            else
            {
                if (idRelacionada.Equals(getID()))
                {
                    throw new ArgumentException("Propuesta (Mod. ID Prop. Relacionada) - La ID Relacionada no puede ser la misma del Tema.");
                }
                else
                {
                    if (getIdPropuestaRelacionada().Equals(propuestaRelacionada.getID()))
                    {
                        throw new ArgumentException("Propuesta (Mod. ID Prop. Relacionada) - Esta Propuesta ya esta relacionada con la que ingresaste.");
                    }
                    else
                    {
                        setIdPropuestaRelacionada(idRelacionada);
                        setFechaModificacion(DateTime.Now);
                        return true;
                    }

                }
            }  
        }

        public Boolean actualizarPropuesta(String texto) {

            if (texto == null || texto == "")
            {
                throw new ArgumentNullException("Propuesta (Actualizar Propuesta) - Texto vacio o Invalido. No se actualizo la propuesta.");
            }
            else
            {
                if (texto == getTexto())
                {
                    throw new ArgumentException("Propuesta (Actualizar Propuesta) - Mismo texto, nada que actualizar.");
                }
                setTexto(texto);
                setFechaModificacion(DateTime.Now);
                return true;
            }
        }

        
    }
}
