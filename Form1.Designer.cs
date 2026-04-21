namespace WindowsFormsApp1
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
            this.userControl21 = new WindowsFormsApp1.ctrlTraficLight();
            this.SuspendLayout();
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.White;
            this.userControl21.CurrentLight = WindowsFormsApp1.ctrlTraficLight.enTrafficLight.Red;
            this.userControl21.GreenTime = 5;
            this.userControl21.Location = new System.Drawing.Point(306, 12);
            this.userControl21.Name = "userControl21";
            this.userControl21.OrangeTime = 5;
            this.userControl21.RedTime = 2;
            this.userControl21.Size = new System.Drawing.Size(150, 368);
            this.userControl21.TabIndex = 0;
            this.userControl21.RedLightOn += new System.EventHandler<WindowsFormsApp1.ctrlTraficLight.TraficLightEventArgs>(this.userControl21_RedLightOn);
            this.userControl21.GreenLightOn += new System.EventHandler<WindowsFormsApp1.ctrlTraficLight.TraficLightEventArgs>(this.userControl21_GreenLightOn);
            this.userControl21.OrangeLightOn += new System.EventHandler<WindowsFormsApp1.ctrlTraficLight.TraficLightEventArgs>(this.userControl21_OrangeLightOn);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl21);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTraficLight userControl21;
    }
}

