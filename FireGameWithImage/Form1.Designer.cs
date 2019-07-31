namespace FireGameWithImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Fire_Gun = new System.Windows.Forms.Button();
            this.Spin_Gun = new System.Windows.Forms.Button();
            this.Lad_Bullet = new System.Windows.Forms.Button();
            this.No_Of_Bullet = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.No_Of_Bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Fire_Gun);
            this.groupBox1.Controls.Add(this.Spin_Gun);
            this.groupBox1.Controls.Add(this.Lad_Bullet);
            this.groupBox1.Controls.Add(this.No_Of_Bullet);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 382);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Fire_Gun
            // 
            this.Fire_Gun.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fire_Gun.Location = new System.Drawing.Point(21, 279);
            this.Fire_Gun.Name = "Fire_Gun";
            this.Fire_Gun.Size = new System.Drawing.Size(158, 52);
            this.Fire_Gun.TabIndex = 5;
            this.Fire_Gun.Text = "Fire";
            this.Fire_Gun.UseVisualStyleBackColor = true;
            this.Fire_Gun.Click += new System.EventHandler(this.Fire_Gun_Click);
            // 
            // Spin_Gun
            // 
            this.Spin_Gun.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spin_Gun.Location = new System.Drawing.Point(185, 206);
            this.Spin_Gun.Name = "Spin_Gun";
            this.Spin_Gun.Size = new System.Drawing.Size(158, 52);
            this.Spin_Gun.TabIndex = 4;
            this.Spin_Gun.Text = "Spin ";
            this.Spin_Gun.UseVisualStyleBackColor = true;
            this.Spin_Gun.Click += new System.EventHandler(this.Spin_Gun_Click);
            // 
            // Lad_Bullet
            // 
            this.Lad_Bullet.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lad_Bullet.Location = new System.Drawing.Point(21, 206);
            this.Lad_Bullet.Name = "Lad_Bullet";
            this.Lad_Bullet.Size = new System.Drawing.Size(158, 52);
            this.Lad_Bullet.TabIndex = 3;
            this.Lad_Bullet.Text = "Load Bullet";
            this.Lad_Bullet.UseVisualStyleBackColor = true;
            this.Lad_Bullet.Click += new System.EventHandler(this.Lad_Bullet_Click);
            // 
            // No_Of_Bullet
            // 
            this.No_Of_Bullet.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No_Of_Bullet.Location = new System.Drawing.Point(195, 129);
            this.No_Of_Bullet.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.No_Of_Bullet.Name = "No_Of_Bullet";
            this.No_Of_Bullet.Size = new System.Drawing.Size(120, 39);
            this.No_Of_Bullet.TabIndex = 2;
            this.No_Of_Bullet.ValueChanged += new System.EventHandler(this.No_Of_Bullet_ValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(195, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.No_Of_Bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown No_Of_Bullet;
        private System.Windows.Forms.Button Lad_Bullet;
        private System.Windows.Forms.Button Spin_Gun;
        private System.Windows.Forms.Button Fire_Gun;
    }
}

