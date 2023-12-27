namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.number1NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.number2NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.operationComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.number1NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number2NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // number1NumericUpDown
            // 
            this.number1NumericUpDown.DecimalPlaces = 2;
            this.number1NumericUpDown.Location = new System.Drawing.Point(12, 69);
            this.number1NumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.number1NumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.number1NumericUpDown.Name = "number1NumericUpDown";
            this.number1NumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.number1NumericUpDown.TabIndex = 1;
            this.number1NumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // number2NumericUpDown
            // 
            this.number2NumericUpDown.DecimalPlaces = 2;
            this.number2NumericUpDown.Location = new System.Drawing.Point(116, 69);
            this.number2NumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.number2NumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.number2NumericUpDown.Name = "number2NumericUpDown";
            this.number2NumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.number2NumericUpDown.TabIndex = 2;
            // 
            // operationComboBox
            // 
            this.operationComboBox.FormattingEnabled = true;
            this.operationComboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.operationComboBox.Location = new System.Drawing.Point(87, 68);
            this.operationComboBox.Name = "operationComboBox";
            this.operationComboBox.Size = new System.Drawing.Size(23, 21);
            this.operationComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(219, 71);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(13, 13);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.operationComboBox);
            this.Controls.Add(this.number2NumericUpDown);
            this.Controls.Add(this.number1NumericUpDown);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.number1NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number2NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown number1NumericUpDown;
        private System.Windows.Forms.NumericUpDown number2NumericUpDown;
        private System.Windows.Forms.ComboBox operationComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultLabel;
    }
}

