using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace EE_Examen2_Progra2.Classes
{
    public class Reparaciones
    {
        public int ReparacionID { get; set; }
        public int EquipoID { get; set; }
        public string FechaSolicitud { get; set; }
        public char Estado { get; set; }

        public Reparaciones() {
            EquipoID = 0;
            FechaSolicitud = string.Empty;
            Estado = 'z';
        }

        public bool agregarReparacion()
        {
            int success = Proc2BD.insertarReparacion(EquipoID, Estado);

            return success > 0;
        }

        public bool borrarReparacion()
        {
            int success = Proc2BD.borrarReparacionesPorId(ReparacionID);

            return success > 0;
        } 

        public bool modificarReparacion()
        {
            int success = Proc2BD.actualizarReparacionPorId(ReparacionID, EquipoID, Estado);

            return success > 0;
        }

        public bool consultarReparacion(GridView dg)
        {
            int success = Proc2BD.consultarReparacionesPorId(ReparacionID, dg);

            return success > 0;
        }
    }
}