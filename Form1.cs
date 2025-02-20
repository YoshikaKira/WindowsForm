﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        FilterFactory factory;
        OpenFileDialog openFileDialog;
        public Form1()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            factory = new FilterFactory();
            listBox1.DataSource = factory.GetNames();
        }
        Bitmap bitmap;
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JPG|*.jpg|all|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmap = new Bitmap(openFileDialog.FileName);
                pictureBox1.Image = bitmap;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (bitmap != null && listBox1.SelectedIndex >= 0)
            {
                bitmap = factory.ApplyFilter(listBox1.SelectedIndex, bitmap);
                pictureBox1.Image = bitmap;
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1_DoubleClick(pictureBox1, new EventArgs());
        }

        private void откатитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(openFileDialog.FileName);
            pictureBox1.Image = bitmap;
        }
    }
}
