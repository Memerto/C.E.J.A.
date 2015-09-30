using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libreria
{
    class Propuesta
    {
        private int id;
        private int idPropRelacionada;
        private TipoPropuesta tipoPropuesta;
        private Calificacion[] calificaciones;
        private Boolean preAprobada;
        private Boolean aprobada;
        private String texto;
        private DateTime fechaCreacion;
        private DateTime fechaModificacione;

        public void agregarCalificacion() { }

        public void modificarIDPropuestaRelacionada() { }

        public void elminiarCalificacion() { }

        public void actualizarPropuesta() { }

    }
}
