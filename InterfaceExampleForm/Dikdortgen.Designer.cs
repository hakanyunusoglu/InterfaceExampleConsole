namespace InterfaceExampleForm
{
    partial class Dikdortgen
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
            this.btngoster = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.tbuzun = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbkisa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbyukseklik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tbhacim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btngoster
            // 
            this.btngoster.Location = new System.Drawing.Point(219, 168);
            this.btngoster.Name = "btngoster";
            this.btngoster.Size = new System.Drawing.Size(75, 23);
            this.btngoster.TabIndex = 17;
            this.btngoster.Text = "GÖSTER";
            this.btngoster.UseVisualStyleBackColor = true;
            this.btngoster.Click += new System.EventHandler(this.btngoster_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(113, 157);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 18;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // tbuzun
            // 
            this.tbuzun.Location = new System.Drawing.Point(88, 128);
            this.tbuzun.Name = "tbuzun";
            this.tbuzun.Size = new System.Drawing.Size(100, 23);
            this.tbuzun.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Uzun Kenar :";
            // 
            // tbkisa
            // 
            this.tbkisa.Location = new System.Drawing.Point(88, 99);
            this.tbkisa.Name = "tbkisa";
            this.tbkisa.Size = new System.Drawing.Size(100, 23);
            this.tbkisa.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kısa Kenar :";
            // 
            // tbyukseklik
            // 
            this.tbyukseklik.Location = new System.Drawing.Point(88, 70);
            this.tbyukseklik.Name = "tbyukseklik";
            this.tbyukseklik.Size = new System.Drawing.Size(100, 23);
            this.tbyukseklik.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Yukseklik :";
            // 
            // tbad
            // 
            this.tbad.Location = new System.Drawing.Point(88, 41);
            this.tbad.Name = "tbad";
            this.tbad.Size = new System.Drawing.Size(100, 23);
            this.tbad.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ad :";
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(88, 12);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(100, 23);
            this.tbid.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID :";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(219, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(640, 150);
            this.dgv.TabIndex = 7;
            this.dgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseClick);
            // 
            // tbhacim
            // 
            this.tbhacim.Location = new System.Drawing.Point(391, 168);
            this.tbhacim.Name = "tbhacim";
            this.tbhacim.Size = new System.Drawing.Size(75, 23);
            this.tbhacim.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Hacim :";
            // 
            // Dikdortgen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 251);
            this.Controls.Add(this.tbhacim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btngoster);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.tbuzun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbkisa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbyukseklik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Name = "Dikdortgen";
            this.Text = "Dikdortgen";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btngoster;
        private Button btnekle;
        private TextBox tbuzun;
        private Label label5;
        private TextBox tbkisa;
        private Label label4;
        private TextBox tbyukseklik;
        private Label label3;
        private TextBox tbad;
        private Label label2;
        private TextBox tbid;
        private Label label1;
        private DataGridView dgv;
        private TextBox tbhacim;
        private Label label6;
    }
}