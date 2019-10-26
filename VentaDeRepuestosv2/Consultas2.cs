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
    }
}
