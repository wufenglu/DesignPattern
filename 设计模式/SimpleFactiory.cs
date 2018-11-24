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
    class SimpleFactiory
    {
        public static SqlHelper GetSqlHelper(SqlEnum sqlEnum)
        {
            SqlHelper helper = null;
            switch (sqlEnum)
            {
                case SqlEnum.SqlServer:
                    helper = new SqlServerHelper();
                    break;
                case SqlEnum.MySql:
                    helper = new MySqlHelper();
                    break;
                case SqlEnum.Oracle:
                    helper = new OracleHelper();
                    break;
            }
            return helper;
        }
    }
    
}
