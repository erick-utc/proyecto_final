using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

namespace EE_Examen2_Progra2.Classes
{
    public class Proc2BD
    {
        /************************** DetallesReparacion ********************/
        public static int consultarDetallesReparacion(GridView dg)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_DETALLESREPARACION", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int ConsultarReparacionesDetallesReparacion(DropDownList dg)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_REPARACIONES", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;

                                dg.DataTextField = dt.Columns["ReparacionID"].ToString();
                                dg.DataValueField = dt.Columns["ReparacionID"].ToString();
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }
        public static int consultarDetallesReparacionPorId(int id, GridView dg)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_DETALLESREPARACION_ID", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        cmd.Parameters.Add(new SqlParameter("@ID", id));
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int borrarDetallesReparacionPorId(int id)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("BORRAR_DETALLESREPARACION_ID", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int insertarDetalleReparacion(int reparacionId, string descripcion)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("INSERTAR_DETALLESREPARACION", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@REPARACIONID", reparacionId));
                    cmd.Parameters.Add(new SqlParameter("@DESCRIPCION", descripcion));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int actualizarDetallesReparacionPorId(int id, int reparacionId, string descripcion, string fechaFin)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("ACTUALIZAR_DETALLESREPARACION_ID", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));
                    cmd.Parameters.Add(new SqlParameter("@REPARACIONID", reparacionId));
                    cmd.Parameters.Add(new SqlParameter("@DESCRIPCION", descripcion));
                    cmd.Parameters.Add(new SqlParameter("@FECHAFIN", fechaFin));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }
        /************************** Asignaciones ********************/
        public static int consultarAsignaciones(GridView dg)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_ASIGNACIONES", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int ConsultarReparacionesAsignaciones(DropDownList dg)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_REPARACIONES", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;

                                dg.DataTextField = dt.Columns["ReparacionID"].ToString();
                                dg.DataValueField = dt.Columns["ReparacionID"].ToString();
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int ConsultarTecnicosAsignaciones(DropDownList dg)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_TECNICOS", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;

                                dg.DataTextField = dt.Columns["Nombre"].ToString();
                                dg.DataValueField = dt.Columns["TecnicoID"].ToString();
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }
        public static int consultarAsignacionesPorId(int id, GridView dg)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_ASIGNACIONES_ID", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        cmd.Parameters.Add(new SqlParameter("@ID", id));
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int borrarAsignacionesPorId(int id)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("BORRAR_ASIGNACIONES_ID", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int insertarAsignacion(int reparacionId, int tecnicoId)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("INSERTAR_ASIGNACION", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@REPARACIONID", reparacionId));
                    cmd.Parameters.Add(new SqlParameter("@TECNICOID", tecnicoId));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int actualizarAsignacionPorId(int id, int reparacionId, int tecnicoId)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("ACTUALIZAR_ASIGNACION_ID", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));
                    cmd.Parameters.Add(new SqlParameter("@REPARACIONID", reparacionId));
                    cmd.Parameters.Add(new SqlParameter("@TECNICOID", tecnicoId));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }
        /************************** Reparaciones ********************/
        public static int consultarReparaciones(GridView dg)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_REPARACIONES", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int ConsultarEquiposReparaciones(DropDownList dg)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_EQUIPOS", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;

                                dg.DataTextField = dt.Columns["TipoEquipo"].ToString();
                                dg.DataValueField = dt.Columns["EquipoID"].ToString();
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }
        public static int consultarReparacionesPorId(int id, GridView dg)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_REPARACIONES_ID", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        cmd.Parameters.Add(new SqlParameter("@ID", id));
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int borrarReparacionesPorId(int id)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("BORRAR_REPARACIONES_ID", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int insertarReparacion(int equipId, char estado)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("INSERTAR_REPARACION", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@EQUIPOID", equipId));
                    cmd.Parameters.Add(new SqlParameter("@ESTADO", estado));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int actualizarReparacionPorId(int id, int equipId, char estado)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("ACTUALIZAR_EQUIPO_ID", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));
                    cmd.Parameters.Add(new SqlParameter("@EQUIPOID", equipId));
                    cmd.Parameters.Add(new SqlParameter("@ESTADO", estado));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        /************************** Equipos ********************/
        public static int consultarEquipos(GridView dg)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_EQUIPOS", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        using(SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using(DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int ConsultarUsuariosEquipos(DropDownList dg)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_USUARIOS", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;

                                dg.DataTextField = dt.Columns["Nombre"].ToString();
                                dg.DataValueField = dt.Columns["UsuarioID"].ToString();
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }
        public static int consultarEquiposPorId(int id, GridView dg)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_EQUIPOS_ID", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        cmd.Parameters.Add(new SqlParameter("@ID", id));
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int borrarEquiposPorId(int id)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("BORRAR_EQUIPOS_ID", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int insertarEquipo(string tipo, string modelo, int usuario)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("INSERTAR_EQUIPO", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@TIPOEQUIPO", tipo));
                    cmd.Parameters.Add(new SqlParameter("@MODELO", modelo));
                    cmd.Parameters.Add(new SqlParameter("@USUARIOID", usuario));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int actualizarEquipoPorId(int id, string tipo, string modelo, int usuario)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("ACTUALIZAR_EQUIPO_ID", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));
                    cmd.Parameters.Add(new SqlParameter("@TIPOEQUIPO", tipo));
                    cmd.Parameters.Add(new SqlParameter("@MODELO", modelo));
                    cmd.Parameters.Add(new SqlParameter("@USUARIOID", usuario));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        /************************** Tecnicos ********************/
        public static int consultarTecnicos(GridView dg)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_TECNICOS", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int consultarTecnicosPorId(int id, GridView dg)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_TECNICOS_ID", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        cmd.Parameters.Add(new SqlParameter("@ID", id));
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int borrarTecnicosPorId(int id)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("BORRAR_TECNICOS_ID", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int insertarTecnico(string nombre, string especialidad)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("INSERTAR_TECNICO", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@NOMBRE", nombre));
                    cmd.Parameters.Add(new SqlParameter("@ESPECIALIDAD", especialidad));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int actualizarTecnicoPorId(int id, string nombre, string especialidad) {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("ACTUALIZAR_TECNICO_ID", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));
                    cmd.Parameters.Add(new SqlParameter("@NOMBRE", nombre));
                    cmd.Parameters.Add(new SqlParameter("@ESPECIALIDAD", especialidad));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        /*************** Usuarios ***************/
        public static int consultarUsuarios(GridView dg)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_USUARIOS", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int consultarUsuariosPorId(int id, GridView dg)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_USUARIOS_ID", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        cmd.Parameters.Add(new SqlParameter("@ID", id));
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int borrarUsuariosPorId(int id)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("BORRAR_USUARIOS_ID", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int insertarUsuario(string nombre, string correo, string telefono)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("INSERTAR_USUARIO", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@NOMBRE", nombre));
                    cmd.Parameters.Add(new SqlParameter("@CORREO", correo));
                    cmd.Parameters.Add(new SqlParameter("@TELEFONO", telefono));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }

        public static int actualizarUsuarioPorId(int id, string nombre, string correo, string telefono)
        {
            int ret = 0;

            SqlConnection cnx = new SqlConnection();
            try
            {
                using (cnx = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("ACTUALIZAR_USUARIO_ID", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));
                    cmd.Parameters.Add(new SqlParameter("@NOMBRE", nombre));
                    cmd.Parameters.Add(new SqlParameter("@CORREO", correo));
                    cmd.Parameters.Add(new SqlParameter("@TELEFONO", telefono));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx);
            }

            return ret;
        }
    }
}