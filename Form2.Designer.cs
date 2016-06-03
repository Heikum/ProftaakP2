namespace proftaakp2
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.temperatuurlabel = new System.Windows.Forms.Label();
            this.vochtigheidlabel = new System.Windows.Forms.Label();
            this.deurlabel = new System.Windows.Forms.Label();
            this.gewichtslabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.geluidslabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tijdlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatuur:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vochtigheid: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Deur: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gewicht:";
            // 
            // temperatuurlabel
            // 
            this.temperatuurlabel.AutoSize = true;
            this.temperatuurlabel.Location = new System.Drawing.Point(245, 51);
            this.temperatuurlabel.Name = "temperatuurlabel";
            this.temperatuurlabel.Size = new System.Drawing.Size(47, 25);
            this.temperatuurlabel.TabIndex = 4;
            this.temperatuurlabel.Text = "0 ℃";
            // 
            // vochtigheidlabel
            // 
            this.vochtigheidlabel.AutoSize = true;
            this.vochtigheidlabel.Location = new System.Drawing.Point(245, 93);
            this.vochtigheidlabel.Name = "vochtigheidlabel";
            this.vochtigheidlabel.Size = new System.Drawing.Size(55, 25);
            this.vochtigheidlabel.TabIndex = 5;
            this.vochtigheidlabel.Text = "15%";
            // 
            // deurlabel
            // 
            this.deurlabel.AutoSize = true;
            this.deurlabel.Location = new System.Drawing.Point(245, 135);
            this.deurlabel.Name = "deurlabel";
            this.deurlabel.Size = new System.Drawing.Size(64, 25);
            this.deurlabel.TabIndex = 6;
            this.deurlabel.Text = "Open";
            // 
            // gewichtslabel
            // 
            this.gewichtslabel.AutoSize = true;
            this.gewichtslabel.Location = new System.Drawing.Point(245, 220);
            this.gewichtslabel.Name = "gewichtslabel";
            this.gewichtslabel.Size = new System.Drawing.Size(72, 25);
            this.gewichtslabel.TabIndex = 7;
            this.gewichtslabel.Text = "15 KG";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Geluidsniveau: ";
            // 
            // geluidslabel
            // 
            this.geluidslabel.AutoSize = true;
            this.geluidslabel.Location = new System.Drawing.Point(245, 177);
            this.geluidslabel.Name = "geluidslabel";
            this.geluidslabel.Size = new System.Drawing.Size(92, 25);
            this.geluidslabel.TabIndex = 9;
            this.geluidslabel.Text = "Normaal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tijdlabel);
            this.groupBox1.Controls.Add(this.geluidslabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.gewichtslabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.deurlabel);
            this.groupBox1.Controls.Add(this.temperatuurlabel);
            this.groupBox1.Controls.Add(this.vochtigheidlabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 259);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gemeten waardes ";
            // 
            // tijdlabel
            // 
            this.tijdlabel.AutoSize = true;
            this.tijdlabel.Location = new System.Drawing.Point(245, 0);
            this.tijdlabel.Name = "tijdlabel";
            this.tijdlabel.Size = new System.Drawing.Size(74, 25);
            this.tijdlabel.TabIndex = 11;
            this.tijdlabel.Text = "tijdstip";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(342, 64);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sla op";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(391, 26);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(318, 64);
            this.button2.TabIndex = 14;
            this.button2.Text = "Overzicht sensoren";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overzicht kamer 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label deurlabel;
        private System.Windows.Forms.Label gewichtslabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label geluidslabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tijdlabel;
        private System.Windows.Forms.Label vochtigheidlabel;
        private System.Windows.Forms.Label temperatuurlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button2;
    }
}