
namespace FirstCsharpGUI
{
    partial class Loader
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
            this.pnlSelection = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.btnRainBow = new FontAwesome.Sharp.IconButton();
            this.btnStart = new FontAwesome.Sharp.IconButton();
            this.lblgameselection = new System.Windows.Forms.Label();
            this.ptbDiscord = new FirstCsharpGUI.Classes.RoundedPictureBox();
            this.pnlSelection.SuspendLayout();
            this.pnlDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDiscord)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelection
            // 
            this.pnlSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(45)))));
            this.pnlSelection.Controls.Add(this.label1);
            this.pnlSelection.Controls.Add(this.label3);
            this.pnlSelection.Controls.Add(this.label2);
            this.pnlSelection.Controls.Add(this.btnRainBow);
            this.pnlSelection.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSelection.Location = new System.Drawing.Point(0, 0);
            this.pnlSelection.Name = "pnlSelection";
            this.pnlSelection.Size = new System.Drawing.Size(205, 323);
            this.pnlSelection.TabIndex = 0;
            this.pnlSelection.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pnlSelection.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSelection_MouseDown);
            this.pnlSelection.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlSelection_MouseMove);
            this.pnlSelection.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlSelection_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(39, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "ZILUXE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(70, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "ZILIKS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(66, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Undected";
            // 
            // pnlDescription
            // 
            this.pnlDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlDescription.Controls.Add(this.btnStart);
            this.pnlDescription.Controls.Add(this.lblgameselection);
            this.pnlDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDescription.Location = new System.Drawing.Point(205, 0);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(493, 323);
            this.pnlDescription.TabIndex = 1;
            // 
            // btnRainBow
            // 
            this.btnRainBow.FlatAppearance.BorderSize = 0;
            this.btnRainBow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRainBow.Font = new System.Drawing.Font("Arial Narrow", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRainBow.ForeColor = System.Drawing.Color.Crimson;
            this.btnRainBow.IconChar = FontAwesome.Sharp.IconChar.Crosshairs;
            this.btnRainBow.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(88)))), ((int)(((byte)(101)))));
            this.btnRainBow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRainBow.IconSize = 40;
            this.btnRainBow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRainBow.Location = new System.Drawing.Point(12, 114);
            this.btnRainBow.Name = "btnRainBow";
            this.btnRainBow.Size = new System.Drawing.Size(175, 65);
            this.btnRainBow.TabIndex = 0;
            this.btnRainBow.Text = "RECOIL";
            this.btnRainBow.UseVisualStyleBackColor = true;
            this.btnRainBow.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Arial Narrow", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Crimson;
            this.btnStart.IconChar = FontAwesome.Sharp.IconChar.Hourglass1;
            this.btnStart.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(88)))), ((int)(((byte)(101)))));
            this.btnStart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStart.IconSize = 30;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(170, 255);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(175, 65);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "LOAD";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblgameselection
            // 
            this.lblgameselection.AutoSize = true;
            this.lblgameselection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.lblgameselection.Location = new System.Drawing.Point(6, 9);
            this.lblgameselection.Name = "lblgameselection";
            this.lblgameselection.Size = new System.Drawing.Size(65, 25);
            this.lblgameselection.TabIndex = 6;
            this.lblgameselection.Text = "game";
            // 
            // ptbDiscord
            // 
            this.ptbDiscord.Image = global::FirstCsharpGUI.Properties.Resources.discord_logo_7A1EC3216C_seeklogo_com;
            this.ptbDiscord.Location = new System.Drawing.Point(12, 245);
            this.ptbDiscord.Name = "ptbDiscord";
            this.ptbDiscord.Size = new System.Drawing.Size(45, 45);
            this.ptbDiscord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDiscord.TabIndex = 2;
            this.ptbDiscord.TabStop = false;
            this.ptbDiscord.Click += new System.EventHandler(this.roundedPictureBox1_Click_1);
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(698, 323);
            this.Controls.Add(this.pnlDescription);
            this.Controls.Add(this.pnlSelection);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZILIKS";
            this.pnlSelection.ResumeLayout(false);
            this.pnlSelection.PerformLayout();
            this.pnlDescription.ResumeLayout(false);
            this.pnlDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDiscord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSelection;
        private FontAwesome.Sharp.IconButton btnRainBow;
        private System.Windows.Forms.Label label2;
        private Classes.RoundedPictureBox ptbDiscord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlDescription;
        private FontAwesome.Sharp.IconButton btnStart;
        private System.Windows.Forms.Label lblgameselection;
    }
}

