namespace TestShiftVal
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numShiftVal = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numChecked = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numUnchecked = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numShiftVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChecked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnchecked)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 107);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 142);
            this.textBox1.TabIndex = 0;
            // 
            // numShiftVal
            // 
            this.numShiftVal.Location = new System.Drawing.Point(82, 7);
            this.numShiftVal.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numShiftVal.Name = "numShiftVal";
            this.numShiftVal.Size = new System.Drawing.Size(134, 20);
            this.numShiftVal.TabIndex = 1;
            this.numShiftVal.ValueChanged += new System.EventHandler(this.numShiftVal_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ShiftVal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Checked:";
            // 
            // numChecked
            // 
            this.numChecked.Location = new System.Drawing.Point(82, 40);
            this.numChecked.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numChecked.Name = "numChecked";
            this.numChecked.Size = new System.Drawing.Size(134, 20);
            this.numChecked.TabIndex = 3;
            this.numChecked.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numChecked.ValueChanged += new System.EventHandler(this.numChecked_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "UnChecked:";
            // 
            // numUnchecked
            // 
            this.numUnchecked.Location = new System.Drawing.Point(82, 75);
            this.numUnchecked.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numUnchecked.Name = "numUnchecked";
            this.numUnchecked.Size = new System.Drawing.Size(134, 20);
            this.numUnchecked.TabIndex = 5;
            this.numUnchecked.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUnchecked.ValueChanged += new System.EventHandler(this.numUnchecked_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numUnchecked);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numChecked);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numShiftVal);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numShiftVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChecked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnchecked)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numShiftVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numChecked;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUnchecked;
    }
}

