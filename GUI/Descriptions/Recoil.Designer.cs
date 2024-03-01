
namespace FirstCsharpGUI.GUI.Descriptions
{
    partial class Recoil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recoil));
            this.lblscriptdsc = new System.Windows.Forms.Label();
            this.lblArduinodsc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblscriptdsc
            // 
            this.lblscriptdsc.AutoSize = true;
            this.lblscriptdsc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscriptdsc.ForeColor = System.Drawing.Color.Crimson;
            this.lblscriptdsc.Location = new System.Drawing.Point(142, 20);
            this.lblscriptdsc.Name = "lblscriptdsc";
            this.lblscriptdsc.Size = new System.Drawing.Size(207, 37);
            this.lblscriptdsc.TabIndex = 2;
            this.lblscriptdsc.Text = "Arduino Info";
            this.lblscriptdsc.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblArduinodsc
            // 
            this.lblArduinodsc.AutoSize = true;
            this.lblArduinodsc.Font = new System.Drawing.Font("Arial Narrow", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArduinodsc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(88)))), ((int)(((byte)(101)))));
            this.lblArduinodsc.Location = new System.Drawing.Point(29, 85);
            this.lblArduinodsc.Name = "lblArduinodsc";
            this.lblArduinodsc.Size = new System.Drawing.Size(424, 150);
            this.lblArduinodsc.TabIndex = 3;
            this.lblArduinodsc.Text = resources.GetString("lblArduinodsc.Text");
            this.lblArduinodsc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblArduinodsc.Click += new System.EventHandler(this.lblArduinodsc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(88)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(12, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Developed By: ZILIKS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Recoil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(493, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblArduinodsc);
            this.Controls.Add(this.lblscriptdsc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recoil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recoil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblscriptdsc;
        private System.Windows.Forms.Label lblArduinodsc;
        private System.Windows.Forms.Label label1;
    }
}