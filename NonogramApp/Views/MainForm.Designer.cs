namespace NonogramApp.Views
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblHeader = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnProfiel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Welkom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Registeren = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.Uitleg = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Puzzel2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlayNow = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHeader.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblHeader.Controls.Add(this.flowLayoutPanel1);
            this.lblHeader.Controls.Add(this.label1);
            this.lblHeader.Location = new System.Drawing.Point(12, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1413, 77);
            this.lblHeader.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnHome);
            this.flowLayoutPanel1.Controls.Add(this.btnProfiel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1129, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(271, 35);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(136, 27);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.Home_Click);
            // 
            // btnProfiel
            // 
            this.btnProfiel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProfiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfiel.Location = new System.Drawing.Point(145, 3);
            this.btnProfiel.Name = "btnProfiel";
            this.btnProfiel.Padding = new System.Windows.Forms.Padding(1);
            this.btnProfiel.Size = new System.Drawing.Size(106, 27);
            this.btnProfiel.TabIndex = 3;
            this.btnProfiel.Text = "Profiel";
            this.btnProfiel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nonogram Aplicatie";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Welkom
            // 
            this.Welkom.AutoSize = true;
            this.Welkom.Location = new System.Drawing.Point(372, 165);
            this.Welkom.Name = "Welkom";
            this.Welkom.Size = new System.Drawing.Size(0, 16);
            this.Welkom.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.Registeren);
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.Uitleg);
            this.panel1.Controls.Add(this.Welcome);
            this.panel1.Location = new System.Drawing.Point(12, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1413, 101);
            this.panel1.TabIndex = 2;
            // 
            // Registeren
            // 
            this.Registeren.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Registeren.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registeren.Location = new System.Drawing.Point(1280, 32);
            this.Registeren.Name = "Registeren";
            this.Registeren.Size = new System.Drawing.Size(100, 40);
            this.Registeren.TabIndex = 3;
            this.Registeren.Text = "Registeren";
            this.Registeren.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(1158, 32);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 40);
            this.Login.TabIndex = 2;
            this.Login.Text = "Inloggen";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Uitleg
            // 
            this.Uitleg.AutoSize = true;
            this.Uitleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uitleg.Location = new System.Drawing.Point(16, 69);
            this.Uitleg.Name = "Uitleg";
            this.Uitleg.Size = new System.Drawing.Size(747, 20);
            this.Uitleg.TabIndex = 1;
            this.Uitleg.Text = "In deze applicatie kun je uitdagende nonogram puzzels spelen.  Login of registere" +
    "n om te beginnen.";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(15, 23);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(317, 24);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welkom bij de Nanogram Applicatie";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(455, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 318);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Puzzel2
            // 
            this.Puzzel2.AutoSize = true;
            this.Puzzel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puzzel2.Location = new System.Drawing.Point(515, 555);
            this.Puzzel2.Name = "Puzzel2";
            this.Puzzel2.Size = new System.Drawing.Size(69, 20);
            this.Puzzel2.TabIndex = 4;
            this.Puzzel2.Text = "Puzzel2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(590, 555);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Een uitdagende puzzel met een complex patroon.";
            // 
            // btnPlayNow
            // 
            this.btnPlayNow.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPlayNow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayNow.Location = new System.Drawing.Point(565, 588);
            this.btnPlayNow.Name = "btnPlayNow";
            this.btnPlayNow.Size = new System.Drawing.Size(318, 51);
            this.btnPlayNow.TabIndex = 6;
            this.btnPlayNow.Text = "Speel nu";
            this.btnPlayNow.UseVisualStyleBackColor = false;
            this.btnPlayNow.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(12, 655);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1413, 57);
            this.panel2.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1437, 714);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPlayNow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Puzzel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Welkom);
            this.Controls.Add(this.lblHeader);
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.Text = "Nonogram Game";
            this.lblHeader.ResumeLayout(false);
            this.lblHeader.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel lblHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnProfiel;
        private System.Windows.Forms.Label Welkom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label Uitleg;
        private System.Windows.Forms.Button Registeren;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Puzzel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlayNow;
        private System.Windows.Forms.Panel panel2;
    }
}
