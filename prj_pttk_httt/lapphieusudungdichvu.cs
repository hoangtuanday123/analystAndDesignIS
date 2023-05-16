using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DA_PTTK
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        private string[,] myArray;

        public Form2(string[,] array)
        {
            InitializeComponent();
            myArray = array;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int columnCount = myArray.GetLength(1);
            int rowCount = myArray.GetLength(0);
            string[] row = new string[columnCount];
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    row[j] = myArray[i, j];
                }
                dataGridView1.Rows.Add(row);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        

    }
}
