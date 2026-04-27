using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ŞİRKETOTOMASYONU
{
    internal class SqlBaglanti
    {
        private static SqlConnection _baglan = null;

        public SqlConnection baglanti()
        {
            if (_baglan == null)
            {
                _baglan = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBOSIRKETOTOMASYON;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=True");
            }
            
            if (_baglan.State != System.Data.ConnectionState.Open)
            {
                _baglan.Open();
            }
            
            return _baglan;
        }
    }
}
