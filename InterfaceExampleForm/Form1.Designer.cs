namespace InterfaceExampleForm
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbyukseklik = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btngoster = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbhacim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(214, 9);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(640, 150);
            this.dgv.TabIndex = 0;
            this.dgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID :";
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(83, 9);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(100, 23);
            this.tbid.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad :";
            // 
            // tbad
            // 
            this.tbad.Location = new System.Drawing.Point(83, 38);
            this.tbad.Name = "tbad";
            this.tbad.Size = new System.Drawing.Size(100, 23);
            this.tbad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yukseklik :";
            // 
            // tbyukseklik
            // 
            this.tbyukseklik.Location = new System.Drawing.Point(83, 67);
            this.tbyukseklik.Name = "tbyukseklik";
            this.tbyukseklik.Size = new System.Drawing.Size(100, 23);
            this.tbyukseklik.TabIndex = 2;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(108, 98);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btngoster
            // 
            this.btngoster.Location = new System.Drawing.Point(214, 165);
            this.btngoster.Name = "btngoster";
            this.btngoster.Size = new System.Drawing.Size(75, 23);
            this.btngoster.TabIndex = 4;
            this.btngoster.Text = "GÖSTER";
            this.btngoster.UseVisualStyleBackColor = true;
            this.btngoster.Click += new System.EventHandler(this.btngoster_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hacim :";
            // 
            // tbhacim
            // 
            this.tbhacim.Location = new System.Drawing.Point(133, 136);
            this.tbhacim.Name = "tbhacim";
            this.tbhacim.Size = new System.Drawing.Size(75, 23);
            this.tbhacim.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 210);
            this.Controls.Add(this.btngoster);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.tbhacim);
            this.Controls.Add(this.tbyukseklik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv;
        private Label label1;
        private TextBox tbid;
        private Label label2;
        private TextBox tbad;
        private Label label3;
        private TextBox tbyukseklik;
        private Button btnekle;
        private Button btngoster;
        private Label label4;
        private TextBox tbhacim;
    }
}