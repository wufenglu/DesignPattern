using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计模式
{
    public interface ITargetable
    {

        /* 与原类中的方法相同 */
        void Method1();

        /* 新类的方法 */
        void Method2();
    }

    public class Source
    {

        public void Method1()
        {
            Console.Write("this is original method!");
        }
    }

    public class Adapter : Source, ITargetable
    {

        public void Method2()
        {
            Console.Write("this is the targetable method!");
        }
    }
}
