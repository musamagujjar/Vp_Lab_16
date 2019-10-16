using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Lab_16
{
    public partial class Form1 : Form
    {
        DataTable dtname = new DataTable();
        DataTable dtcategory = new DataTable();

        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dtname.Columns.Add("Name");
            dtname.Columns.Add("Roll");
            dtname.Columns.Add("Department");
            dtname.Columns.Add("Semester");
            dtname.Columns.Add("Category");


            dtname.Rows.Add("Usama", "11421", "Engg" ,"6th" ,"A");
            dtname.Rows.Add("Ali", "11420", "Engg", "6th", "B");
            dtname.Rows.Add("Haider", "11422", "Engg", "6th", "C");
            dtname.Rows.Add("Shahnawaz", "11426", "Engg", "6th", "D");
            dtname.Rows.Add("Kabeer", "11424", "Engg", "6th", "E");
            dtname.Rows.Add("Awais", "11425", "Engg", "6th", "F");



            
         
            dataGridView1.DataSource = dtname;
        }

        

       /* private void button1_Click(object sender, EventArgs e)
        {
                   //dtname.DefaultView.RowFilter = "Name like '" + textBox1.Text + "%' and Category ='" + comboBox2 + "'";
        }*/

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            dtname.DefaultView.RowFilter = "Name like '" + textBox1.Text + "%' and Category ='" + comboBox2.SelectedItem + "'";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dtname.DefaultView.RowFilter = "Name like '" + textBox1.Text + "%'";
        }
    }
}
