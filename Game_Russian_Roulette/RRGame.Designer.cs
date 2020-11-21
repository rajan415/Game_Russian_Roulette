namespace Game_Russian_Roulette
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
            this.Btn_Load = new System.Windows.Forms.Button();
            this.Btn_Spin = new System.Windows.Forms.Button();
            this.Btn_ShootAt = new System.Windows.Forms.Button();
            this.Btn_ShootHd = new System.Windows.Forms.Button();
            this.Btn_PlayAgn = new System.Windows.Forms.Button();
            this.Game_ImageBox = new System.Windows.Forms.PictureBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Game_ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Load
            // 
            this.Btn_Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Btn_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Load.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Load.Location = new System.Drawing.Point(13, 469);
            this.Btn_Load.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Load.Name = "Btn_Load";
            this.Btn_Load.Size = new System.Drawing.Size(133, 72);
            this.Btn_Load.TabIndex = 0;
            this.Btn_Load.Text = "Load";
            this.Btn_Load.UseVisualStyleBackColor = false;
            this.Btn_Load.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // Btn_Spin
            // 
            this.Btn_Spin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Btn_Spin.Enabled = false;
            this.Btn_Spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Spin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Spin.Location = new System.Drawing.Point(154, 469);
            this.Btn_Spin.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Spin.Name = "Btn_Spin";
            this.Btn_Spin.Size = new System.Drawing.Size(123, 72);
            this.Btn_Spin.TabIndex = 1;
            this.Btn_Spin.Text = "Spin";
            this.Btn_Spin.UseVisualStyleBackColor = false;
            this.Btn_Spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // Btn_ShootAt
            // 
            this.Btn_ShootAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Btn_ShootAt.Enabled = false;
            this.Btn_ShootAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ShootAt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_ShootAt.Location = new System.Drawing.Point(285, 469);
            this.Btn_ShootAt.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ShootAt.Name = "Btn_ShootAt";
            this.Btn_ShootAt.Size = new System.Drawing.Size(184, 72);
            this.Btn_ShootAt.TabIndex = 2;
            this.Btn_ShootAt.Text = "Shoot At head";
            this.Btn_ShootAt.UseVisualStyleBackColor = false;
            this.Btn_ShootAt.Click += new System.EventHandler(this.ShootAt_Click);
            // 
            // Btn_ShootHd
            // 
            this.Btn_ShootHd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Btn_ShootHd.Enabled = false;
            this.Btn_ShootHd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ShootHd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_ShootHd.Location = new System.Drawing.Point(486, 469);
            this.Btn_ShootHd.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ShootHd.Name = "Btn_ShootHd";
            this.Btn_ShootHd.Size = new System.Drawing.Size(166, 72);
            this.Btn_ShootHd.TabIndex = 3;
            this.Btn_ShootHd.Text = "Shoot Away";
            this.Btn_ShootHd.UseVisualStyleBackColor = false;
            this.Btn_ShootHd.Click += new System.EventHandler(this.ShootHd_Click);
            // 
            // Btn_PlayAgn
            // 
            this.Btn_PlayAgn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Btn_PlayAgn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PlayAgn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_PlayAgn.Location = new System.Drawing.Point(677, 469);
            this.Btn_PlayAgn.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_PlayAgn.Name = "Btn_PlayAgn";
            this.Btn_PlayAgn.Size = new System.Drawing.Size(182, 72);
            this.Btn_PlayAgn.TabIndex = 4;
            this.Btn_PlayAgn.Text = "Try again";
            this.Btn_PlayAgn.UseVisualStyleBackColor = false;
            this.Btn_PlayAgn.Click += new System.EventHandler(this.PLyAgn_Click);
            // 
            // Game_ImageBox
            // 
            this.Game_ImageBox.BackColor = System.Drawing.Color.White;
            this.Game_ImageBox.Location = new System.Drawing.Point(13, 13);
            this.Game_ImageBox.Margin = new System.Windows.Forms.Padding(4);
            this.Game_ImageBox.Name = "Game_ImageBox";
            this.Game_ImageBox.Size = new System.Drawing.Size(1026, 437);
            this.Game_ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Game_ImageBox.TabIndex = 5;
            this.Game_ImageBox.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Exit.Location = new System.Drawing.Point(880, 469);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(159, 72);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.Btn_PlayAgn);
            this.Controls.Add(this.Btn_ShootHd);
            this.Controls.Add(this.Btn_ShootAt);
            this.Controls.Add(this.Btn_Spin);
            this.Controls.Add(this.Btn_Load);
            this.Controls.Add(this.Game_ImageBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Game Form";
            ((System.ComponentModel.ISupportInitialize)(this.Game_ImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Load;
        private System.Windows.Forms.Button Btn_Spin;
        private System.Windows.Forms.Button Btn_ShootAt;
        private System.Windows.Forms.Button Btn_ShootHd;
        private System.Windows.Forms.Button Btn_PlayAgn;
        private System.Windows.Forms.PictureBox Game_ImageBox;
        private System.Windows.Forms.Button btn_Exit;
    }
}

