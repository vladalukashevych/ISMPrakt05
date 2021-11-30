
namespace WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAmount = new System.Windows.Forms.Label();
            this.dataGridViewArray = new System.Windows.Forms.DataGridView();
            this.buttonCreateArray = new System.Windows.Forms.Button();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.buttonSumOfNegatives = new System.Windows.Forms.Button();
            this.textBoxSumOfNegatives = new System.Windows.Forms.TextBox();
            this.buttonMaxOfEvenElements = new System.Windows.Forms.Button();
            this.buttonProductOfElements = new System.Windows.Forms.Button();
            this.buttonIndexOfMaxElement = new System.Windows.Forms.Button();
            this.buttonMaxOfAbsoluteValues = new System.Windows.Forms.Button();
            this.buttonSumOfPositivsIndexes = new System.Windows.Forms.Button();
            this.buttonAmountOfOddElements = new System.Windows.Forms.Button();
            this.textBoxAmountOfOddElements = new System.Windows.Forms.TextBox();
            this.textBoxSumOfPositivsIndexes = new System.Windows.Forms.TextBox();
            this.textBoxMaxOfAbsoluteValues = new System.Windows.Forms.TextBox();
            this.textBoxIndexOfMaxElement = new System.Windows.Forms.TextBox();
            this.textBoxProductOfElements = new System.Windows.Forms.TextBox();
            this.textBoxMaxOfEvenElements = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmount.Location = new System.Drawing.Point(14, 22);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(218, 18);
            this.labelAmount.TabIndex = 0;
            this.labelAmount.Text = "The amount of array elements =";
            // 
            // dataGridViewArray
            // 
            this.dataGridViewArray.AllowUserToAddRows = false;
            this.dataGridViewArray.AllowUserToDeleteRows = false;
            this.dataGridViewArray.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArray.Location = new System.Drawing.Point(-4, 76);
            this.dataGridViewArray.Name = "dataGridViewArray";
            this.dataGridViewArray.RowHeadersWidth = 51;
            this.dataGridViewArray.RowTemplate.Height = 24;
            this.dataGridViewArray.Size = new System.Drawing.Size(991, 165);
            this.dataGridViewArray.TabIndex = 2;
            // 
            // buttonCreateArray
            // 
            this.buttonCreateArray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateArray.Location = new System.Drawing.Point(555, 20);
            this.buttonCreateArray.Name = "buttonCreateArray";
            this.buttonCreateArray.Size = new System.Drawing.Size(363, 31);
            this.buttonCreateArray.TabIndex = 3;
            this.buttonCreateArray.Text = "Create Array";
            this.buttonCreateArray.UseVisualStyleBackColor = true;
            this.buttonCreateArray.Click += new System.EventHandler(this.buttonCreateArray_Click);
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Location = new System.Drawing.Point(250, 22);
            this.numericUpDownAmount.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(123, 22);
            this.numericUpDownAmount.TabIndex = 4;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // buttonSumOfNegatives
            // 
            this.buttonSumOfNegatives.Location = new System.Drawing.Point(56, 257);
            this.buttonSumOfNegatives.Name = "buttonSumOfNegatives";
            this.buttonSumOfNegatives.Size = new System.Drawing.Size(176, 41);
            this.buttonSumOfNegatives.TabIndex = 5;
            this.buttonSumOfNegatives.Text = "Sum of negatives";
            this.buttonSumOfNegatives.UseVisualStyleBackColor = true;
            this.buttonSumOfNegatives.Visible = false;
            this.buttonSumOfNegatives.Click += new System.EventHandler(this.buttonSumOfNegatives_Click);
            // 
            // textBoxSumOfNegatives
            // 
            this.textBoxSumOfNegatives.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxSumOfNegatives.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxSumOfNegatives.Location = new System.Drawing.Point(273, 266);
            this.textBoxSumOfNegatives.Name = "textBoxSumOfNegatives";
            this.textBoxSumOfNegatives.ReadOnly = true;
            this.textBoxSumOfNegatives.Size = new System.Drawing.Size(116, 22);
            this.textBoxSumOfNegatives.TabIndex = 6;
            this.textBoxSumOfNegatives.Visible = false;
            // 
            // buttonMaxOfEvenElements
            // 
            this.buttonMaxOfEvenElements.Location = new System.Drawing.Point(56, 333);
            this.buttonMaxOfEvenElements.Name = "buttonMaxOfEvenElements";
            this.buttonMaxOfEvenElements.Size = new System.Drawing.Size(176, 41);
            this.buttonMaxOfEvenElements.TabIndex = 7;
            this.buttonMaxOfEvenElements.Text = "Max of even elements";
            this.buttonMaxOfEvenElements.UseVisualStyleBackColor = true;
            this.buttonMaxOfEvenElements.Visible = false;
            this.buttonMaxOfEvenElements.Click += new System.EventHandler(this.buttonMaxOfEvenElements_Click);
            // 
            // buttonProductOfElements
            // 
            this.buttonProductOfElements.Location = new System.Drawing.Point(56, 407);
            this.buttonProductOfElements.Name = "buttonProductOfElements";
            this.buttonProductOfElements.Size = new System.Drawing.Size(176, 53);
            this.buttonProductOfElements.TabIndex = 8;
            this.buttonProductOfElements.Text = "Product of elements with even indexes";
            this.buttonProductOfElements.UseVisualStyleBackColor = true;
            this.buttonProductOfElements.Visible = false;
            this.buttonProductOfElements.Click += new System.EventHandler(this.buttonProductOfElements_Click);
            // 
            // buttonIndexOfMaxElement
            // 
            this.buttonIndexOfMaxElement.Location = new System.Drawing.Point(56, 488);
            this.buttonIndexOfMaxElement.Name = "buttonIndexOfMaxElement";
            this.buttonIndexOfMaxElement.Size = new System.Drawing.Size(176, 41);
            this.buttonIndexOfMaxElement.TabIndex = 9;
            this.buttonIndexOfMaxElement.Text = "Index of max element";
            this.buttonIndexOfMaxElement.UseVisualStyleBackColor = true;
            this.buttonIndexOfMaxElement.Visible = false;
            this.buttonIndexOfMaxElement.Click += new System.EventHandler(this.buttonIndexOfMaxElement_Click);
            // 
            // buttonMaxOfAbsoluteValues
            // 
            this.buttonMaxOfAbsoluteValues.Location = new System.Drawing.Point(543, 257);
            this.buttonMaxOfAbsoluteValues.Name = "buttonMaxOfAbsoluteValues";
            this.buttonMaxOfAbsoluteValues.Size = new System.Drawing.Size(176, 41);
            this.buttonMaxOfAbsoluteValues.TabIndex = 10;
            this.buttonMaxOfAbsoluteValues.Text = "Max of absolute values";
            this.buttonMaxOfAbsoluteValues.UseVisualStyleBackColor = true;
            this.buttonMaxOfAbsoluteValues.Visible = false;
            this.buttonMaxOfAbsoluteValues.Click += new System.EventHandler(this.buttonMaxOfAbsoluteValues_Click);
            // 
            // buttonSumOfPositivsIndexes
            // 
            this.buttonSumOfPositivsIndexes.Location = new System.Drawing.Point(543, 333);
            this.buttonSumOfPositivsIndexes.Name = "buttonSumOfPositivsIndexes";
            this.buttonSumOfPositivsIndexes.Size = new System.Drawing.Size(176, 41);
            this.buttonSumOfPositivsIndexes.TabIndex = 11;
            this.buttonSumOfPositivsIndexes.Text = "Sum of positiv\'s indexes";
            this.buttonSumOfPositivsIndexes.UseVisualStyleBackColor = true;
            this.buttonSumOfPositivsIndexes.Visible = false;
            this.buttonSumOfPositivsIndexes.Click += new System.EventHandler(this.buttonSumOfPositivsIndexes_Click);
            // 
            // buttonAmountOfOddElements
            // 
            this.buttonAmountOfOddElements.Location = new System.Drawing.Point(543, 413);
            this.buttonAmountOfOddElements.Name = "buttonAmountOfOddElements";
            this.buttonAmountOfOddElements.Size = new System.Drawing.Size(176, 41);
            this.buttonAmountOfOddElements.TabIndex = 12;
            this.buttonAmountOfOddElements.Text = "Amount of odd elements";
            this.buttonAmountOfOddElements.UseVisualStyleBackColor = true;
            this.buttonAmountOfOddElements.Visible = false;
            this.buttonAmountOfOddElements.Click += new System.EventHandler(this.buttonAmountOfOddElements_Click);
            // 
            // textBoxAmountOfOddElements
            // 
            this.textBoxAmountOfOddElements.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxAmountOfOddElements.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxAmountOfOddElements.Location = new System.Drawing.Point(752, 422);
            this.textBoxAmountOfOddElements.Name = "textBoxAmountOfOddElements";
            this.textBoxAmountOfOddElements.ReadOnly = true;
            this.textBoxAmountOfOddElements.Size = new System.Drawing.Size(116, 22);
            this.textBoxAmountOfOddElements.TabIndex = 13;
            this.textBoxAmountOfOddElements.Visible = false;
            // 
            // textBoxSumOfPositivsIndexes
            // 
            this.textBoxSumOfPositivsIndexes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxSumOfPositivsIndexes.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxSumOfPositivsIndexes.Location = new System.Drawing.Point(752, 342);
            this.textBoxSumOfPositivsIndexes.Name = "textBoxSumOfPositivsIndexes";
            this.textBoxSumOfPositivsIndexes.ReadOnly = true;
            this.textBoxSumOfPositivsIndexes.Size = new System.Drawing.Size(116, 22);
            this.textBoxSumOfPositivsIndexes.TabIndex = 14;
            this.textBoxSumOfPositivsIndexes.Visible = false;
            // 
            // textBoxMaxOfAbsoluteValues
            // 
            this.textBoxMaxOfAbsoluteValues.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxMaxOfAbsoluteValues.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxMaxOfAbsoluteValues.Location = new System.Drawing.Point(752, 266);
            this.textBoxMaxOfAbsoluteValues.Name = "textBoxMaxOfAbsoluteValues";
            this.textBoxMaxOfAbsoluteValues.ReadOnly = true;
            this.textBoxMaxOfAbsoluteValues.Size = new System.Drawing.Size(116, 22);
            this.textBoxMaxOfAbsoluteValues.TabIndex = 15;
            this.textBoxMaxOfAbsoluteValues.Visible = false;
            // 
            // textBoxIndexOfMaxElement
            // 
            this.textBoxIndexOfMaxElement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxIndexOfMaxElement.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxIndexOfMaxElement.Location = new System.Drawing.Point(273, 497);
            this.textBoxIndexOfMaxElement.Name = "textBoxIndexOfMaxElement";
            this.textBoxIndexOfMaxElement.ReadOnly = true;
            this.textBoxIndexOfMaxElement.Size = new System.Drawing.Size(116, 22);
            this.textBoxIndexOfMaxElement.TabIndex = 16;
            this.textBoxIndexOfMaxElement.Visible = false;
            // 
            // textBoxProductOfElements
            // 
            this.textBoxProductOfElements.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxProductOfElements.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxProductOfElements.Location = new System.Drawing.Point(273, 422);
            this.textBoxProductOfElements.Name = "textBoxProductOfElements";
            this.textBoxProductOfElements.ReadOnly = true;
            this.textBoxProductOfElements.Size = new System.Drawing.Size(116, 22);
            this.textBoxProductOfElements.TabIndex = 17;
            this.textBoxProductOfElements.Visible = false;
            // 
            // textBoxMaxOfEvenElements
            // 
            this.textBoxMaxOfEvenElements.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxMaxOfEvenElements.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxMaxOfEvenElements.Location = new System.Drawing.Point(273, 342);
            this.textBoxMaxOfEvenElements.Name = "textBoxMaxOfEvenElements";
            this.textBoxMaxOfEvenElements.ReadOnly = true;
            this.textBoxMaxOfEvenElements.Size = new System.Drawing.Size(116, 22);
            this.textBoxMaxOfEvenElements.TabIndex = 18;
            this.textBoxMaxOfEvenElements.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 538);
            this.Controls.Add(this.textBoxMaxOfEvenElements);
            this.Controls.Add(this.textBoxProductOfElements);
            this.Controls.Add(this.textBoxIndexOfMaxElement);
            this.Controls.Add(this.textBoxMaxOfAbsoluteValues);
            this.Controls.Add(this.textBoxSumOfPositivsIndexes);
            this.Controls.Add(this.textBoxAmountOfOddElements);
            this.Controls.Add(this.buttonAmountOfOddElements);
            this.Controls.Add(this.buttonSumOfPositivsIndexes);
            this.Controls.Add(this.buttonMaxOfAbsoluteValues);
            this.Controls.Add(this.buttonIndexOfMaxElement);
            this.Controls.Add(this.buttonProductOfElements);
            this.Controls.Add(this.buttonMaxOfEvenElements);
            this.Controls.Add(this.textBoxSumOfNegatives);
            this.Controls.Add(this.buttonSumOfNegatives);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.buttonCreateArray);
            this.Controls.Add(this.dataGridViewArray);
            this.Controls.Add(this.labelAmount);
            this.Name = "Form1";
            this.Text = "Array Operations";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.DataGridView dataGridViewArray;
        private System.Windows.Forms.Button buttonCreateArray;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Button buttonSumOfNegatives;
        private System.Windows.Forms.TextBox textBoxSumOfNegatives;
        private System.Windows.Forms.Button buttonMaxOfEvenElements;
        private System.Windows.Forms.Button buttonProductOfElements;
        private System.Windows.Forms.Button buttonIndexOfMaxElement;
        private System.Windows.Forms.Button buttonMaxOfAbsoluteValues;
        private System.Windows.Forms.Button buttonSumOfPositivsIndexes;
        private System.Windows.Forms.Button buttonAmountOfOddElements;
        private System.Windows.Forms.TextBox textBoxAmountOfOddElements;
        private System.Windows.Forms.TextBox textBoxSumOfPositivsIndexes;
        private System.Windows.Forms.TextBox textBoxMaxOfAbsoluteValues;
        private System.Windows.Forms.TextBox textBoxIndexOfMaxElement;
        private System.Windows.Forms.TextBox textBoxProductOfElements;
        private System.Windows.Forms.TextBox textBoxMaxOfEvenElements;
    }
}

