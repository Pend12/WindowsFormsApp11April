
namespace WindowsFormsApp11April
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
            this.comboBoxHome = new System.Windows.Forms.ComboBox();
            this.comboBoxAway = new System.Windows.Forms.ComboBox();
            this.labelVersus = new System.Windows.Forms.Label();
            this.labelCaptainHome = new System.Windows.Forms.Label();
            this.labelKaptenHome = new System.Windows.Forms.Label();
            this.labelManagerHome = new System.Windows.Forms.Label();
            this.labelManajerHome = new System.Windows.Forms.Label();
            this.labelManagerAway = new System.Windows.Forms.Label();
            this.labelCaptainAway = new System.Windows.Forms.Label();
            this.labelManajerAway = new System.Windows.Forms.Label();
            this.labelKaptenAway = new System.Windows.Forms.Label();
            this.labelStadium = new System.Windows.Forms.Label();
            this.labelStadion = new System.Windows.Forms.Label();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.labelKapasitas = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.labelSkor = new System.Windows.Forms.Label();
            this.labelHasilTanggal = new System.Windows.Forms.Label();
            this.labelHasilSkor = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxHome
            // 
            this.comboBoxHome.FormattingEnabled = true;
            this.comboBoxHome.Location = new System.Drawing.Point(12, 27);
            this.comboBoxHome.Name = "comboBoxHome";
            this.comboBoxHome.Size = new System.Drawing.Size(393, 24);
            this.comboBoxHome.TabIndex = 0;
            this.comboBoxHome.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxAway
            // 
            this.comboBoxAway.FormattingEnabled = true;
            this.comboBoxAway.Location = new System.Drawing.Point(474, 27);
            this.comboBoxAway.Name = "comboBoxAway";
            this.comboBoxAway.Size = new System.Drawing.Size(432, 24);
            this.comboBoxAway.TabIndex = 1;
            this.comboBoxAway.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // labelVersus
            // 
            this.labelVersus.AutoSize = true;
            this.labelVersus.Location = new System.Drawing.Point(429, 34);
            this.labelVersus.Name = "labelVersus";
            this.labelVersus.Size = new System.Drawing.Size(26, 17);
            this.labelVersus.TabIndex = 2;
            this.labelVersus.Text = "VS";
            // 
            // labelCaptainHome
            // 
            this.labelCaptainHome.AutoSize = true;
            this.labelCaptainHome.Location = new System.Drawing.Point(138, 79);
            this.labelCaptainHome.Name = "labelCaptainHome";
            this.labelCaptainHome.Size = new System.Drawing.Size(61, 17);
            this.labelCaptainHome.TabIndex = 3;
            this.labelCaptainHome.Text = "Kapten :";
            this.labelCaptainHome.Click += new System.EventHandler(this.labelCaptainHome_Click);
            // 
            // labelKaptenHome
            // 
            this.labelKaptenHome.AutoSize = true;
            this.labelKaptenHome.Location = new System.Drawing.Point(205, 79);
            this.labelKaptenHome.Name = "labelKaptenHome";
            this.labelKaptenHome.Size = new System.Drawing.Size(31, 17);
            this.labelKaptenHome.TabIndex = 4;
            this.labelKaptenHome.Text = "N/A";
            this.labelKaptenHome.Click += new System.EventHandler(this.labelKaptenHome_Click);
            // 
            // labelManagerHome
            // 
            this.labelManagerHome.AutoSize = true;
            this.labelManagerHome.Location = new System.Drawing.Point(127, 62);
            this.labelManagerHome.Name = "labelManagerHome";
            this.labelManagerHome.Size = new System.Drawing.Size(72, 17);
            this.labelManagerHome.TabIndex = 5;
            this.labelManagerHome.Text = "Manager :";
            // 
            // labelManajerHome
            // 
            this.labelManajerHome.AutoSize = true;
            this.labelManajerHome.Location = new System.Drawing.Point(205, 62);
            this.labelManajerHome.Name = "labelManajerHome";
            this.labelManajerHome.Size = new System.Drawing.Size(31, 17);
            this.labelManajerHome.TabIndex = 6;
            this.labelManajerHome.Text = "N/A";
            this.labelManajerHome.Click += new System.EventHandler(this.labelManajerHome_Click);
            // 
            // labelManagerAway
            // 
            this.labelManagerAway.AutoSize = true;
            this.labelManagerAway.Location = new System.Drawing.Point(653, 54);
            this.labelManagerAway.Name = "labelManagerAway";
            this.labelManagerAway.Size = new System.Drawing.Size(76, 17);
            this.labelManagerAway.TabIndex = 7;
            this.labelManagerAway.Text = "Manager : ";
            // 
            // labelCaptainAway
            // 
            this.labelCaptainAway.AutoSize = true;
            this.labelCaptainAway.Location = new System.Drawing.Point(655, 75);
            this.labelCaptainAway.Name = "labelCaptainAway";
            this.labelCaptainAway.Size = new System.Drawing.Size(65, 17);
            this.labelCaptainAway.TabIndex = 8;
            this.labelCaptainAway.Text = "Kapten : ";
            // 
            // labelManajerAway
            // 
            this.labelManajerAway.AutoSize = true;
            this.labelManajerAway.Location = new System.Drawing.Point(726, 54);
            this.labelManajerAway.Name = "labelManajerAway";
            this.labelManajerAway.Size = new System.Drawing.Size(31, 17);
            this.labelManajerAway.TabIndex = 9;
            this.labelManajerAway.Text = "N/A";
            this.labelManajerAway.Click += new System.EventHandler(this.labelManajerAway_Click);
            // 
            // labelKaptenAway
            // 
            this.labelKaptenAway.AutoSize = true;
            this.labelKaptenAway.Location = new System.Drawing.Point(726, 75);
            this.labelKaptenAway.Name = "labelKaptenAway";
            this.labelKaptenAway.Size = new System.Drawing.Size(31, 17);
            this.labelKaptenAway.TabIndex = 10;
            this.labelKaptenAway.Text = "N/A";
            // 
            // labelStadium
            // 
            this.labelStadium.AutoSize = true;
            this.labelStadium.Location = new System.Drawing.Point(381, 93);
            this.labelStadium.Name = "labelStadium";
            this.labelStadium.Size = new System.Drawing.Size(67, 17);
            this.labelStadium.TabIndex = 11;
            this.labelStadium.Text = "Stadium :";
            // 
            // labelStadion
            // 
            this.labelStadion.AutoSize = true;
            this.labelStadion.Location = new System.Drawing.Point(471, 93);
            this.labelStadion.Name = "labelStadion";
            this.labelStadion.Size = new System.Drawing.Size(31, 17);
            this.labelStadion.TabIndex = 12;
            this.labelStadion.Text = "N/A";
            this.labelStadion.Click += new System.EventHandler(this.labelStadion_Click);
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Location = new System.Drawing.Point(380, 110);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(74, 17);
            this.labelCapacity.TabIndex = 13;
            this.labelCapacity.Text = "Capacity : ";
            // 
            // labelKapasitas
            // 
            this.labelKapasitas.AutoSize = true;
            this.labelKapasitas.Location = new System.Drawing.Point(471, 110);
            this.labelKapasitas.Name = "labelKapasitas";
            this.labelKapasitas.Size = new System.Drawing.Size(31, 17);
            this.labelKapasitas.TabIndex = 14;
            this.labelKapasitas.Text = "N/A";
            this.labelKapasitas.Click += new System.EventHandler(this.labelKapasitas_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(913, 385);
            this.dataGridView1.TabIndex = 15;
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Location = new System.Drawing.Point(380, 170);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(68, 17);
            this.labelTanggal.TabIndex = 16;
            this.labelTanggal.Text = "Tanggal :";
            // 
            // labelSkor
            // 
            this.labelSkor.AutoSize = true;
            this.labelSkor.Location = new System.Drawing.Point(381, 187);
            this.labelSkor.Name = "labelSkor";
            this.labelSkor.Size = new System.Drawing.Size(45, 17);
            this.labelSkor.TabIndex = 17;
            this.labelSkor.Text = "Skor :";
            // 
            // labelHasilTanggal
            // 
            this.labelHasilTanggal.AutoSize = true;
            this.labelHasilTanggal.Location = new System.Drawing.Point(455, 170);
            this.labelHasilTanggal.Name = "labelHasilTanggal";
            this.labelHasilTanggal.Size = new System.Drawing.Size(31, 17);
            this.labelHasilTanggal.TabIndex = 18;
            this.labelHasilTanggal.Text = "N/A";
            // 
            // labelHasilSkor
            // 
            this.labelHasilSkor.AutoSize = true;
            this.labelHasilSkor.Location = new System.Drawing.Point(432, 187);
            this.labelHasilSkor.Name = "labelHasilSkor";
            this.labelHasilSkor.Size = new System.Drawing.Size(31, 17);
            this.labelHasilSkor.TabIndex = 19;
            this.labelHasilSkor.Text = "N/A";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(384, 139);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(102, 28);
            this.buttonCheck.TabIndex = 20;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 604);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.labelHasilSkor);
            this.Controls.Add(this.labelHasilTanggal);
            this.Controls.Add(this.labelSkor);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelKapasitas);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.labelStadion);
            this.Controls.Add(this.labelStadium);
            this.Controls.Add(this.labelKaptenAway);
            this.Controls.Add(this.labelManajerAway);
            this.Controls.Add(this.labelCaptainAway);
            this.Controls.Add(this.labelManagerAway);
            this.Controls.Add(this.labelManajerHome);
            this.Controls.Add(this.labelManagerHome);
            this.Controls.Add(this.labelKaptenHome);
            this.Controls.Add(this.labelCaptainHome);
            this.Controls.Add(this.labelVersus);
            this.Controls.Add(this.comboBoxAway);
            this.Controls.Add(this.comboBoxHome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxHome;
        private System.Windows.Forms.ComboBox comboBoxAway;
        private System.Windows.Forms.Label labelVersus;
        private System.Windows.Forms.Label labelCaptainHome;
        private System.Windows.Forms.Label labelKaptenHome;
        private System.Windows.Forms.Label labelManagerHome;
        private System.Windows.Forms.Label labelManajerHome;
        private System.Windows.Forms.Label labelManagerAway;
        private System.Windows.Forms.Label labelCaptainAway;
        private System.Windows.Forms.Label labelManajerAway;
        private System.Windows.Forms.Label labelKaptenAway;
        private System.Windows.Forms.Label labelStadium;
        private System.Windows.Forms.Label labelStadion;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label labelKapasitas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.Label labelSkor;
        private System.Windows.Forms.Label labelHasilTanggal;
        private System.Windows.Forms.Label labelHasilSkor;
        private System.Windows.Forms.Button buttonCheck;
    }
}

