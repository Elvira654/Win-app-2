namespace WindowsFormsApplication1
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
            this.Programiranje = new System.Windows.Forms.CheckBox();
            this.Web_programiranje = new System.Windows.Forms.CheckBox();
            this.Dig_tehnika = new System.Windows.Forms.CheckBox();
            this.Izaberi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Programiranje
            // 
            this.Programiranje.AutoSize = true;
            this.Programiranje.Location = new System.Drawing.Point(25, 37);
            this.Programiranje.Name = "Programiranje";
            this.Programiranje.Size = new System.Drawing.Size(90, 17);
            this.Programiranje.TabIndex = 0;
            this.Programiranje.Text = "Programiranje";
            this.Programiranje.UseVisualStyleBackColor = true;
            // 
            // Web_programiranje
            // 
            this.Web_programiranje.AutoSize = true;
            this.Web_programiranje.Location = new System.Drawing.Point(25, 71);
            this.Web_programiranje.Name = "Web_programiranje";
            this.Web_programiranje.Size = new System.Drawing.Size(117, 17);
            this.Web_programiranje.TabIndex = 1;
            this.Web_programiranje.Text = "WEB programiranje";
            this.Web_programiranje.UseVisualStyleBackColor = true;
            // 
            // Dig_tehnika
            // 
            this.Dig_tehnika.AutoSize = true;
            this.Dig_tehnika.Location = new System.Drawing.Point(25, 103);
            this.Dig_tehnika.Name = "Dig_tehnika";
            this.Dig_tehnika.Size = new System.Drawing.Size(105, 17);
            this.Dig_tehnika.TabIndex = 2;
            this.Dig_tehnika.Text = "Digitalna tehnika";
            this.Dig_tehnika.UseVisualStyleBackColor = true;
            // 
            // Izaberi
            // 
            this.Izaberi.Location = new System.Drawing.Point(99, 182);
            this.Izaberi.Name = "Izaberi";
            this.Izaberi.Size = new System.Drawing.Size(75, 23);
            this.Izaberi.TabIndex = 3;
            this.Izaberi.Text = "&IZABERI";
            this.Izaberi.UseVisualStyleBackColor = true;
            this.Izaberi.Click += new System.EventHandler(this.Izaberi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Izaberi);
            this.Controls.Add(this.Dig_tehnika);
            this.Controls.Add(this.Web_programiranje);
            this.Controls.Add(this.Programiranje);
            this.Name = "Form1";
            this.Text = "Odabir predmeta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Programiranje;
        private System.Windows.Forms.CheckBox Web_programiranje;
        private System.Windows.Forms.CheckBox Dig_tehnika;
        private System.Windows.Forms.Button Izaberi;
    }
}

