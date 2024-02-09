namespace PlayGameCounter
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
            this.Play = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GameStartIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Black;
            this.Play.Font = new System.Drawing.Font("Stencil", 25F);
            this.Play.ForeColor = System.Drawing.Color.White;
            this.Play.Location = new System.Drawing.Point(285, 147);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(228, 106);
            this.Play.TabIndex = 0;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // GameStartIn
            // 
            this.GameStartIn.AutoSize = true;
            this.GameStartIn.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameStartIn.ForeColor = System.Drawing.Color.Lime;
            this.GameStartIn.Location = new System.Drawing.Point(290, 327);
            this.GameStartIn.Name = "GameStartIn";
            this.GameStartIn.Size = new System.Drawing.Size(205, 24);
            this.GameStartIn.TabIndex = 2;
            this.GameStartIn.Text = "Game Starts In:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.GameStartIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Play);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GameStartIn;
    }
}

