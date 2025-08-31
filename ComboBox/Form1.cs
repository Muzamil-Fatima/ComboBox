using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Bind ComboBox with Enum
            comboBox1.DataSource = Enum.GetValues(typeof(Week));
            comboBox2.DataSource = Enum.GetValues(typeof(DayOfWeek));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(comboBox1.SelectedItem.ToString());
        }
        public enum Week
        {
            //fixed value 
            Sun , Mon , Tues, Wed ,Thurs , Fri , Sat
        }
        public enum DayOfWeek
        {
            Mon , Tue , Wed , Fri , Sat, Sun
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(comboBox2.SelectedItem.ToString());
        }
    }
}
