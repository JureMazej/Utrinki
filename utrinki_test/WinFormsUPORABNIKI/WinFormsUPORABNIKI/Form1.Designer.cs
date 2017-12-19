namespace WinFormsUPORABNIKI
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPriimek = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKomentar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(15, 84);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(192, 20);
            this.textBoxIme.TabIndex = 1;
            // 
            // textBoxPriimek
            // 
            this.textBoxPriimek.Location = new System.Drawing.Point(15, 133);
            this.textBoxPriimek.Name = "textBoxPriimek";
            this.textBoxPriimek.Size = new System.Drawing.Size(192, 20);
            this.textBoxPriimek.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Priimek";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 182);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum rojstva";
            // 
            // textBoxKomentar
            // 
            this.textBoxKomentar.Location = new System.Drawing.Point(15, 231);
            this.textBoxKomentar.Name = "textBoxKomentar";
            this.textBoxKomentar.Size = new System.Drawing.Size(192, 20);
            this.textBoxKomentar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Komentar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(53, 28);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(13, 13);
            this.labelID.TabIndex = 9;
            this.labelID.Text = "1";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(109, 17);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(98, 34);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Dodaj v bazo";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 283);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxKomentar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxPriimek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Vnos uporabnika";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPriimek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKomentar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonAdd;
    }
}

