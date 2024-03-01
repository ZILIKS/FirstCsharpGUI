
namespace FirstCsharpGUI.GUI.Games
{
    partial class Recoilscript
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
            this.btnSlider = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRainBow = new FontAwesome.Sharp.IconButton();
            this.btnSlider.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSlider
            // 
            this.btnSlider.Controls.Add(this.btnRainBow);
            this.btnSlider.Controls.Add(this.label2);
            this.btnSlider.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSlider.Location = new System.Drawing.Point(0, 0);
            this.btnSlider.Name = "btnSlider";
            this.btnSlider.Size = new System.Drawing.Size(300, 700);
            this.btnSlider.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(80, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "ZILUXE";
            // 
            // btnRainBow
            // 
            this.btnRainBow.FlatAppearance.BorderSize = 0;
            this.btnRainBow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRainBow.Font = new System.Drawing.Font("Arial Narrow", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRainBow.ForeColor = System.Drawing.Color.Crimson;
            this.btnRainBow.IconChar = FontAwesome.Sharp.IconChar.ToriiGate;
            this.btnRainBow.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(88)))), ((int)(((byte)(101)))));
            this.btnRainBow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRainBow.IconSize = 40;
            this.btnRainBow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRainBow.Location = new System.Drawing.Point(63, 120);
            this.btnRainBow.Name = "btnRainBow";
            this.btnRainBow.Size = new System.Drawing.Size(40, 40);
            this.btnRainBow.TabIndex = 1;
            this.btnRainBow.UseVisualStyleBackColor = true;
            // 
            // Recoilscript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.btnSlider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recoilscript";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recoilscript";
            this.btnSlider.ResumeLayout(false);
            this.btnSlider.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btnSlider;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnRainBow;
    }
}