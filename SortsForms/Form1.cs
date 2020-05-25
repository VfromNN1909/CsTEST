using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            var arr = new int[10];
            for(int i = 0;i < arr.Length; i++)
            {
                arr[i] = random.Next(-20, 20);
            }
            textBoxNonSorted.Text = string.Join(" ", arr);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var arr = textBoxNonSorted.Text.Split(' ').Select(num => int.Parse(num)).ToArray();
            if(radioButtonMergeSort.Checked == true)
            {
                if(radioButtonAscending.Checked == true)
                {
                    Sorts.MergeSort(arr);
                    textBoxSorted.Text = string.Join(" ", arr);
                }
                if(radioButtonDescending.Checked == true)
                {
                    Sorts.MergeSort(arr);
                    Array.Reverse(arr);
                    textBoxSorted.Text = string.Join(" ", arr);
                }
            }
            if(radioButtonQuickSort.Checked == true)
            {
                if(radioButtonAscending.Checked == true)
                {
                    Sorts.QuickSort(arr);
                    textBoxSorted.Text = string.Join(" ", arr);
                }
                if (radioButtonDescending.Checked == true)
                {
                    Sorts.QuickSort(arr);
                    Array.Reverse(arr);
                    textBoxSorted.Text = string.Join(" ", arr);
                }
            }
        }
    }
}
