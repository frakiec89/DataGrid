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
            var vs = GetData(100000, -1, 1);


            dataGridView1.DataSource = vs; // источник данных ;

            dataGridView1.Columns[2].HeaderText = Resource1.Step; 


        }

        private List <Masssiv> GetData (double count , double  xIn , double xEnd)
        {
            var  step = (xEnd - xIn) / count;

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
