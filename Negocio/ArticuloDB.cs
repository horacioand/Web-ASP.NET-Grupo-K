﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloDB
    {
        public List<Articulo> ListarArticulos() 
        { 
            List<Articulo> list = new List<Articulo>();
            DataBase db = new DataBase();
            string consulta = "Select A.Id, Codigo, Nombre, A.Descripcion, IdMarca, M.Descripcion Marca, IdCategoria, C.Descripcion Categoria, Precio from ARTICULOS A inner join MARCAS M on A.IdMarca = M.Id inner join CATEGORIAS C on A.IdCategoria = C.Id";
            db.setQuery(consulta);
            db.executeQuery();
            while (db.reader.Read())
            {
                Articulo a = new Articulo();
                a.Id = (int)db.reader["Id"];
                a.Codigo = (string)db.reader["Codigo"];
                a.Nombre = (string)db.reader["Nombre"];
                a.Descripcion = (string)db.reader["Descripcion"];
                Marca m = new Marca();
                m.Id = (int)db.reader["IdMarca"];
                m.Nombre = (string)db.reader["Marca"];
                a.Marca = m;
                Categoria c = new Categoria();
                c.Id = (int)db.reader["IdCategoria"];
                c.Nombre = (string)db.reader["Categoria"];
                a.Categoria = c;
                a.Precio = (decimal)db.reader["Precio"];
                a.listImagenes = ListarImagenes(a.Id);
                list.Add(a);
            }
            db.CloseConecction();
            return list;           
        }

        public List<string> ListarImagenes(int id)
        {
            List<string> list = new List<string>();
            DataBase db = new DataBase();
            string consulta = "Select ImagenUrl from IMAGENES where IdArticulo = " + id;
            db.setQuery(consulta);
            db.executeQuery();
            while (db.reader.Read())
            {
                string url = (string)db.reader["ImagenUrl"];
                list.Add(url);
            }
            return list;
        }
    }
}
