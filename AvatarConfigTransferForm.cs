using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AvatarConfigTransfer
{
    public partial class AvatarConfigTransferForm : Form
    {
        public AvatarConfigTransferForm()
        {
            InitializeComponent();
        }

        private void AvatarConfigTransferForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = $"{Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))}\\LocalLow\\VRChat\\VRChat\\LocalAvatarData";

            GetUsers();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetUsers();
        }

        private void GetUsers()
        {
            comboBox1.Items.Clear();

            if (Directory.Exists(textBox1.Text))
            {
                foreach (var userid in Directory.GetDirectories(textBox1.Text).Select(Path.GetFileName))
                {
                    comboBox1.Items.Add(userid);
                }
            }

            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(textBox2.Text))
            {
                MessageBox.Show("File Not Found!");
                return;
            }

            if (!Directory.Exists(textBox1.Text + "\\" + comboBox1.Text))
            {
                MessageBox.Show("Path Not Found!");
                return;
            }

            File.Copy(textBox2.Text, textBox1.Text + "\\" + comboBox1.Text + "\\" + Path.GetFileName(textBox2.Text), true);

            MessageBox.Show("Done!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(textBox1.Text + "\\" + comboBox1.Text))
            {
                MessageBox.Show("Path Not Found!");
                return;
            }

            Process.Start(textBox1.Text + "\\" + comboBox1.Text);
        }
    }
}
