using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace quePreparoConCSharp.Models
{//CON ESTE MANAGER VOY A MANEJAR LAS RECETAS
    public class MiManager
    {
        public Mostrar Reseta (listaIng)

        {
            Receta receta = new Receta();

            //BUSCO CONECTARME A LA BBDD
            SqlConnection conexion = new SqlConnection(ConfigurationManager.AppSettings["conexionBaseDeDatos"]);
            //ABRO UNA CONEXION
            conexion.Open();
            //CREO COMANDO PARA PODER CONSULTAR LA BBDD
            SqlCommand sentencia = conexion.CreateCommand();
            //LE DOY LOS PARAMETROS DE BUSCA A LA SENTENCIA
            sentencia.CommandText = "SELECT id_receta FROM ingredientes_receta WHERE Id = @Id";
            sentencia.Parameters.AddWithValue("@Id", ID);
            //EJECUTO LA CONSULTA
            SqlDataReader reader = sentencia.ExecuteReader();
            if (reader.Read()) //SI HAY ALGO PARA LEER LO VA A LEER, SINO NO
            {
                //COMPLETO LOS DATOS                 
                receta.Titulo = reader["Titulo"].ToString();
                receta.Texto = (string)reader["Texto"];
                
            }

            //CERRAR EL READER AL TERMINAR DE LEER LOS REGISTROS
            reader.Close();
            //CERRAR LA CONEXION AL TERMINAR!!!!
            conexion.Close();

            return receta;
        }



            viewbag = Receta;

           return View("Resultado", "Receta");
    }
}