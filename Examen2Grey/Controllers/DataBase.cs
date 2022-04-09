using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Examen2Grey.Models;
using System.Threading.Tasks;


namespace Examen2Grey.Controllers
{
    public class DataBase
    {
        public static SQLiteAsyncConnection dbconexion;
        public static void Conexion(string dbpath)
        {
            dbconexion = new SQLiteAsyncConnection(dbpath);
            dbconexion.CreateTableAsync<Pagos>();
          
        }
        public static Task<List<Pagos>> ObtenerListaPagos()
        {
            return dbconexion.Table<Pagos>().ToListAsync();
        }
        public static Task<int> AddPagos(Pagos pagos)
        {
            if (pagos.Id != 0)
            {
                return dbconexion.UpdateAsync(pagos);
            }
            else
            {
                return dbconexion.InsertAsync(pagos);
            }
        }

        public static Task<int> UpdatePagos(Pagos pagos)
        {
            return dbconexion.UpdateAsync(pagos);
        }

        public static Task<Pagos> ObtenerPagos(int pid)
        {
            return dbconexion.Table<Pagos>()
                .Where(i => i.Id == pid)
                .FirstOrDefaultAsync();
        }
        public static Task<int> DelPagos(Pagos pagos)
        {
            return dbconexion.DeleteAsync(pagos);
        }
       
    }
}

