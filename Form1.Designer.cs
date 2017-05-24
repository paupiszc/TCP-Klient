namespace TCP_Klient
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
            this.Adres = new System.Windows.Forms.TextBox();
            this.MyPort = new System.Windows.Forms.NumericUpDown();
            this.Info_o_polaczeniu = new System.Windows.Forms.ListBox();
            this.przycisk_polacz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MyPort)).BeginInit();
            this.SuspendLayout();
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(12, 12);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(394, 20);
            this.Adres.TabIndex = 0;
            this.Adres.Text = "Adres";
            // 
            // MyPort
            // 
            this.MyPort.Location = new System.Drawing.Point(445, 12);
            this.MyPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.MyPort.Name = "MyPort";
            this.MyPort.Size = new System.Drawing.Size(339, 20);
            this.MyPort.TabIndex = 1;
            // 
            // Info_o_polaczeniu
            // 
            this.Info_o_polaczeniu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Info_o_polaczeniu.FormattingEnabled = true;
            this.Info_o_polaczeniu.ItemHeight = 24;
            this.Info_o_polaczeniu.Location = new System.Drawing.Point(12, 44);
            this.Info_o_polaczeniu.Name = "Info_o_polaczeniu";
            this.Info_o_polaczeniu.Size = new System.Drawing.Size(772, 364);
            this.Info_o_polaczeniu.TabIndex = 2;
            // 
            // przycisk_polacz
            // 
            this.przycisk_polacz.Location = new System.Drawing.Point(319, 414);
            this.przycisk_polacz.Name = "przycisk_polacz";
            this.przycisk_polacz.Size = new System.Drawing.Size(196, 55);
            this.przycisk_polacz.TabIndex = 3;
            this.przycisk_polacz.Text = "Połącz";
            this.przycisk_polacz.UseVisualStyleBackColor = true;
            this.przycisk_polacz.Click += new System.EventHandler(this.przycisk_polacz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 474);
            this.Controls.Add(this.przycisk_polacz);
            this.Controls.Add(this.Info_o_polaczeniu);
            this.Controls.Add(this.MyPort);
            this.Controls.Add(this.Adres);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MyPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.NumericUpDown MyPort;
        private System.Windows.Forms.ListBox Info_o_polaczeniu;
        private System.Windows.Forms.Button przycisk_polacz;
    }
}

