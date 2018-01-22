using System.Data;

namespace SMLOGX.Core
{
    public interface IConnection
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