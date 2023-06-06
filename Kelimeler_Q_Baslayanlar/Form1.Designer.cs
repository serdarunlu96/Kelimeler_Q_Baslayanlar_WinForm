namespace Kelimeler_Q_Baslayanlar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnKelimeQ = new Button();
            lstSonuc = new ListBox();
            SuspendLayout();
            // 
            // btnKelimeQ
            // 
            btnKelimeQ.Location = new Point(25, 342);
            btnKelimeQ.Name = "btnKelimeQ";
            btnKelimeQ.Size = new Size(235, 23);
            btnKelimeQ.TabIndex = 1;
            btnKelimeQ.Text = "Q Ile Baslayanları Goster";
            btnKelimeQ.UseVisualStyleBackColor = true;
            btnKelimeQ.Click += btnKelimeQ_Click;
            // 
            // lstSonuc
            // 
            lstSonuc.FormattingEnabled = true;
            lstSonuc.ItemHeight = 15;
            lstSonuc.Location = new Point(25, 29);
            lstSonuc.Name = "lstSonuc";
            lstSonuc.Size = new Size(235, 289);
            lstSonuc.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 395);
            Controls.Add(lstSonuc);
            Controls.Add(btnKelimeQ);
            Name = "Form1";
            Text = "Q Ile Baslayanlar";
            ResumeLayout(false);
        }

        #endregion
        private Button btnKelimeQ;
        private ListBox lstSonuc;
    }
}