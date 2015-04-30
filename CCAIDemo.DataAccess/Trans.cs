using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace CCAIDemo.DataAccess
{
    public class Trans : IDisposable
    {
        private SqlConnection conn;
        private SqlTransaction sqlTrans;
        public SqlConnection SqlConnection
        {
            get { return this.conn; }
        }
        public SqlTransaction SqlTrans
        {
            get { return this.sqlTrans; }
        }

        public Trans()
        {
            conn = SqlHelper.CreateConnection();
            conn.Open();
            sqlTrans = conn.BeginTransaction();            
        }
      public Trans(string connectionString)
          {
              conn = SqlHelper.CreateConnection(connectionString);
            conn.Open();
            sqlTrans = conn.BeginTransaction();
        }

        public void Commit()
        {
            sqlTrans.Commit();
            this.Colse();
        }

        public void RollBack()
        {
            sqlTrans.Rollback();
            this.Colse();
        }

        public void Dispose()
        {
            this.Colse();
        }

        public void Colse()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
           
        }
    }
}