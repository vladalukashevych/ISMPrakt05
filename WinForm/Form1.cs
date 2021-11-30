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

        int[] array = new int[100];
        int amount;

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

        private void buttonCreateArray_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            ButtonsVisibility();
            int ArrayLength = Convert.ToInt32(numericUpDownAmount.Value);
            int[] Array = ArrayAct.ArrayCreating(ArrayLength);
            dataGridViewArray.ColumnCount = ArrayLength;
            dataGridViewArray.RowCount = 1;
            for (int i = 0; i < ArrayLength; i++)
            {
                dataGridViewArray.Columns[i].HeaderText = i.ToString();
                dataGridViewArray[i,0].Value = Array[i];
            }
            array = Array;
            amount = ArrayLength;
        }

        private void buttonSumOfNegatives_Click(object sender, EventArgs e)
        {
            textBoxSumOfNegatives.Text = ArrayAct.SumOfNegatives(array, amount).ToString();
            textBoxSumOfNegatives.Visible = true;
        }

        private void buttonMaxOfEvenElements_Click(object sender, EventArgs e)
        {
            textBoxMaxOfEvenElements.Text = ArrayAct.MaxOfEvenElements(array, amount).ToString();
            textBoxMaxOfEvenElements.Visible = true;
        }

        private void buttonProductOfElements_Click(object sender, EventArgs e)
        {
            textBoxProductOfElements.Text = ArrayAct.ProductOfElements(array, amount).ToString();
            textBoxProductOfElements.Visible = true;
        }

        private void buttonIndexOfMaxElement_Click(object sender, EventArgs e)
        {
            textBoxIndexOfMaxElement.Text = ArrayAct.IndexOfMaxElement(array, amount).ToString();
            textBoxIndexOfMaxElement.Visible = true;
        }

        private void buttonMaxOfAbsoluteValues_Click(object sender, EventArgs e)
        {
            textBoxMaxOfAbsoluteValues.Text = ArrayAct.MaxOfAbsoluteValues(array, amount).ToString();
            textBoxMaxOfAbsoluteValues.Visible = true;
        }

        private void buttonSumOfPositivsIndexes_Click(object sender, EventArgs e)
        {
            textBoxSumOfPositivsIndexes.Text = ArrayAct.SumOfPositivsIndexes(array, amount).ToString();
            textBoxSumOfPositivsIndexes.Visible = true;
        }

        private void buttonAmountOfOddElements_Click(object sender, EventArgs e)
        {
            textBoxAmountOfOddElements.Text = ArrayAct.AmountOfOddElements(array, amount).ToString();
            textBoxAmountOfOddElements.Visible = true;
        }
    }
}
