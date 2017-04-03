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
        public List<Receta> BuscarRecetas(List <int>listaIng)

        {
            List<Receta> recetas = new List<Receta>();

            //BUSCO CONECTARME A LA BBDD
            SqlConnection conexion = new SqlConnection(ConfigurationManager.AppSettings["conexionBaseDeDatos"]);
            //ABRO UNA CONEXION
            conexion.Open();
            //CREO COMANDO PARA PODER CONSULTAR LA BBDD
            SqlCommand sentencia = conexion.CreateCommand();
            //LE DOY LOS PARAMETROS DE BUSCA A LA SENTENCIA
            sentencia.CommandText = "SELECT id_receta FROM ingredientes_receta INNER JOIN receta ON (ingredientes_receta.id_receta = receta.id) WHERE id_ingrediente IN (1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,23,22,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43)";

            //sentencia.CommandText += "5,)";
            
              //EJECUTO LA CONSULTA
              SqlDataReader reader = sentencia.ExecuteReader();
            if (reader.Read()) //SI HAY ALGO PARA LEER LO VA A LEER, SINO NO
            {
                Receta receta = new Receta();
                //COMPLETO LOS DATOS                 
                receta.Titulo = reader["Titulo"].ToString();
                receta.Texto = (string)reader["Texto"];
                
            }

            //CERRAR EL READER AL TERMINAR DE LEER LOS REGISTROS
            reader.Close();
            //CERRAR LA CONEXION AL TERMINAR!!!!
            conexion.Close();

            return recetas;
        }
    


          
    }
}