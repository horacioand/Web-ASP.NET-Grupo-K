using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
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
                db.Consulta(consulta);
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
    }
}
