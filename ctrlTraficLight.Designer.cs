namespace WindowsFormsApp1
{
    partial class ctrlTraficLight
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.pbLight = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbLight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(34, 268);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 38);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "??";
            // 
            // pbLight
            // 
            this.pbLight.Image = global::WindowsFormsApp1.Properties.Resources.Red;
            this.pbLight.Location = new System.Drawing.Point(14, 15);
            this.pbLight.Name = "pbLight";
            this.pbLight.Size = new System.Drawing.Size(100, 226);
            this.pbLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLight.TabIndex = 2;
            this.pbLight.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pbLight);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(131, 318);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pbLight;
        private System.Windows.Forms.Timer timer1;
    }
}
