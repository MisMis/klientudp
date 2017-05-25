namespace klientudp
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
            this.adres = new System.Windows.Forms.TextBox();
            this.wiadomosc = new System.Windows.Forms.TextBox();
            this.my_port = new System.Windows.Forms.NumericUpDown();
            this.wyslij = new System.Windows.Forms.Button();
            this.info_o_polaczeniu = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).BeginInit();
            this.SuspendLayout();
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(30, 12);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(248, 20);
            this.adres.TabIndex = 0;
            this.adres.Text = "adres";
            // 
            // wiadomosc
            // 
            this.wiadomosc.Location = new System.Drawing.Point(30, 187);
            this.wiadomosc.Multiline = true;
            this.wiadomosc.Name = "wiadomosc";
            this.wiadomosc.Size = new System.Drawing.Size(571, 132);
            this.wiadomosc.TabIndex = 1;
            this.wiadomosc.Text = "wpisz wiadomosc";
            // 
            // my_port
            // 
            this.my_port.Location = new System.Drawing.Point(318, 13);
            this.my_port.Maximum = new decimal(new int[] {
            65565,
            0,
            0,
            0});
            this.my_port.Name = "my_port";
            this.my_port.Size = new System.Drawing.Size(283, 20);
            this.my_port.TabIndex = 2;
            // 
            // wyslij
            // 
            this.wyslij.Location = new System.Drawing.Point(150, 344);
            this.wyslij.Name = "wyslij";
            this.wyslij.Size = new System.Drawing.Size(316, 70);
            this.wyslij.TabIndex = 3;
            this.wyslij.Text = "wyslij";
            this.wyslij.UseVisualStyleBackColor = true;
            // 
            // info_o_polaczeniu
            // 
            this.info_o_polaczeniu.FormattingEnabled = true;
            this.info_o_polaczeniu.Location = new System.Drawing.Point(30, 60);
            this.info_o_polaczeniu.Name = "info_o_polaczeniu";
            this.info_o_polaczeniu.Size = new System.Drawing.Size(571, 95);
            this.info_o_polaczeniu.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 448);
            this.Controls.Add(this.info_o_polaczeniu);
            this.Controls.Add(this.wyslij);
            this.Controls.Add(this.my_port);
            this.Controls.Add(this.wiadomosc);
            this.Controls.Add(this.adres);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.TextBox wiadomosc;
        private System.Windows.Forms.NumericUpDown my_port;
        private System.Windows.Forms.Button wyslij;
        private System.Windows.Forms.ListBox info_o_polaczeniu;
    }
}

