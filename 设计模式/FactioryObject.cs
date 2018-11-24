using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计模式
{
    public enum SqlEnum {
        SqlServer = 1,
        MySql = 2,
        Oracle = 3
    }

    public interface SqlHelper {
        void Insert();
    }

    public class SqlServerHelper : SqlHelper {
        public void Insert() {
            Console.Write("SqlServerHelper");
        }
    }
    public class MySqlHelper : SqlHelper
    {
        public void Insert()
        {
            Console.Write("MySqlHelper");
        }
    }
    public class OracleHelper : SqlHelper
    {
        public void Insert()
        {
            Console.Write("OracleHelper");
        }
    }
}
