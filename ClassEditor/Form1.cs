using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassEditor
{
    public partial class Form1 : Form
    {
        Object obj;
        public Form1(Object obj)
        {
            this.obj = obj;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LabelNameClass.Text = obj.GetType().ToString();
            PropertyInfo[] properties = obj.GetType().GetProperties();

            TableLayoutPanel Table = new TableLayoutPanel();
            Table.Location = new Point(40, 80);
            Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            Table.TabIndex = 2;
            Table.AutoSize = true;
            Controls.Add(Table);


            for (int i = 0; i < properties.Count(); i++)
            {
                var prop = properties.ElementAt(i);

                int j = i+1;
                Table.Controls.Add(new Label() { Text = prop.Name }, 1, j);

                if (prop.PropertyType == typeof(String))
                {
                    TextBox textbox = new TextBox() { Name = prop.Name};

                    textbox.TextChanged += new System.EventHandler(Textbox_TextChanged);
                    
                    Table.Controls.Add(textbox, 2, j);          
                }

                else if (prop.PropertyType == typeof(Int32))
                {
                    NumericUpDown numeric = new NumericUpDown() { Name = prop.Name };

                    numeric.ValueChanged += new System.EventHandler(Numeric_ValueChanger);
                    Table.Controls.Add(numeric , 2, j );
                }

            }
        }


        private void Textbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Numeric_ValueChanger(object sender,EventArgs e)
        {

        }
    }

}








