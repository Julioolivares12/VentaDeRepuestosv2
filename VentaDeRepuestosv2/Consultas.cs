using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeRepuestosv2.Helpers;
using VentaDeRepuestosv2.Modelos;

namespace VentaDeRepuestosv2
{
    class Consultas
    {
        public static LoginModel Login(string email, string pass)
        {
            LoginModel login = new LoginModel();
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand(null, con))
                {
                    cmd.CommandText = $"Select u.EMAIL, u.PRIMERNOMBRE,u.PRIMERAPELLIDO , p.NOMBRE as PERFIL from USUARIOS as u inner join PERFIL as p on u.ID_PERFIL=p.ID_PERFIL where u.EMAIL='{email}' and u.PASS='{pass}' ";
                    var rs = cmd.ExecuteReader();
                    if (rs.HasRows)
                    {
                        while (rs.Read())
                        {
                            login.Email = rs["EMAIL"].ToString();
                            login.PrimerApellido = rs["PRIMERAPELLIDO"].ToString();
                            login.PrimerNombre = rs["PRIMERNOMBRE"].ToString();
                            login.Perfil = rs["PERFIL"].ToString();
                        }
                    }
                }
            }
            return login;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection">objeto de la clase SqlConnection que devuelve la conexion con la bd</param>
        /// <param name="commandText"></param>
        /// <param name="commandType">hay tres tipos de comando StoreProcedure,Text,TableDirect tableDirect es solo para OLE DB </param>
        /// <param name="parameters">parametros de sql</param>
        /// <returns>retorna la cantidad de filas afectadas</returns>
        public static async Task<Int32> ExecuteNonQueryAsync(SqlConnection connection, string commandText
            , CommandType commandType, params SqlParameter[] parameters)
        {
            using (connection)
            {
                using (SqlCommand sqlCommand = new SqlCommand(commandText, connection))
                {
                    sqlCommand.CommandType = commandType;
                    sqlCommand.Parameters.AddRange(parameters);
                    connection.Open();

                    return await sqlCommand.ExecuteNonQueryAsync();
                }
            }
        }
        public static Int32 ExecuteNonQuery(SqlConnection connection, string commandText
            , CommandType commandType, params SqlParameter[] parameters)
        {
            using (connection)
            {
                using (var cmd = new SqlCommand(commandText, connection))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);
                  //  connection.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
       

        public static SqlDataReader ExecuteReader(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand(commandText, con))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);
                    //con.Open();
                    return cmd.ExecuteReader();
                }
            }
        }
        /// <summary>
        /// metodo para insertar empleados en la bd
        /// </summary>
        /// <param name="idPerfil"></param>
        /// <param name="idCargo"></param>
        /// <param name="primerNombre"></param>
        /// <param name="segundoNombre"></param>
        /// <param name="primerApellido"></param>
        /// <param name="segundoApellido"></param>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        /// <param name="fechaNac"></param>
        /// <param name="sexo"></param>
        /// <param name="estado"></param>
        /// <param name="email"></param>
        /// <returns>retorna la cantidad de filas afectadas</returns>
        public static Int32 crearEpleadoAsync(Usuario usuario)
        {
            var query = "insert into USUARIOS (ID_USUARIO,ID_CARGO,ID_PERFIL,PRIMERNOMBRE," +
                "SEGUNDONOMBRE,PRIMERAPELLIDO,SEGUNDOAPELLIDO,DIRECCION,TELEFONO,FECHANAC,SEXO,ESTADO_CIVIL,EMAIL,PASS)" +
                " VALUES (@ID_USUARIO,@ID_CARGO,@ID_PERFIL,@PRIMERNOMBRE,@SEGUNDONOMBRE,@PRIMERAPELLIDO,@SEGUNDOAPELLIDO,@DIRECCION,@TELEFONO,CONVERT(DATETIME,@FECHANAC),@SEXO,@ESTADO_CIVIL,@EMAIL,@PASS)";

            //parametros para la insercion de datos
            //se hacen las letras en minusculas
            var pass = usuario.PrimerNombre.ToLower() + usuario.PrimerApellido.ToLower() + "123";
            var passE = Encriptar.encriptarPassword(pass);
            var ID_USER = Guid.NewGuid().ToString();
            var parameterIDUSUARIO = new SqlParameter("@ID_USUARIO", ID_USER);
            var parameteridCargo = new SqlParameter("@ID_CARGO", usuario.ID_CARGO);
            var parameteridPerfil = new SqlParameter("@ID_PERFIL", usuario.ID_PERFIL);
            var parameterPrimerNombre = new SqlParameter("@PRIMERNOMBRE", usuario.PrimerNombre);
            var parameterSegundoNombre = new SqlParameter("@SEGUNDONOMBRE", usuario.SegundoNombre);
            var parameterPrimerApellido = new SqlParameter("@PRIMERAPELLIDO", usuario.PrimerApellido);
            var parameterSegundoApellido = new SqlParameter("@SEGUNDOAPELLIDO", usuario.SegundoApellido);
            var parameterDireccion = new SqlParameter("@DIRECCION", usuario.Direccion);
            var parameterTelefono = new SqlParameter("@TELEFONO", usuario.Telefono);
            var parameterFechaNac = new SqlParameter("@FECHANAC", usuario.FechaNac);
            var parameterSexo = new SqlParameter("@SEXO", usuario.Sexo);
            var parameterEstado = new SqlParameter("@ESTADO_CIVIL", usuario.EstadoCivil);
            var parameterEmail = new SqlParameter("@EMAIL", usuario.Email);
            var parameterPass = new SqlParameter("@PASS", passE);


            var con = Conexion.conectar();
            using (con)
            {
                var rows = ExecuteNonQuery(con, query, CommandType.Text, parameterIDUSUARIO, parameteridCargo
                    , parameteridPerfil, parameterPrimerNombre, parameterSegundoNombre, parameterPrimerApellido
                    , parameterSegundoApellido, parameterDireccion, parameterTelefono, parameterFechaNac, parameterSexo, parameterEstado, parameterEmail, parameterPass);

                return rows;
            }

        }
        public static Int32 ActualizarUsuario(Usuario usuario)
        {
            
            var query = $"UPDATE USUARIOS"+
                        $"SET [ID_CARGO] = '{usuario.ID_CARGO}'"+
                        $",[ID_PERFIL] ='{usuario.ID_PERFIL}'"+
                        $",[PRIMERNOMBRE] ='{usuario.PrimerNombre}'"+
                        $",[SEGUNDONOMBRE] = '{usuario.SegundoNombre}'"+
                        $",[PRIMERAPELLIDO] = '{usuario.PrimerApellido}'"+
                        $",[SEGUNDOAPELLIDO] = '{usuario.SegundoApellido}'"+
                        $",[DIRECCION] ='{usuario.Direccion}'"+
                        $",[TELEFONO] ='{usuario.Telefono}'"+
                        $",[FECHANAC] = '{usuario.FechaNac}'"+
                        $",[SEXO] = '{usuario.Sexo}'"+
                        $",[ESTADO_CIVIL] = '{usuario.EstadoCivil}'"+
                        $",[EMAIL] = '{usuario.Email}'"+ 
                        $"WHERE ID_USUARIO='{usuario.ID}'";
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand(query,con))
                {
                    cmd.CommandType = CommandType.Text;
                    var rs = cmd.ExecuteNonQuery();
                    if (rs > 0)
                    {
                        return rs;
                    }
                    else
                    {
                        return rs;
                    }  
                }
            }

        }
        public static Int32 ActualizarEpleado(Usuario usuario)
        {
            var query = "insert into USUARIOS (ID_USUARIO,ID_CARGO,ID_PERFIL,PRIMERNOMBRE," +
                "SEGUNDONOMBRE,PRIMERAPELLIDO,SEGUNDOAPELLIDO,DIRECCION,TELEFONO,FECHANAC,SEXO,ESTADO_CIVIL,EMAIL,PASS)" +
                " VALUES (@ID_USUARIO,@ID_CARGO,@ID_PERFIL,@PRIMERNOMBRE,@SEGUNDONOMBRE,@PRIMERAPELLIDO,@SEGUNDOAPELLIDO,@DIRECCION,@TELEFONO,CONVERT(DATETIME,@FECHANAC),@SEXO,@ESTADO_CIVIL,@EMAIL,@PASS)";

            //parametros para la insercion de datos
            //se hacen las letras en minusculas
            var pass = usuario.PrimerNombre.ToLower() + usuario.PrimerApellido.ToLower() + "123";
            var passE = Encriptar.encriptarPassword(pass);
            var ID_USER = Guid.NewGuid().ToString();
            var parameterIDUSUARIO = new SqlParameter("@ID_USUARIO", ID_USER);
            var parameteridCargo = new SqlParameter("@ID_CARGO", usuario.ID_CARGO);
            var parameteridPerfil = new SqlParameter("@ID_PERFIL", usuario.ID_PERFIL);
            var parameterPrimerNombre = new SqlParameter("@PRIMERNOMBRE", usuario.PrimerNombre);
            var parameterSegundoNombre = new SqlParameter("@SEGUNDONOMBRE", usuario.SegundoNombre);
            var parameterPrimerApellido = new SqlParameter("@PRIMERAPELLIDO", usuario.PrimerApellido);
            var parameterSegundoApellido = new SqlParameter("@SEGUNDOAPELLIDO", usuario.SegundoApellido);
            var parameterDireccion = new SqlParameter("@DIRECCION", usuario.Direccion);
            var parameterTelefono = new SqlParameter("@TELEFONO", usuario.Telefono);
            var parameterFechaNac = new SqlParameter("@FECHANAC", usuario.FechaNac);
            var parameterSexo = new SqlParameter("@SEXO", usuario.Sexo);
            var parameterEstado = new SqlParameter("@ESTADO_CIVIL", usuario.EstadoCivil);
            var parameterEmail = new SqlParameter("@EMAIL", usuario.Email);
            var parameterPass = new SqlParameter("@PASS", passE);


            var con = Conexion.conectar();
            using (con)
            {
                var rows = ExecuteNonQuery(con, query, CommandType.Text, parameterIDUSUARIO, parameteridCargo
                    , parameteridPerfil, parameterPrimerNombre, parameterSegundoNombre, parameterPrimerApellido
                    , parameterSegundoApellido, parameterDireccion, parameterTelefono, parameterFechaNac, parameterSexo, parameterEstado, parameterEmail, parameterPass);

                return rows;
            }

        }

        public static SqlDataReader getPerfilesAsync()
        {
            using (var con = Conexion.conectar())
            {
                var s = "select ID_PERFIL,NOMBRE from PERFIL";
                using (var cmd = new SqlCommand(s, con))
                {
                     con.OpenAsync();
                    return  cmd.ExecuteReader();
                }
            }
        }


        public static DataTable getCargos()
        {
            using (var con = Conexion.conectar())
            {
                using (var adapter = new SqlDataAdapter("SELECT ID_CARGO,NOMBRE FROM CARGOS", con))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public static DataTable getPerfiles()
        {
            using (var con = Conexion.conectar())
            {
                using (var adapter = new SqlDataAdapter("SELECT ID_PERFIL,NOMBRE FROM PERFIL", con))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public static DataTable getMarcas()
        {
            using (var con = Conexion.conectar())
            {
                using (var adpter = new SqlDataAdapter("SELECT ID_MARCAVEH,DESCRIPCION FROM MARCASVEHICULOS",con))
                {
                    var dt = new DataTable();
                    adpter.Fill(dt);
                    return dt;
                }
            }
        }
        public static DataTable getPartes()
        {
            using (var con = Conexion.conectar())
            {
                using (var adapter = new SqlDataAdapter("SELECT ID_PARTEVEH ,DESCRIPCION FROM PARTESVEHICULOS",con))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public static DataTable getEmpleados()
        {
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("SELECT * FROM USUARIOS", con))
                {
                    var adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }

        public static SqlDataReader getEmpleadoByID(string query, string id)
        {
            using (var con = Conexion.conectar())
            {

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID_USUARIO", id);
                    return cmd.ExecuteReader();
                }
            }
        }

        public static DataTable getModelosVehiculos()
        {
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("Select * from MODELOSVEHICULOS", con))
                {
                    var adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    return data;
                }
            }
        }
        public static DataTable getClasesDeVehiculos()
        {
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("select * from CLASESVEHICULOS", con))
                {
                    var adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    var data = new DataTable();
                    adapter.Fill(data);
                    return data;
                }
            }
        }

        public static ClaseDeVehiculo GetClaseDeVehiculoByID(string id)
        {
            ClaseDeVehiculo claseDeVehiculo = new ClaseDeVehiculo();
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("SELECT * FROM CLASESVEHICULOS", con))
                {
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            claseDeVehiculo.ID = reader["ID_CLASESVEH"].ToString();
                            claseDeVehiculo.Descripcion = reader["DESCRIPCION"].ToString();
                        }
                    }

                }
            }
            return claseDeVehiculo;
        }
        #region CRUD DE MODELOVEHICULO
        /// <summary>
        /// busca un ModeloVehiculo en la bd 
        /// </summary>
        /// <param name="id">id de un modelo</param>
        /// <returns>retorna un objeto de la clase ModeloVehiculo</returns>
        public static ModeloVehiculo getModeloDeVehiculoByID(string id)
        {
            ModeloVehiculo modelo = new ModeloVehiculo();
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("SELECT * FROM MODELOSVEHICULOS", con))
                {
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            modelo.ID = reader["ID_MODELOVEH"].ToString();
                            modelo.DESCRIPCION = reader["DESCRIPCION"].ToString();
                        }
                    }
                }
            }
            return modelo;
        }
        public static Int32 insertarModeloVehiculo(ModeloVehiculo modelo)
        {
            using (var con = Conexion.conectar())
            {
                var query = "INSERT INTO MODELOSVEHICULOS (ID_MODELOVEH,DESCRIPCION) VALUES (@ID_MODELOVEH,@DESCRIPCION)";
                var IDPARAMETER = new SqlParameter("@ID_MODELOVEH", modelo.ID);
                var DESCRIPCIONPARAMETER = new SqlParameter("@DESCRIPCION", modelo.DESCRIPCION);
                var r = ExecuteNonQuery(con, query, CommandType.Text, IDPARAMETER, DESCRIPCIONPARAMETER);
                return r;
            }
        }

        public static bool eliminarModeloVehiculo(string id)
        {
            using (var con = Conexion.conectar())
            {
                var query = "DELETE FROM MODELOSVEHICULOS WHERE ID_MODELOVEH=@ID_MODELOVEH";
                var parameter = new SqlParameter("@ID_MODELOVEH", id);
                var r = ExecuteNonQuery(con, query, CommandType.Text, parameter);
                if (r != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static Int32 actualizarModeloVehiculo(ModeloVehiculo modelo)
        {
            using (var con = Conexion.conectar())
            {
                var query = "UPDATE MODELOSVEHICULOS SET DESCRIPCION WHERE ID_MODELOVEH=@ID_MODELOVEH";

                var descripcionParameter = new SqlParameter("@ID_MODELOVEH", modelo.ID);
                var idParameter = new SqlParameter("@ID_MODELOVEH", modelo.ID);
                var r = ExecuteNonQuery(con, query, CommandType.Text, descripcionParameter, idParameter);

                return r;
            }
        }
        /*
        public static List<ClaseDeVehiculo> getModelosVehiculos()
        {
            List<ClaseDeVehiculo> lista = new List<ClaseDeVehiculo>();
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("SELECT * FROM MODELOSVEHICULOS",con))
                {
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var modelo = new ClaseDeVehiculo();
                            modelo.ID_ClaseVeg = reader["ID_MODELOVEH"].ToString();
                            modelo.Descripcion = reader["DESCRIPCION"].ToString();

                            lista.Add(modelo);
                        }
                    }
                }
            }
            return lista;
        }
        */
        #endregion fin crud


        #region crud tipovehiculo
        public static List<TipoVehiculo> GetTipoVehiculos()
        {
            var lista = new List<TipoVehiculo>();
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("Select * from TIPOVEHICULOS", con))
                {
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var tipo = new TipoVehiculo();
                            tipo.ID = reader["ID_TIPOVEH"].ToString();
                            tipo.DESCRIPCION = reader["DESCRIPCION"].ToString();
                            lista.Add(tipo);
                        }
                    }
                }
            }
            return lista;
        }
        public static TipoVehiculo GetTipoVehiculoByID(string id)
        {
            var tipo = new TipoVehiculo();
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("SELECT * FROM TIPOVEHICULOS WHERE ID_TIPOVEH=@ID_TIPOVEH", con))
                {
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            tipo.ID = reader["ID_TIPOVEH"].ToString();
                            tipo.DESCRIPCION = reader["DESCRIPCION"].ToString();
                        }

                    }
                }
            }
            return tipo;
        }
        public static bool InsertarTipoVehiculo(TipoVehiculo tipo)
        {
            using (var con = Conexion.conectar())
            {
                var query = "INSERT INTO TIPOVEHICULOS (ID_TIPOVEH,DESCRIPCION) VALUES (@ID_TIPOVEH,@DESCRIPCION)";
                var ID = Guid.NewGuid().ToString();
                var IDParam = new SqlParameter("@ID_TIPOVEH", ID);
                var DescripcionParam = new SqlParameter("@DESCRIPCION", tipo.DESCRIPCION);

                var ro = ExecuteNonQuery(con, query, CommandType.Text, IDParam, DescripcionParam);

                if (ro > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool ActualizarTipoVehiculo(TipoVehiculo tipo)
        {
            using (var con = Conexion.conectar())
            {
                var query = "UPDATE TIPOVEHICULOS SET DESCRIPCION=@DESCRIPCION WHERE ID_TIPOVEH=@ID_TIPOVEH";

                var IDParam = new SqlParameter("@ID_TIPOVEH", tipo.ID);
                var DescripcionParam = new SqlParameter("@DESCRIPCION", tipo.DESCRIPCION);

                var ro = ExecuteNonQuery(con, query, CommandType.Text, IDParam, DescripcionParam);

                if (ro > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool EliminarTipoVehiculo(string id)
        {
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("DELETE FROM  TIPOVEHICULOS WHERE ID_TIPOVEH=@ID_TIPOVEH", con))
                {
                    var parameterID = new SqlParameter("@ID_TIPOVEH", id);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(parameterID);

                    var r = cmd.ExecuteNonQuery();
                    if (r > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }
        #endregion

        #region CRUD PARTES DE VEHICULO
        public static List<ParteVehiculo> GetParteVehiculos()
        {
            List<ParteVehiculo> parteVehiculos = new List<ParteVehiculo>();
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("SELECT * FROM PARTESVEHICULOS", con))
                {
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var partes = new ParteVehiculo();
                            partes.ID = reader["ID_PARTEVEH"].ToString();
                            partes.DESCRIPCION = reader["DESCRIPCION"].ToString();
                            parteVehiculos.Add(partes);
                        }
                        return parteVehiculos;
                    }
                    else
                    {
                        return parteVehiculos;
                    }
                }
            }
        }
        public static ParteVehiculo GetParteVehiculo(string id)
        {
            var p = new ParteVehiculo();
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("SELECT * FROM PARTESVEHICULOS WHERE ID_PARTEVEH=@ID_PARTEVEH", con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID_PARTEVEH", id);
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            p.ID = reader["ID_PARTEVEH"].ToString();
                            p.DESCRIPCION = reader["DESCRIPCION"].ToString();
                        }

                    }
                }
            }
            return p;
        }

        public static bool InsertarParteVehiculo(ParteVehiculo parteVehiculo)
        {
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("INSERT INTO PARTESVEHICULOS (ID_PARTEVEH, DESCRIPCION) VALUES(@ID_PARTEVEH,@DESCRIPCION) ", con))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlParameter[] sqlParameters =
                    {
                       new  SqlParameter("@ID_PARTEVEH",parteVehiculo.ID),new SqlParameter("@DESCRIPCION",parteVehiculo.DESCRIPCION)
                    };
                    cmd.Parameters.AddRange(sqlParameters);
                    var r = cmd.ExecuteNonQuery();
                    if (r > 0)
                        return true;
                    else
                        return false;
                }
            }
        }
        public static bool ActualizarParteVehiculo(ParteVehiculo parteVehiculo)
        {
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("UPDATE PARTESVEHICULOS SET DESCRIPCION=@DESCRIPCION WHERE ID_PARTEVEH=@ID_PARTEVEH ", con))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlParameter[] sqlParameters =
                    {
                       new  SqlParameter("@ID_PARTEVEH",parteVehiculo.ID),new SqlParameter("@DESCRIPCION",parteVehiculo.DESCRIPCION)
                    };
                    cmd.Parameters.AddRange(sqlParameters);
                    var r = cmd.ExecuteNonQuery();
                    if (r > 0)
                        return true;
                    else
                        return false;
                }
            }
        }
        public static bool EliminarParteVehiculo(string id)
        {
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("DELETE FROM PARTESVEHICULOS WHERE ID_PARTEVEH=@ID_PARTEVEH ", con))
                {
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add(new SqlParameter("@ID_PARTEVEH", id));
                    var r = cmd.ExecuteNonQuery();
                    if (r > 0)
                        return true;
                    else
                        return false;
                }
            }
        }
        #endregion

        #region clases de vehiculos
        public static List<ClaseDeVehiculo> GetClaseDeVehiculos()
        {
            List<ClaseDeVehiculo> claseDeVehiculos = new List<ClaseDeVehiculo>();
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("SELECT * FROM CLASESVEHICULOS", con))
                {
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var claseDeVehiculo = new ClaseDeVehiculo();
                            claseDeVehiculo.ID = reader["ID_CLASESVEH"].ToString();
                            claseDeVehiculo.Descripcion = reader["DESCRIPCION"].ToString();
                            claseDeVehiculos.Add(claseDeVehiculo);
                        }
                        return claseDeVehiculos;
                    }
                    else
                    {
                        return claseDeVehiculos;
                    }
                }
            }
        }
        public static ClaseDeVehiculo GetClaseDeVehiculo(string id)
        {
            var p = new ClaseDeVehiculo();
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("SELECT * FROM CLASESVEHICULOS WHERE ID_CLASESVEH=@ID_CLASESVEH", con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID_CLASESVEH", id);
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            p.ID = reader["ID_CLASESVEH"].ToString();
                            p.Descripcion = reader["DESCRIPCION"].ToString();
                        }

                    }
                }
            }
            return p;
        }

        public static bool InsertarClaseVehiculo(ClaseDeVehiculo claseDeVehiculo)
        {
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("INSERT INTO CLASESVEHICULOS (ID_CLASESVEH, DESCRIPCION) VALUES(@ID_CLASESVEH,@DESCRIPCION) ", con))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlParameter[] sqlParameters =
                    {
                       new  SqlParameter("@ID_CLASESVEH",claseDeVehiculo.ID),new SqlParameter("@DESCRIPCION",claseDeVehiculo.Descripcion)
                    };
                    cmd.Parameters.AddRange(sqlParameters);
                    var r = cmd.ExecuteNonQuery();
                    if (r > 0)
                        return true;
                    else
                        return false;
                }
            }
        }
        public static bool ActualizarClaseVehiculo(ClaseDeVehiculo claseDeVehiculo)
        {
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("UPDATE CLASEVEHICULOS SET DESCRIPCION=@DESCRIPCION WHERE ID_CLASESVEH=@ID_CLASESVEH ", con))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlParameter[] sqlParameters =
                    {
                       new  SqlParameter("@ID_CLASESVEH",claseDeVehiculo.ID),new SqlParameter("@DESCRIPCION",claseDeVehiculo.Descripcion)
                    };
                    cmd.Parameters.AddRange(sqlParameters);
                    var r = cmd.ExecuteNonQuery();
                    if (r > 0)
                        return true;
                    else
                        return false;
                }
            }
        }
        public static bool EliminarClaseVehiculo(string id)
        {
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("DELETE FROM CLASEVEHICULOS WHERE ID_CLASESVEH=@ID_CLASESVEH ", con))
                {
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add(new SqlParameter("@ID_CLASESVEH", id));
                    var r = cmd.ExecuteNonQuery();
                    if (r > 0)
                        return true;
                    else
                        return false;
                }
            }
        }
        #endregion
        #region crud Repuestos
        public static List<Repuesto> GetRepuestos()
        {
            var repuestos = new List<Repuesto>();
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("SELECT * FROM REPUESTOS", con))
                {
                    cmd.CommandType = CommandType.Text;
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var mod = new Repuesto();
                            mod.ID = reader["ID_REPUESTO"].ToString();
                            mod.ID_PARTEVEH = reader["ID_PARTEVEH"].ToString();
                            mod.ID_MARCAVEH = reader["ID_MARCAVEH"].ToString();
                            mod.Nombe = reader["NOMBRE"].ToString();
                            mod.Descripcion = reader["DESCRIPCION"].ToString();
                            mod.PrecioCompra = Convert.ToDouble(reader["PRECIOCOMPRA"].ToString());
                            mod.PrecioVenta = Convert.ToDouble(reader["PRECIOVENTA"].ToString());
                            mod.Descuento = Convert.ToDouble(reader["DESCUENTO"].ToString());
                            mod.NumMotor = Convert.ToInt32(reader["NUM_MOTOR"].ToString());
                            mod.NumChasis = Convert.ToInt32(reader["NUM_CHASIS"].ToString());
                            mod.NumVin = Convert.ToInt32(reader["NUM_VIN"].ToString());

                            repuestos.Add(mod);
                        }
                    }
                }
            }
            return repuestos;
        }
        public static Repuesto GetRepuestoByID(string id)
        {
            var mod = new Repuesto();
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("SELECT * FROM REPUESTOS WHERE ID_REPUESTO = @ID_REPUESTO", con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID_REPUESTO", id);
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            mod.ID = reader["ID_REPUESTO"].ToString();
                            mod.ID_PARTEVEH = reader["ID_PARTEVEH"].ToString();
                            mod.ID_MARCAVEH = reader["ID_MARCAVEH"].ToString();
                            mod.Nombe = reader["NOMBRE"].ToString();
                            mod.Descripcion = reader["DESCRIPCION"].ToString();
                            mod.PrecioCompra = Convert.ToDouble(reader["PRECIOCOMPRA"].ToString());
                            mod.PrecioVenta = Convert.ToDouble(reader["PRECIOVENTA"].ToString());
                            mod.Descuento = Convert.ToDouble(reader["DESCUENTO"].ToString());
                            mod.NumMotor = Convert.ToInt32(reader["NUM_MOTOR"].ToString());
                            mod.NumChasis = Convert.ToInt32(reader["NUM_CHASIS"].ToString());
                            mod.NumVin = Convert.ToInt32(reader["NUM_VIN"].ToString());
                        }
                    }
                }
            }
            return mod;

        }

        public static bool InsertarRepuesto(Repuesto re)
        {
            using (var con = Conexion.conectar())
            {
                var query = $"INSERT INTO REPUESTOS ID_REPUESTO" +
                    $",ID_PARTEVEH,ID_MARCAVEH,NOMBRE,DESCRIPCION" +
                    $",PRECIOCOMPRA,PRECIOVENTA,DESCUENTO" +
                    $",NUM_MOTOR,NUM_CHASIS,NUM_VIN ) VALUES ({re.ID},{re.ID_PARTEVEH},{re.ID_MARCAVEH},{re.Nombe},{re.Descripcion}," +
                    $"{re.PrecioCompra},{re.PrecioVenta},{re.Descuento},{re.NumMotor},{re.NumChasis},{re.NumVin})";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;
                    var rs = cmd.ExecuteNonQuery();
                    if (rs > 0)
                        return true;
                    else
                        return false;
                }
            }
        }
        public static bool ActualizarRepuesto(Repuesto re)
        {
            var query = "UPDATE REPUESTOS" +
                 $"SET ID_PARTEVEH = '{re.ID_PARTEVEH}'" +
                 $" ,ID_MARCAVEH = '{re.ID_MARCAVEH}'" +
                 $" ,NOMBRE = '{re.Nombe}' " +
                 $" ,DESCRIPCION = '{re.Descripcion}' " +
                 $" ,PRECIOCOMPRA = {re.PrecioCompra}" +
                 $" ,PRECIOVENTA = {re.PrecioVenta}" +
                 $" ,DESCUENTO = {re.Descuento} " +
                 $",NUM_MOTOR = {re.NumMotor}" +
                 $",NUM_CHASIS = {re.NumChasis}" +
                 $" ,NUM_VIN = {re.NumVin} " +
                 $"WHERE ID_REPUESTO= '{re.ID}'";

            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;
                    var rs = cmd.ExecuteNonQuery();
                    if (rs > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public static bool EliminarRepuesto(string id)
        {
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand($"DELETE FROM REPUESTOS WHERE ID_REPUESTO='{id}'", con))
                {
                    cmd.CommandType = CommandType.Text;
                    var rs = cmd.ExecuteNonQuery();
                    if (rs > 0)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
        #endregion


        public static bool InsertarCliente(Clientes cliente)
        {
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("INSERT INTO CLIENTES (ID_CLIENTE,PRIMERNOMBRE,SEGUNDONOMBRE,PRIMERAPELLIDO,SEGUNDOAPELLIDO,FECHANAC,SEXO,ESTADO_CIVIL,LUGARTRABAJO) VALUES(@ID_CLIENTE,@PRIMERNOMBRE,@SEGUNDONOMBRE,@PRIMERAPELLIDO,@SEGUNDOAPELLIDO,@FECHANAC,@SEXO,@ESTADO_CIVIL,@LUGARTRABAJO) ", con))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlParameter[] sqlParameters =
                    {
                       new  SqlParameter("@ID_CLIENTE",cliente.ID),new SqlParameter("@PRIMERNOMBRE",cliente.PRIMERNOMBRE),new SqlParameter("@SEGUNDONOMBRE",cliente.SEGUNDONOMBRE)
                       ,new SqlParameter("@PRIMERAPELLIDO",cliente.PRIMERAPELLIDO),new SqlParameter("@SEGUNDOAPELLIDO",cliente.SEGUNDOAPELLIDO)
                       ,new SqlParameter("@FECHANAC",cliente.FECHANAC),new SqlParameter("@SEXO",cliente.SEXO)
                       ,new SqlParameter("@ESTADO_CIVIL",cliente.ESTADO_CIVIL),new SqlParameter("@LUGARTRABAJO",cliente.LUGARTRABAJO)
                    };
                    cmd.Parameters.AddRange(sqlParameters);
                    var r = cmd.ExecuteNonQuery();
                    if (r > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        public static bool EliminarCliente(string id)
        {
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("DELETE FROM CLIENTES WHERE ID_CLIENTE=@ID_CLIENTE ", con))
                {
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add(new SqlParameter("@ID_CLIENTE", id));
                    var r = cmd.ExecuteNonQuery();
                    if (r > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        public static Clientes GetCliente(string id)
        {
            var p = new Clientes();
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("SELECT * FROM CLIENTES WHERE ID_CLIENTE=@ID_CLIENTE", con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID_CLIENTE", id);
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            p.ID = reader["ID_CLIENTE"].ToString();
                            p.PRIMERNOMBRE = reader["PRIMERNOMBRE"].ToString();
                            p.SEGUNDONOMBRE = reader["SEGUNDONOMBRE"].ToString();
                            p.PRIMERAPELLIDO = reader["PRIMERAPELLIDO"].ToString();
                            p.SEGUNDOAPELLIDO = reader["SEGUNDOAPELLIDO"].ToString();
                            p.FECHANAC = reader["FECHANAC"].ToString();
                            p.SEXO = reader["SEXO"].ToString();
                            p.ESTADO_CIVIL = reader["ESTADO_CIVIL"].ToString();
                            p.LUGARTRABAJO = reader["LUGARTRABAJO"].ToString();
                        }

                    }
                }
            }
            return p;
        }


    }
}
