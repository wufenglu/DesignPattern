using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计模式
{
    public class Source
    {

        public void method1()
        {
            Console.Write("this is original method!");
        }        
    }

    public interface Targetable
    {

        /* 与原类中的方法相同 */
        void method1();

        /* 新类的方法 */
        void method2();
    }

    public class Adapter : Source, Targetable
    {

        public void method2()
        {
            Console.Write("this is the targetable method!");
        }
    }
}
