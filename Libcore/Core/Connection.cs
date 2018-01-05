using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCare.Core
{
    public class Connection : BaseConnection
    {
        public bool CreateDB(string dbname)
        {
            throw new NotImplementedException();
        }

        public bool CreateTable(string tblname)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string cluase)
        {
            throw new NotImplementedException();
        }

        public bool Insert(object data)
        {
            throw new NotImplementedException();
        }

        public bool OpenConnection(object conString)
        {
            throw new NotImplementedException();
        }

        public DataTable QueryModel(string sql)
        {
            throw new NotImplementedException();
        }

        public object QueryScalar(string sql)
        {
            throw new NotImplementedException();
        }

        public bool Update(object data, string cluase)
        {
            throw new NotImplementedException();
        }
    }
}