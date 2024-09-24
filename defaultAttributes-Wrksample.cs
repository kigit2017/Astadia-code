using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Permissions;
using System.Xml;
using System.Windows.Forms;

namespace Designer
{
    public partial class defaultAttributes : Form
    {
        public defaultAttributes()
        {
            InitializeComponent();

            defaultAttributes_Load(this, EventArgs.Empty);
        }
        public void defaultAttributes_Load(object sender, EventArgs e)
        {

            Show();
            this.panel4.Visible = false;
            this.panel2.Visible = false;

            this.panel1.BringToFront();
            this.panel2.SendToBack();
            this.panel4.SendToBack();
            
            this.panel1.Visible = true;
            this.button3.BringToFront();
            this.button4.BringToFront();
            this.button5.BringToFront();
            // this.panel1.Show();
            //  this.panel1.Controls.Remove(label1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //  this.panel1.Controls.Add(label1);


            this.panel4.Visible = false;
            this.panel2.Visible = false;

            this.panel1.BringToFront();
            this.panel2.SendToBack();
            this.panel4.SendToBack();

            this.panel1.Visible = true;
            this.button3.BringToFront();
            this.button4.BringToFront();
            this.button5.BringToFront();
            // this.panel1.Show();

            this.button3.BringToFront();
            this.button4.BringToFront();
            this.button5.BringToFront();

            //  this.panel1.Show();
            listBox1.SetSelected(0, true);
            listBox2.SetSelected(0, true);
            listBox3.SetSelected(0, true);
            listBox4.SetSelected(0, true);
            listBox5.SetSelected(0, true);
            listBox6.SetSelected(0, true);



            //this.ResumeLayout(false);
            textBox1.Focus();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.panel2.Visible = true;
            this.panel1.SendToBack();
            this.panel4.SendToBack();

            this.panel2.BringToFront();
            //this.panel4.ResumeLayout(false);
            this.button3.BringToFront();
            this.button4.BringToFront();
            this.button5.BringToFront();

            //this.ResumeLayout(false);
            
            textBox1.Focus();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
      
           this.panel4.Visible = true;
            this.panel1.SendToBack();
            this.panel2.SendToBack();

            this.panel4.BringToFront();
            //this.panel4.ResumeLayout(false);
            this.button3.BringToFront();
            this.button4.BringToFront();
            this.button5.BringToFront();
           // this.panel4.Show();
        }



        private void button7_Click(object sender, EventArgs e)//panel save
        {
            var projectPath = "K:\\Work\\Kay\\OS2200 Designer\\1-23"; // Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)));
            string defaultpath = string.Empty;
            projectPath = projectPath.Replace("file:\\", string.Empty);
            defaultpath = projectPath + "\\DPSDefault.xml";
            string temp = projectPath + "\\temp.xml";
            File.Copy(defaultpath,  temp,true);

            XmlDocument doc = new XmlDocument();
            doc.Load( temp);
            XmlNode root = doc.DocumentElement;
            //Tab3
            root.SelectSingleNode("/formdefault").Attributes.Item(0).Value = textBox16.Text ;
            root.SelectSingleNode("/formdefault").Attributes.Item(1).Value = textBox15.Text;
            root.SelectSingleNode("/formdefault").Attributes.Item(2).Value = textBox25.Text;
            root.SelectSingleNode("/formdefault/edit_symbol/decimal_point").InnerText = textBox26.Text;
            root.SelectSingleNode("/formdefault/edit_symbol/comma").InnerText = textBox27.Text;

            doc.Save(temp);


            SaveFileDialog tab1Save = new SaveFileDialog();
            tab1Save.FileName = "DPSDefault.xml";
            try
            {
                if (tab1Save.ShowDialog() == DialogResult.OK)
                {
                    doc.Save(tab1Save.FileName);

                }
            }
            catch
            {


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var projectPath = "K:\\Work\\Kay\\OS2200 Designer\\1-23";//Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)));
            string defaultpath = string.Empty;
            projectPath = projectPath.Replace("file:\\", string.Empty);
            defaultpath = projectPath + "\\DPSDefault.xml";
            string temp = projectPath + "\\temp.xml";
            File.Copy(defaultpath, temp, true);

            XmlDocument doc = new XmlDocument();
            doc.Load(temp);
            XmlNode root = doc.DocumentElement;

            //Tab1
          
            root.SelectSingleNode("/formdefault/cursor/image_name").InnerText = textBox1.Text;
            root.SelectSingleNode("/formdefault/security/level").InnerText = textBox2.Text;
            root.SelectSingleNode("/formdefault/security/type").InnerText = listBox6.Text;
            root.SelectSingleNode("/formdefault/dimension/height").InnerText = textBox4.Text;
            root.SelectSingleNode("/formdefault/storage/generate_prefix").InnerText = listBox1.Text;
            root.SelectSingleNode("/formdefault/checknumber_test/set_mode").InnerText = listBox2.Text;
            root.SelectSingleNode("/formdefault/conversation/set_mode").InnerText = listBox3.Text;
            root.SelectSingleNode("/formdefault/test/set_mode").InnerText = listBox5.Text;
            root.SelectSingleNode("/formdefault/function_keys/name").InnerText = textBox10.Text;



            doc.Save(temp);


            SaveFileDialog tab1Save = new SaveFileDialog();
            tab1Save.FileName = "DPSDefault.xml";
            try
            {
                if (tab1Save.ShowDialog() == DialogResult.OK)
                {

                    doc.Save(tab1Save.FileName);
                }
            }
            catch
            {


            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var projectPath = "K:\\Work\\Kay\\OS2200 Designer\\1-23";//Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)));
            string defaultpath = string.Empty;
            projectPath = projectPath.Replace("file:\\", string.Empty);
            defaultpath = projectPath + "\\DPSDefault.xml";
            string temp = projectPath + "\\temp.xml";
            File.Copy(defaultpath, temp, true);

            XmlDocument doc = new XmlDocument();
            doc.Load(temp);
            XmlNode root = doc.DocumentElement;
            //Tab2
            root.SelectSingleNode("/formdefault/background_attributes/color").InnerText = textBox3.Text;//background color
            root.SelectSingleNode("/formdefault/foreground_attributes/color").InnerText = textBox5.Text;//foreground color
            root.SelectSingleNode("/formdefault/foreground_attributes/intensity").InnerText = textBox6.Text;//intensity
            root.SelectSingleNode("/formdefault/highlight/type").InnerText = textBox7.Text;//highlight
            root.SelectSingleNode("/formdefault/emphasis/type").InnerText = textBox8.Text;//
            root.SelectSingleNode("/formdefault/character_attributes/font_index").InnerText = textBox9.Text;//
            root.SelectSingleNode("/formdefault/input_attributes/control_characters_allowed").InnerText = textBox11.Text;//

            doc.Save(temp);


            SaveFileDialog tab1Save = new SaveFileDialog();
            tab1Save.FileName = "DPSDefault.xml";
            try
            {
                if (tab1Save.ShowDialog() == DialogResult.OK)
                {

                    doc.Save(tab1Save.FileName);
                }
            }
            catch
            {


            }
        }

        private void button9_Click(object sender, EventArgs e)//canceltab2
        {

        }
    }
}
