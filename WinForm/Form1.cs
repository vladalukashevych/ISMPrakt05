using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        void ClearTextBoxes()
        {
            textBoxAmountOfOddElements.Clear();
            textBoxIndexOfMaxElement.Clear();
            textBoxMaxOfAbsoluteValues.Clear();
            textBoxMaxOfEvenElements.Clear();
            textBoxProductOfElements.Clear();
            textBoxSumOfNegatives.Clear();
            textBoxSumOfPositivsIndexes.Clear();
        }
        void ButtonsVisibility()
        {
            buttonAmountOfOddElements.Visible = true;
            buttonIndexOfMaxElement.Visible = true;
            buttonMaxOfAbsoluteValues.Visible = true;
            buttonMaxOfEvenElements.Visible = true;
            buttonProductOfElements.Visible = true;
            buttonSumOfNegatives.Visible = true;
            buttonSumOfPositivsIndexes.Visible = true;
        }

        int[] Array;
        private void buttonCreateArray_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            ButtonsVisibility();
            Array = ArrayAct.ArrayCreating(Convert.ToInt32(numericUpDownAmount.Value));
            dataGridViewArray.ColumnCount = Array.Length;
            dataGridViewArray.RowCount = 1;
            for (int i = 0; i < Array.Length; i++)
            {
                dataGridViewArray.Columns[i].HeaderText = i.ToString();
                dataGridViewArray[i,0].Value = Array[i];
            }
        }

        private void buttonSumOfNegatives_Click(object sender, EventArgs e)
        {
            textBoxSumOfNegatives.Text = ArrayAct.SumOfNegatives(Array).ToString();
            textBoxSumOfNegatives.Visible = true;
        }

        private void buttonMaxOfEvenElements_Click(object sender, EventArgs e)
        {
            textBoxMaxOfEvenElements.Text = ArrayAct.MaxOfEvenElements(Array).ToString();
            textBoxMaxOfEvenElements.Visible = true;
        }

        private void buttonProductOfElements_Click(object sender, EventArgs e)
        {
            textBoxProductOfElements.Text = ArrayAct.ProductOfElements(Array).ToString();
            textBoxProductOfElements.Visible = true;
        }

        private void buttonIndexOfMaxElement_Click(object sender, EventArgs e)
        {
            textBoxIndexOfMaxElement.Text = ArrayAct.IndexOfMaxElement(Array).ToString();
            textBoxIndexOfMaxElement.Visible = true;
        }

        private void buttonMaxOfAbsoluteValues_Click(object sender, EventArgs e)
        {
            textBoxMaxOfAbsoluteValues.Text = ArrayAct.MaxOfAbsoluteValues(Array).ToString();
            textBoxMaxOfAbsoluteValues.Visible = true;
        }

        private void buttonSumOfPositivsIndexes_Click(object sender, EventArgs e)
        {
            textBoxSumOfPositivsIndexes.Text = ArrayAct.SumOfPositivsIndexes(Array).ToString();
            textBoxSumOfPositivsIndexes.Visible = true;
        }

        private void buttonAmountOfOddElements_Click(object sender, EventArgs e)
        {
            textBoxAmountOfOddElements.Text = ArrayAct.AmountOfOddElements(Array).ToString();
            textBoxAmountOfOddElements.Visible = true;
        }
    }
}
