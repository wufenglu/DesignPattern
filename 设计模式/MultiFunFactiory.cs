using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计模式
{
    /// <summary>
    /// 简单工厂
    /// </summary>
    class MultiFunFactiory
    {
        public static SqlHelper GetSqlServerHelper()
        {
             return new SqlServerHelper();
        }
        public static SqlHelper GetMySqlHelper()
        {
            return new MySqlHelper();
        }
        public static SqlHelper GetOracleHelper()
        {
            return new OracleHelper();
        }
    }
    
}
