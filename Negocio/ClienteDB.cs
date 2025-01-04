﻿using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteDB
    {
        public List<Cliente> listarCliente()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            DataBase db = new DataBase();
            try
            {
                string consulta = "SELECT Id, Documento,Nombre,Apellido, Email, Direccion, Ciudad, Cp FROM Clientes";
                db.setQuery(consulta);
                db.executeQuery();
                while (db.reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = (int)db.reader["Id"];
                    cliente.Documento = (string)db.reader["Documento"];
                    cliente.Nombre = (string)db.reader["Nombre"];
                    cliente.Apellido = (string)db.reader["Apellido"];
                    cliente.Email = (string)db.reader["Email"];
                    cliente.Direccion = (string)db.reader["Direccion"];
                    cliente.Ciudad = (string)db.reader["Ciudad"];
                    cliente.Cp = (int)db.reader["Cp"];
                    listaClientes.Add(cliente);
                }
                return listaClientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.CloseConecction();
            }
        }
        //todavia no probe si funciona correctamente
        public void ingresarCliente(Cliente cliente)
        {
            DataBase db = new DataBase();
            try
            {
                db.setQuery("INSERT INTO Clientes (Id, Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) VALUES (@id, @documento, @nombre, @apellido, @email, @direccion, @ciudad, @cp)");
                
                db.setParameter("@id", cliente.Id);
                db.setParameter("@documento", cliente.Documento);
                db.setParameter("@nombre", cliente.Nombre);
                db.setParameter("@apellido", cliente.Apellido);
                db.setParameter("@email", cliente.Email);
                db.setParameter("@direccion", cliente.Direccion);
                db.setParameter("@ciudad", cliente.Ciudad);
                db.setParameter("@cp", cliente.Cp);
               
                db.executeNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.CloseConecction();
            }
        }
    }
}
