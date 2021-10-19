
namespace AutoKeyPresser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rdBtnAuto = new System.Windows.Forms.RadioButton();
            this.rdBtnManuel = new System.Windows.Forms.RadioButton();
            this.pnlDeger = new System.Windows.Forms.Panel();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblMiddle = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.tbxThirdValue = new System.Windows.Forms.TextBox();
            this.tbxSecondValue = new System.Windows.Forms.TextBox();
            this.tbxFirstValue = new System.Windows.Forms.TextBox();
            this.cBoxFirst = new System.Windows.Forms.ComboBox();
            this.pnlDeger.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rdBtnAuto
            // 
            this.rdBtnAuto.AutoSize = true;
            this.rdBtnAuto.Location = new System.Drawing.Point(10, 9);
            this.rdBtnAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdBtnAuto.Name = "rdBtnAuto";
            this.rdBtnAuto.Size = new System.Drawing.Size(90, 19);
            this.rdBtnAuto.TabIndex = 5;
            this.rdBtnAuto.Text = "AUTO PRINT";
            this.rdBtnAuto.UseVisualStyleBackColor = true;
            this.rdBtnAuto.CheckedChanged += new System.EventHandler(this.rdBtnAuto_CheckedChanged);
            // 
            // rdBtnManuel
            // 
            this.rdBtnManuel.AutoSize = true;
            this.rdBtnManuel.Location = new System.Drawing.Point(11, 32);
            this.rdBtnManuel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdBtnManuel.Name = "rdBtnManuel";
            this.rdBtnManuel.Size = new System.Drawing.Size(108, 19);
            this.rdBtnManuel.TabIndex = 6;
            this.rdBtnManuel.Text = "MANUEL PRINT";
            this.rdBtnManuel.UseVisualStyleBackColor = true;
            this.rdBtnManuel.CheckedChanged += new System.EventHandler(this.rdBtnManuel_CheckedChanged);
            // 
            // pnlDeger
            // 
            this.pnlDeger.Controls.Add(this.lblLast);
            this.pnlDeger.Controls.Add(this.lblMiddle);
            this.pnlDeger.Controls.Add(this.lblFirst);
            this.pnlDeger.Controls.Add(this.tbxThirdValue);
            this.pnlDeger.Controls.Add(this.tbxSecondValue);
            this.pnlDeger.Controls.Add(this.tbxFirstValue);
            this.pnlDeger.Location = new System.Drawing.Point(11, 159);
            this.pnlDeger.Name = "pnlDeger";
            this.pnlDeger.Size = new System.Drawing.Size(197, 100);
            this.pnlDeger.TabIndex = 7;
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(4, 72);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(59, 15);
            this.lblLast.TabIndex = 3;
            this.lblLast.Text = "Last Value";
            // 
            // lblMiddle
            // 
            this.lblMiddle.AutoSize = true;
            this.lblMiddle.Location = new System.Drawing.Point(3, 42);
            this.lblMiddle.Name = "lblMiddle";
            this.lblMiddle.Size = new System.Drawing.Size(75, 15);
            this.lblMiddle.TabIndex = 3;
            this.lblMiddle.Text = "Middle Value";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(3, 12);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(60, 15);
            this.lblFirst.TabIndex = 3;
            this.lblFirst.Text = "First Value";
            // 
            // tbxThirdValue
            // 
            this.tbxThirdValue.Location = new System.Drawing.Point(87, 69);
            this.tbxThirdValue.Name = "tbxThirdValue";
            this.tbxThirdValue.Size = new System.Drawing.Size(100, 23);
            this.tbxThirdValue.TabIndex = 2;
            // 
            // tbxSecondValue
            // 
            this.tbxSecondValue.Location = new System.Drawing.Point(87, 39);
            this.tbxSecondValue.Name = "tbxSecondValue";
            this.tbxSecondValue.Size = new System.Drawing.Size(100, 23);
            this.tbxSecondValue.TabIndex = 1;
            // 
            // tbxFirstValue
            // 
            this.tbxFirstValue.Location = new System.Drawing.Point(87, 9);
            this.tbxFirstValue.Name = "tbxFirstValue";
            this.tbxFirstValue.Size = new System.Drawing.Size(100, 23);
            this.tbxFirstValue.TabIndex = 0;
            // 
            // cBoxFirst
            // 
            this.cBoxFirst.FormattingEnabled = true;
            this.cBoxFirst.Items.AddRange(new object[] {
            "CTRL+O",
            "CTRL+SHIFT+Y",
            "CTRL+SHIFT+G",
            "ENTER"});
            this.cBoxFirst.Location = new System.Drawing.Point(77, 134);
            this.cBoxFirst.Name = "cBoxFirst";
            this.cBoxFirst.Size = new System.Drawing.Size(121, 23);
            this.cBoxFirst.TabIndex = 8;
            this.cBoxFirst.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 267);
            this.Controls.Add(this.cBoxFirst);
            this.Controls.Add(this.pnlDeger);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rdBtnManuel);
            this.Controls.Add(this.rdBtnAuto);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "BuzzBarcode.001";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlDeger.ResumeLayout(false);
            this.pnlDeger.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rdBtnAuto;
        private System.Windows.Forms.RadioButton rdBtnManuel;
        private System.Windows.Forms.Panel pnlDeger;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblMiddle;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.TextBox tbxThirdValue;
        private System.Windows.Forms.TextBox tbxSecondValue;
        private System.Windows.Forms.TextBox tbxFirstValue;
        private System.Windows.Forms.ComboBox cBoxFirst;
    }
}

