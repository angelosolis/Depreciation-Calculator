namespace DepreciationCalculator
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
            this.txtInitialCost = new System.Windows.Forms.TextBox();
            this.txtSalvageValue = new System.Windows.Forms.TextBox();
            this.cbLife = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSYD = new System.Windows.Forms.RadioButton();
            this.radioButtonSLN = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxDepreciation = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInitialCost
            // 
            this.txtInitialCost.Location = new System.Drawing.Point(101, 61);
            this.txtInitialCost.Name = "txtInitialCost";
            this.txtInitialCost.Size = new System.Drawing.Size(172, 20);
            this.txtInitialCost.TabIndex = 0;
            // 
            // txtSalvageValue
            // 
            this.txtSalvageValue.Location = new System.Drawing.Point(101, 104);
            this.txtSalvageValue.Name = "txtSalvageValue";
            this.txtSalvageValue.Size = new System.Drawing.Size(172, 20);
            this.txtSalvageValue.TabIndex = 0;
            // 
            // cbLife
            // 
            this.cbLife.FormattingEnabled = true;
            this.cbLife.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbLife.Location = new System.Drawing.Point(101, 148);
            this.cbLife.Name = "cbLife";
            this.cbLife.Size = new System.Drawing.Size(121, 21);
            this.cbLife.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Initial Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salvage Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Life";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Depreciation Schedule";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSYD);
            this.groupBox1.Controls.Add(this.radioButtonSLN);
            this.groupBox1.Location = new System.Drawing.Point(346, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depreciation";
            // 
            // radioButtonSYD
            // 
            this.radioButtonSYD.AutoSize = true;
            this.radioButtonSYD.Location = new System.Drawing.Point(27, 62);
            this.radioButtonSYD.Name = "radioButtonSYD";
            this.radioButtonSYD.Size = new System.Drawing.Size(88, 17);
            this.radioButtonSYD.TabIndex = 0;
            this.radioButtonSYD.TabStop = true;
            this.radioButtonSYD.Text = "Sum of Years";
            this.radioButtonSYD.UseVisualStyleBackColor = true;

            // 
            // radioButtonSLN
            // 
            this.radioButtonSLN.AutoSize = true;
            this.radioButtonSLN.Location = new System.Drawing.Point(27, 29);
            this.radioButtonSLN.Name = "radioButtonSLN";
            this.radioButtonSLN.Size = new System.Drawing.Size(84, 17);
            this.radioButtonSLN.TabIndex = 0;
            this.radioButtonSLN.TabStop = true;
            this.radioButtonSLN.Text = "Straight Line";
            this.radioButtonSLN.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(346, 215);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(145, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Update Schedule";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(346, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "E&xit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBoxDepreciation
            // 
            this.listBoxDepreciation.FormattingEnabled = true;
            this.listBoxDepreciation.Location = new System.Drawing.Point(46, 215);
            this.listBoxDepreciation.Name = "listBoxDepreciation";
            this.listBoxDepreciation.Size = new System.Drawing.Size(261, 173);
            this.listBoxDepreciation.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 410);
            this.Controls.Add(this.listBoxDepreciation);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLife);
            this.Controls.Add(this.txtSalvageValue);
            this.Controls.Add(this.txtInitialCost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInitialCost;
        private System.Windows.Forms.TextBox txtSalvageValue;
        private System.Windows.Forms.ComboBox cbLife;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSYD;
        private System.Windows.Forms.RadioButton radioButtonSLN;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxDepreciation;
    }
}

