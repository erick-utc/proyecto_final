using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace EE_Examen2_Progra2.Classes
{
    public class Asignaciones
    {
        public int AsignacionID { get; set; }
        public int ReparacionID { get; set; }

        public int TecnicoID { get; set; }

        public string FechaAsignacion { get; set; }

        public Asignaciones() {
            ReparacionID = 0;
            TecnicoID = 0;
            FechaAsignacion = string.Empty;
        }

        public bool agregarAsignacion()
        {
            int success = Proc2BD.insertarAsignacion(ReparacionID, TecnicoID);

            return success > 0;
        }

        public bool borrarAsignacion()
        {
            int success = Proc2BD.borrarAsignacionesPorId(ReparacionID);

            return success > 0;
        }

        public bool modificarAsignacion()
        {
            int success = Proc2BD.actualizarAsignacionPorId(AsignacionID, ReparacionID, TecnicoID);

            return success > 0;
        }

        public bool consultarAsignacion(GridView dg)
        {
            int success = Proc2BD.consultarAsignacionesPorId(AsignacionID, dg);

            return success > 0;
        }
    }
}