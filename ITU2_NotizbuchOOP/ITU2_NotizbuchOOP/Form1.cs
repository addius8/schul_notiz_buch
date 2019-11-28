using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITU2_NotizbuchOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateErstellung_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void drpDwnKategorie_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        // private void btnSpeichern_Click(object sender, EventArgs e)
        private void btnSpeichern_notiz_Click(object sender, EventArgs e)
        {

            Console.WriteLine("Btn saved Event");
            string cu_title = titel_notiz.Text;
            string cu_priority = priority_notiz.Value.ToString();
            string category = kategorie_notiz.Text;
            string content = inhalt_notiz.Text;
            DateTime create_date = erstellung_notiz.Value;
            DateTime due_date = deadline_notiz.Value;
            Console.WriteLine("cu_title: " + cu_title);
            Console.WriteLine("cu_priority : " + cu_priority);
            Console.WriteLine("category : " + category);
            Console.WriteLine("create_date : " + create_date);
            Console.WriteLine("due_date : " + due_date);
            Console.WriteLine("content : " + content);

            IList<string> must_have_list = new List<string>();
            must_have_list.Add("cu_title");
            must_have_list.Add("category");


            int size_of_must_have_list = must_have_list.Count;
            for (int i = 0; i < size_of_must_have_list; i++)
            {
                Console.WriteLine(must_have_list[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void numPrioSuche_notiz_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        //private void btnSpeichern_notiz_Click(object sender, EventArgs e)
        //{
        //
        //}

        private void inhalt_notiz_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
