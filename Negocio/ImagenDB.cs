using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ImagenDB
    {
        public List<string> ListarImagenes(int id)
        {
            List<string> list = new List<string>();
            DataBase db = new DataBase();
            string consulta = "Select ImagenUrl from IMAGENES where IdArticulo = " + id;
            db.Consulta(consulta);
            while (db.reader.Read())
            {
                string url = (string)db.reader["ImagenUrl"];
                list.Add(url);
            }
            return list;
        }
    }
}
