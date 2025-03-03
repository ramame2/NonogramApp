namespace NonogramApp.Views
{
    partial class SizeSelectionForm
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
            this.btn5x5 = new System.Windows.Forms.Button();
            this.btn10x10 = new System.Windows.Forms.Button();
            this.btn20x20 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "kies een level";
            // 
            // btn5x5
            // 
            this.btn5x5.Location = new System.Drawing.Point(274, 303);
            this.btn5x5.Name = "btn5x5";
            this.btn5x5.Size = new System.Drawing.Size(114, 63);
            this.btn5x5.TabIndex = 1;
            this.btn5x5.Text = "5*5";
            this.btn5x5.UseVisualStyleBackColor = true;
            // 
            // btn10x10
            // 
            this.btn10x10.Location = new System.Drawing.Point(493, 303);
            this.btn10x10.Name = "btn10x10";
            this.btn10x10.Size = new System.Drawing.Size(119, 63);
            this.btn10x10.TabIndex = 2;
            this.btn10x10.Text = "10*10";
            this.btn10x10.UseVisualStyleBackColor = true;
            // 
            // btn20x20
            // 
            this.btn20x20.Location = new System.Drawing.Point(699, 303);
            this.btn20x20.Name = "btn20x20";
            this.btn20x20.Size = new System.Drawing.Size(133, 63);
            this.btn20x20.TabIndex = 3;
            this.btn20x20.Text = "20*20";
            this.btn20x20.UseVisualStyleBackColor = true;
            // 
            // SizeSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 667);
            this.Controls.Add(this.btn20x20);
            this.Controls.Add(this.btn10x10);
            this.Controls.Add(this.btn5x5);
            this.Controls.Add(this.label1);
            this.Name = "SizeSelectionForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn5x5;
        private System.Windows.Forms.Button btn10x10;
        private System.Windows.Forms.Button btn20x20;
    }
}