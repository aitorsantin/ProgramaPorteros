using Datos.Conexion;
using Datos.Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using System.Windows.Forms;

namespace Datos.DA_Porteros
{
    public class DA_AltaPortero
    {
        private readonly IDA_Conexion _dA_Conexion;
        
        SqlCommand cmd = new SqlCommand();
        SqlConnection conexion = new SqlConnection();

        public DA_AltaPortero(IDA_Conexion dA_Conexion)
        {
            this._dA_Conexion = dA_Conexion;
        }

        public void CrearNuevoPortero(Portero portero)
        {
            try
            {
                using(var tr = new TransactionScope())
                {
                    cmd.CommandText = Helper.Constantes.PR_NuevoPortero;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", portero.Nombre);
                    cmd.Parameters.AddWithValue("@ap", portero.Apellido);
                    cmd.Parameters.AddWithValue("@segundo", portero.SegundoAp);
                    cmd.Parameters.AddWithValue("@edad", portero.Edad);
                    cmd.Parameters.AddWithValue("@fecha", portero.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@lugar", portero.Lugar);
                    cmd.Parameters.AddWithValue("@pais", portero.Pais);
                    cmd.Parameters.AddWithValue("@pasaporte", portero.Pasaporte);
                    cmd.Parameters.AddWithValue("@nacionalidad", portero.Nacionalidad);
                    conexion = _dA_Conexion.DA_Conectar();
                    cmd.Connection = conexion;
                    cmd.ExecuteNonQuery();
                    tr.Complete();
                    conexion.Close();
                }
                
            }
            catch (SqlException ex)
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error al intentar crear el nuevo portero", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
