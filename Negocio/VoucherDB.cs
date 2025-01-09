using Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class VoucherDB
    {
        //Si es valido regresa true si no es valido o ya fue usado regresa false//
        public bool Validar(string voucher)
        {
            DataBase db = new DataBase();
            try
            {
                string consulta = "select FechaCanje from Vouchers where CodigoVoucher = '" + voucher + "'";
                db.setQuery(consulta);
                db.executeQuery();
                //Si el codigo es valido trae una consulta por lo que entra al if
                if (db.reader.Read())
                {
                    //Si no ha sido canjeado regresa una fecha de canje null y entra al if 
                    if (db.reader["FechaCanje"] == DBNull.Value)
                    {
                        //es valido y no ha sido canjeado
                        return true;
                    }
                }
                return false;
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

        public List<Voucher> listarCanjes( int id)
        {
            List<Voucher> list = new List<Voucher>();
            DataBase db = new DataBase();
            try
            {
                db.setQuery("select CodigoVoucher Codigo, FechaCanje, IdArticulo Articulo from Vouchers where IdCliente = @id");
                db.setParameter("@id", id);
                db.executeQuery();
                while (db.reader.Read())
                {
                    Voucher voucher = new Voucher();
                    voucher.Codigo = (string)db.reader["Codigo"];
                    voucher.FechaCanje = (DateTime)db.reader["FechaCanje"];
                    voucher.Articulo = (int)db.reader["Articulo"];
                    list.Add(voucher);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;

            }finally
            {
                db.CloseConecction();
            }
        }
        public void canjear(int idCliente, int nArticulo, string codigoVoucher)
        {
            DataBase conexion = new DataBase();
            try
            {
                conexion.setQuery("UPDATE Vouchers SET IdCliente = " + idCliente + ", FechaCanje = GETDATE() , IdArticulo = " + nArticulo + " WHERE CodigoVoucher = '" + codigoVoucher + "'");
                conexion.executeNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.CloseConecction();
            }
        }
        
    }
}
