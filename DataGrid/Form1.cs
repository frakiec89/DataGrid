using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGo_Click(object sender, EventArgs e) // start
        {
            dataGridView1.Columns.Add("y", "y");
            dataGridView1.Columns.Add("x", "x");
            dataGridView1.Columns.Add("step", "шаг");

            var vs = GetData(10 , -1 ,1);

            foreach ( var  item in  vs)
            {
                dataGridView1.Rows.Add(item.Y, item.X, item.Step);
            }

        }

        private List <Masssiv> GetData (double step , double  xIn , double xEnd)
        {
            step = (xEnd - xIn) / step;

            List<Masssiv> vs = new List<Masssiv>();

            for  (double i = xIn; i<= xEnd; i+=step  )
            {
                vs.Add(new Masssiv { Y=i * i, X=i, Step=step   }); 
            }
            return vs;
        }
    }

    public  struct Masssiv
    {
        public double Y { get; set; }
        public double X { get; set; }
        public double Step { get; set; }
    }
}
