namespace G2g.Forms
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
            this.lblWowEu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEuExcel = new System.Windows.Forms.Button();
            this.btnUsExcel = new System.Windows.Forms.Button();
            this.sfdEuExcel = new System.Windows.Forms.SaveFileDialog();
            this.sfdUsExcel = new System.Windows.Forms.SaveFileDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPriceMargine = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblWowEu
            // 
            this.lblWowEu.AutoSize = true;
            this.lblWowEu.Location = new System.Drawing.Point(23, 46);
            this.lblWowEu.Name = "lblWowEu";
            this.lblWowEu.Size = new System.Drawing.Size(107, 13);
            this.lblWowEu.TabIndex = 0;
            this.lblWowEu.Text = "Choose Eu Excel File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose US Excel File";
            // 
            // btnEuExcel
            // 
            this.btnEuExcel.Location = new System.Drawing.Point(153, 41);
            this.btnEuExcel.Name = "btnEuExcel";
            this.btnEuExcel.Size = new System.Drawing.Size(75, 23);
            this.btnEuExcel.TabIndex = 2;
            this.btnEuExcel.Text = "Eu excel";
            this.btnEuExcel.UseVisualStyleBackColor = true;
            this.btnEuExcel.Click += new System.EventHandler(this.btnEuExcel_Click);
            // 
            // btnUsExcel
            // 
            this.btnUsExcel.Location = new System.Drawing.Point(153, 70);
            this.btnUsExcel.Name = "btnUsExcel";
            this.btnUsExcel.Size = new System.Drawing.Size(75, 23);
            this.btnUsExcel.TabIndex = 3;
            this.btnUsExcel.Text = "US excel";
            this.btnUsExcel.UseVisualStyleBackColor = true;
            this.btnUsExcel.Click += new System.EventHandler(this.btnUsExcel_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(153, 185);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price Margine";
            // 
            // tbxPriceMargine
            // 
            this.tbxPriceMargine.Location = new System.Drawing.Point(153, 118);
            this.tbxPriceMargine.Name = "tbxPriceMargine";
            this.tbxPriceMargine.Size = new System.Drawing.Size(75, 20);
            this.tbxPriceMargine.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 640);
            this.Controls.Add(this.tbxPriceMargine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnUsExcel);
            this.Controls.Add(this.btnEuExcel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWowEu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWowEu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEuExcel;
        private System.Windows.Forms.Button btnUsExcel;
        private System.Windows.Forms.SaveFileDialog sfdEuExcel;
        private System.Windows.Forms.SaveFileDialog sfdUsExcel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPriceMargine;
    }
}

