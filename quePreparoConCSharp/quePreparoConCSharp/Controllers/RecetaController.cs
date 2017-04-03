using quePreparoConCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace quePreparoConCSharp.Controllers
{
    public class RecetaController : Controller
    {
        [HttpPost]
        //ACA CREO LA ACCION QUE ME VA A AYUDAR A BUSCAR EN LA BBDD, 
        //ME VA A DAR UNA LISTA CON LOS PARAMETROS DE LO QUE TENG QUE BUSCAR
        public ActionResult BuscarReceta(int a1, int a2, int a3, int a4, int a5, int a6, int a7, int a8, int a9, int a10, int a11, int a12, int a13, int a14, int a15, int a16, int a17, int a18, int a19, int a20, int a21, int a22, int a23, int a24, int a25, int a26, int a27, int a28, int a29, int a30, int a31, int a32, int a33, int a34, int a35, int a36, int a37, int a38, int a39, int a40, int a41, int a42, int a43, int a44, int a45, int a46, int a47, int a48)
        {
            List<int> listaIng = new List<int>();

            /*HAY QUE HACER UN IF POR CADA VALOR DE INT QUE HAY EN LA LISTA, ERGO POR CADA VALUE DEL FORM 
             O CADA INGREDIENTE DE MI BBDD, LLAMALO COMO QUIERAS*/



            if (a1 != 0)
            {
                listaIng.Add(a1);
            }
            if (a2 != 0)
            {
                listaIng.Add(a2);
            }
            if (a3 != 0)
            {
                listaIng.Add(a3);
            }
            if (a4 != 0)
            {
                listaIng.Add(a4);
            }
            if (a5 != 0)
            {
                listaIng.Add( a5);
            }
            if (a6 != 0)
            {
                listaIng.Add(a6);
            }
            if (a7 != 0)
            {
                listaIng.Add( a7);
            }
            if (a8 != 0)
            {
                listaIng.Add(8);
            }
            if (a9 != 0)
            {
                listaIng.Add(9);
            }
            if (a10 != 0)
            {
                listaIng.Add(10);
            }
            if (a11 != 0)
            {
                listaIng.Add(11);
            }
            if (a12 != 0)
            {
                listaIng.Add(12);
            }
            if (a13 != 0)
            {
                listaIng.Add(13);
            }
            if (a14 != 0)
            {
                listaIng.Add(14);
            }
            if (a15 != 0)
            {
                listaIng.Add(15);
            }
            if (a16 != 0)
            {
                listaIng.Add(16);
            }
            if (a17 != 0)
            {
                listaIng.Add(17);
            }
            if (a18 != 0)
            {
                listaIng.Add(18);
            }
            if (a19 != 0)
            {
                listaIng.Add(19);
            }
            if (a20 != 0)
            {
                listaIng.Add(20);
            }
            if (a21 != 0)
            {
                listaIng.Add(21);
            }
            if (a22 != 0)
            {
                listaIng.Add(a22);
            }
            if (a23 != 0)
            {
                listaIng.Add(a23);
            }
            if (a24 != 0)
            {
                listaIng.Add(a24);
            }
            if (a25 != 0)
            {
                listaIng.Add(a25);
            }
            if (a26 != 0)
            {
                listaIng.Add(a26);
            }
            if (a27 != 0)
            {
                listaIng.Add(a27);
            }
            if (a28 != 0)
            {
                listaIng.Add(a28);
            }
            if (a29 != 0)
            {
                listaIng.Add(a29);
            }
            if (a30 != 0)
            {
                listaIng.Add(a30);
            }
            if (a31 != 0)
            {
                listaIng.Add(a31);
            }
            if (a32 != 0)
            {
                listaIng.Add(a32);
            }
            if (a33 != 0)
            {
                listaIng.Add(a33);
            }
            if (a34 != 0)
            {
                listaIng.Add(a34);
            }
            if (a35 != 0)
            {
                listaIng.Add(a35);
            }
            if (a36 != 0)
            {
                listaIng.Add(a36);
            }
            if (a37 != 0)
            {
                listaIng.Add(a37);
            }
            if (a38 != 0)
            {
                listaIng.Add(a38);
            }
            if (a39 != 0)
            {
                listaIng.Add(a39);
            }
            if (a40 != 0)
            {
                listaIng.Add( a40);
            }
            if (a41 != 0)
            {
                listaIng.Add( a41);
            }
            if (a42 != 0)
            {
                listaIng.Add( a42);
            }
            if (a43 != 0)
            {
                listaIng.Add( a43);
            }
            if (a44 != 0)
            {
                listaIng.Add( a44);
            }
            if (a45 != 0)
            {
                listaIng.Add( a45);
            }
            if (a46 != 0)
            {
                listaIng.Add( a46);
            }
            if (a47 != 0)
            {
                listaIng.Add( a47);
            }
            if (a48 != 0)
            {
                listaIng.Add( a48);
            }

//ESTA ES LA LISTA DE LO QUE SI TENGO EN MI HELADERA, ERGO, SON LOS INGRADIENTES A BUSCAR
   

            /*SE CREA UN MANAGER PARA MANEJAR LA CONSULTA*/

            MiManager Mimanager = new MiManager();

            return RedirectToAction("Resultado", "Receta");

        }
    }
}