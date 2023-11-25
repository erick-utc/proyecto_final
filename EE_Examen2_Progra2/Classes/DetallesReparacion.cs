using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace EE_Examen2_Progra2.Classes
{
    public class DetallesReparacion
    {
        public  int  DetalleID { get; set; }
        public int ReparacionID { get; set; }
        public string Descripcion { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }

        public DetallesReparacion()
        {
            ReparacionID = 0;
            Descripcion = string.Empty;
            FechaFin = string.Empty;
            FechaInicio = string.Empty;
        }

        public bool agregarDetallesReparacion()
        {
            int success = Proc2BD.insertarDetalleReparacion(ReparacionID, Descripcion);

            return success > 0;
        }

        public bool borrarDetallesReparacion()
        {
            int success = Proc2BD.borrarDetallesReparacionPorId(DetalleID);

            return success > 0;
        }

        public bool modificarDetallesReparacion()
        {
            int success = Proc2BD.actualizarDetallesReparacionPorId(DetalleID, ReparacionID, Descripcion, FechaFin);

            return success > 0;
        }

        public bool consultarDetallesReparacion(GridView dg)
        {
            int success = Proc2BD.consultarDetallesReparacionPorId(DetalleID, dg);

            return success >= 0;
        }
    }
}