using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 设计模式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SimpleFactiory.GetSqlHelper(SqlEnum.SqlServer).Insert();

            IMessage message = new ProxyMessage();
            message.Send();

            Task task1 = new Task(() => {
                SingletonPattern singletonPattern = SingletonPattern.GetInstall();
                singletonPattern.AppendText("AAA");
            });
            task1.Start();

            Task task2 = new Task(() => {
                SingletonPattern singletonPattern = SingletonPattern.GetInstall();
                singletonPattern.AppendText("BBB");
            });
            task2.Start();

            Task task3 = new Task(() => {
                SingletonPattern singletonPattern = SingletonPattern.GetInstall();
                singletonPattern.AppendText("CCC");
            });
            task3.Start();
        }
    }
}
