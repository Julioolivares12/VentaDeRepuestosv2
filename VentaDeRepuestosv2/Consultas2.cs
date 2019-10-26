using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeRepuestosv2.Modelos;

namespace VentaDeRepuestosv2
{
    class Consultas2
    {

       public static Repuesto GetRepuestoByUPC(string upc)
        {
            var mod = new Repuesto();
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("SELECT * FROM REPUESTOS WHERE UPC = @UPC", con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@UPC", upc);
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
                            mod.UPC = reader["UPC"].ToString();
                            mod.Cantidad = Convert.ToInt32(reader["CANTIDAD"].ToString());
                        }
                    }
                }
            }
            return mod;

        }
        public static Repuesto GetClintetobyId(string upc)
        {
            var mod = new Repuesto();
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("SELECT * FROM REPUESTOS WHERE UPC = @UPC", con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@UPC", upc);
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
                            mod.UPC = reader["UPC"].ToString();
                            mod.Cantidad = Convert.ToInt32(reader["CANTIDAD"].ToString());
                        }
                    }
                }
            }
            return mod;

        }

        public static bool InsertarVenta(Venta ventas)
        {
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("INSERT INTO VENTAS (ID_VENTA, ID_USUARIO,ID_CLIENTE,ID_REPUESTOS,NRODOC,ID_TIPODOC,NRO_CF,FECHAVENTA,SUBTOTAL,DESCUENTO,IVA,MONTOTOTAL) VALUES(@ID_VENTA, @ID_USUARIO,@ID_CLIENTE,@ID_REPUESTOS,@NRODOC,@ID_TIPODOC,@NRO_CF,@FECHAVENTA,@SUBTOTAL,@DESCUENTO,@IVA,@MONTOTOTAL) ", con))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlParameter[] sqlParameters =
                    {
                       new  SqlParameter("@ID_VENTA",ventas.ID_VENTA),new SqlParameter("@ID_USUARIO",ventas.ID_USUARIO)
                       ,new SqlParameter("@ID_CLIENTE", ventas.ID_CLIENTE) ,new SqlParameter("@ID_REPUESTOS", ventas.ID_REPUESTOS)
                       ,new SqlParameter("@NRODOC", ventas.NRODOC) ,new SqlParameter("@ID_TIPODOC", ventas.ID_TIPODOC)
                        ,new SqlParameter("@NRO_CF", ventas.NRO_CF) ,new SqlParameter("@FECHAVENTA", ventas.FECHA_VENTA)
                       ,new SqlParameter("@SUBTOTAL", ventas.SUBTOTAL) ,new SqlParameter("@DESCUENTO", ventas.DESCUENTO)
                       ,new SqlParameter("@IVA", ventas.IVA) ,new SqlParameter("@MONTOTOTAL", ventas.MONTOTOTAL)
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

        public static bool InsertarDetalle(DetalleVenta detallessventas)
        {
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("INSERT INTO DETALLEVENTAS (ID_DETALLEVENTA, ID_VENTA,ID_REPUESTO,CANTIDAD,PRECIOUNITARIO,SUBTOTALREPUESTO,DESCUENTO,IVA,TOTALREPUESTO) VALUES(@ID_DETALLEVENTA, @ID_VENTA,@ID_REPUESTO,@CANTIDAD,@PRECIOUNITARIO,@SUBTOTALREPUESTO,@DESCUENTO,@IVA,@TOTALREPUESTO) ", con))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlParameter[] sqlParameters =
                    {
                       new  SqlParameter("@ID_DETALLEVENTA",detallessventas.ID_DETALLEVENTA),new SqlParameter("@ID_VENTA",detallessventas.ID_VENTA)
                       ,new SqlParameter("@ID_REPUESTO", detallessventas.ID_REPUESTO) ,new SqlParameter("@CANTIDAD", detallessventas.CANTIDAD)
                       ,new SqlParameter("@PRECIOUNITARIO", detallessventas.PRECIOUNITARIO) ,new SqlParameter("@SUBTOTALREPUESTO", detallessventas.SUBTOTALREPUESTO)
                        ,new SqlParameter("@SUBTOTALREPUESTO", detallessventas.SUBTOTALREPUESTO) ,new SqlParameter("@DESCUENTO", detallessventas.DESCUENTO)
                        ,new SqlParameter("@IVA", detallessventas.IVA) ,new SqlParameter("@TOTALREPUESTO", detallessventas.TOTALREPUESTO)
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

        public static bool InsertarPago(Pagos pagos)
        {
            using (var con = Conexion.conectar())
            {
                using (var cmd = new SqlCommand("INSERT INTO PAGOS (ID_PAGO, ID_VENTA,TIPO,METODO,VALOR) VALUES(@ID_PAGO, @ID_VENTA,@TIPO,@METODO,@VALOR) ", con))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlParameter[] sqlParameters =
                    {
                       new  SqlParameter("@ID_PAGO",pagos.ID_PAGO),new SqlParameter("@ID_VENTA",pagos.ID_VENTA)
                       ,new SqlParameter("@TIPO", pagos.TIPO) ,new SqlParameter("@METODO", pagos.METODO)
                       ,new SqlParameter("@VALOR", pagos.VALOR) 
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
    }
}
