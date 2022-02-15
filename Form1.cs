using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace labor_ggrigorjev
{
    public partial class Form1 : Form
    {
        
        OpenFileDialog OpenDig = new OpenFileDialog();
        SaveFileDialog SaveDig = new SaveFileDialog();
       

        public Form1()
        {
            InitializeComponent();


        }

        
            
       
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenDig.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(OpenDig.FileName, Encoding.Default);
                rich1.Text = Reader.ReadToEnd();
                Reader.Close();
            }
            OpenDig.Dispose();

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveDig.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(SaveDig.FileName);
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    Writer.WriteLine((string)listBox2.Items[i]);
                }
                Writer.Close();
            }
            SaveDig.Dispose();

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
