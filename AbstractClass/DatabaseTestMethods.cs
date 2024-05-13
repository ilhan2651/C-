using AbstractClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class BaseDb
    {
        public DataTable ExecuteSql(string sql)
        {
            // generate sql
            return new DataTable();
        }

        public abstract string GetDbVersion();
    }



    public class MySqlDb : BaseDb
    {
        public override string GetDbVersion() => "MySql  Server ";



    }



    class SqlServerDb : BaseDb
    {
        public override string GetDbVersion() => "SqlServer 2012";


        public string GenerateSql(int id)
        {
            return $"SELECT * FROM USERS WITH(NOLOCK) WHERE ID ={id}";


        }

    }

    public class OracleDb : BaseDb
    {
        public override string GetDbVersion() => "Oracle 18c";

        public string GenerateSql(int id)
        {
            return $"SELECT * FROM USERS WITH(NOLOCK) WHERE USER_ID ={id}";

        }


    }
    
}

       

