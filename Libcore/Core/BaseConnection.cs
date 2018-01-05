using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCare.Core
{
    public interface BaseConnection
    {
        /** DML Statements **/

        bool Insert(object data);

        bool Update(object data, string cluase);

        bool Delete(string cluase);

        /** Connections **/

        bool OpenConnection(object conString);

        /** Database **/

        bool CreateDB(string dbname);

        bool CreateTable(string tblname);

        DataTable QueryModel(string sql);

        object QueryScalar(string sql);
    }
}