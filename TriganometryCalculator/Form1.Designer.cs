
namespace TriganometryCalculator
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
            this.Input1 = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.CosCalc = new System.Windows.Forms.RadioButton();
            this.TanCalc = new System.Windows.Forms.RadioButton();
            this.Answer1 = new System.Windows.Forms.Label();
            this.SinCalc = new System.Windows.Forms.RadioButton();
            this.Answer2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InputNumberOne = new System.Windows.Forms.Label();
            this.InputNumberTwo = new System.Windows.Forms.Label();
            this.ErrorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Input1
            // 
            this.Input1.Location = new System.Drawing.Point(12, 11);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(82, 20);
            this.Input1.TabIndex = 0;
            this.Input1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input1_KeyPress);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(190, 10);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Input2
            // 
            this.Input2.Location = new System.Drawing.Point(100, 11);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(84, 20);
            this.Input2.TabIndex = 2;
            this.Input2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input2_KeyPress);
            // 
            // CosCalc
            // 
            this.CosCalc.AutoSize = true;
            this.CosCalc.Location = new System.Drawing.Point(358, 13);
            this.CosCalc.Name = "CosCalc";
            this.CosCalc.Size = new System.Drawing.Size(95, 17);
            this.CosCalc.TabIndex = 4;
            this.CosCalc.Text = "CosCalculation";
            this.CosCalc.UseVisualStyleBackColor = true;
            this.CosCalc.CheckedChanged += new System.EventHandler(this.CosCalc_CheckedChanged);
            // 
            // TanCalc
            // 
            this.TanCalc.AutoSize = true;
            this.TanCalc.Location = new System.Drawing.Point(449, 13);
            this.TanCalc.Name = "TanCalc";
            this.TanCalc.Size = new System.Drawing.Size(96, 17);
            this.TanCalc.TabIndex = 5;
            this.TanCalc.Text = "TanCalculation";
            this.TanCalc.UseVisualStyleBackColor = true;
            this.TanCalc.CheckedChanged += new System.EventHandler(this.TanCalc_CheckedChanged);
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.Location = new System.Drawing.Point(9, 74);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(41, 13);
            this.Answer1.TabIndex = 6;
            this.Answer1.Text = "AngleX";
            // 
            // SinCalc
            // 
            this.SinCalc.AutoSize = true;
            this.SinCalc.Location = new System.Drawing.Point(271, 13);
            this.SinCalc.Name = "SinCalc";
            this.SinCalc.Size = new System.Drawing.Size(86, 17);
            this.SinCalc.TabIndex = 3;
            this.SinCalc.Text = "SinCalulation";
            this.SinCalc.UseVisualStyleBackColor = true;
            this.SinCalc.CheckedChanged += new System.EventHandler(this.SinCalc_CheckedChanged);
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.Location = new System.Drawing.Point(9, 87);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(41, 13);
            this.Answer2.TabIndex = 7;
            this.Answer2.Text = "AngleY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "For SinCalculation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "For CosCalculation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "For TanCalculation";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TriganometryCalculator.Properties.Resources.TanTriangle;
            this.pictureBox3.Location = new System.Drawing.Point(553, 141);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(235, 120);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TriganometryCalculator.Properties.Resources.CosTriangle;
            this.pictureBox2.Location = new System.Drawing.Point(285, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(235, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TriganometryCalculator.Properties.Resources.BetterTrangle1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // InputNumberOne
            // 
            this.InputNumberOne.AutoSize = true;
            this.InputNumberOne.Location = new System.Drawing.Point(9, 38);
            this.InputNumberOne.Name = "InputNumberOne";
            this.InputNumberOne.Size = new System.Drawing.Size(71, 13);
            this.InputNumberOne.TabIndex = 14;
            this.InputNumberOne.Text = "Select Option";
            // 
            // InputNumberTwo
            // 
            this.InputNumberTwo.AutoSize = true;
            this.InputNumberTwo.Location = new System.Drawing.Point(97, 38);
            this.InputNumberTwo.Name = "InputNumberTwo";
            this.InputNumberTwo.Size = new System.Drawing.Size(69, 13);
            this.InputNumberTwo.TabIndex = 15;
            this.InputNumberTwo.Text = "Select option";
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(551, 15);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(93, 13);
            this.ErrorMessage.TabIndex = 16;
            this.ErrorMessage.Text = "Invalid Calculation";
            this.ErrorMessage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.InputNumberTwo);
            this.Controls.Add(this.InputNumberOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.Answer1);
            this.Controls.Add(this.TanCalc);
            this.Controls.Add(this.CosCalc);
            this.Controls.Add(this.SinCalc);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.Input1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input1;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox Input2;
        private System.Windows.Forms.RadioButton CosCalc;
        private System.Windows.Forms.RadioButton TanCalc;
        private System.Windows.Forms.Label Answer1;
        private System.Windows.Forms.RadioButton SinCalc;
        private System.Windows.Forms.Label Answer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label InputNumberOne;
        private System.Windows.Forms.Label InputNumberTwo;
        private System.Windows.Forms.Label ErrorMessage;
    }
}

