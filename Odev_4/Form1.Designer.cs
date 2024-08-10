namespace Odev_4
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
            label1 = new Label();
            label2 = new Label();
            cmbLog = new ComboBox();
            txtDurum = new TextBox();
            btnLog = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 68);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Log Tipi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 119);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Durum";
            // 
            // cmbLog
            // 
            cmbLog.FormattingEnabled = true;
            cmbLog.Items.AddRange(new object[] { "Seçiniz", "DbLog", "XmlLog", "JsonLog" });
            cmbLog.Location = new Point(224, 67);
            cmbLog.Name = "cmbLog";
            cmbLog.Size = new Size(121, 23);
            cmbLog.TabIndex = 2;
            // 
            // txtDurum
            // 
            txtDurum.Location = new Point(224, 119);
            txtDurum.Name = "txtDurum";
            txtDurum.Size = new Size(100, 23);
            txtDurum.TabIndex = 3;
            // 
            // btnLog
            // 
            btnLog.Location = new Point(224, 188);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(121, 36);
            btnLog.TabIndex = 4;
            btnLog.Text = "LOG GETİR";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(124, 264);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(40, 15);
            lblSonuc.TabIndex = 5;
            lblSonuc.Text = "Sonuç";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSonuc);
            Controls.Add(btnLog);
            Controls.Add(txtDurum);
            Controls.Add(cmbLog);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbLog;
        private TextBox txtDurum;
        private Button btnLog;
        private Label lblSonuc;
    }
}
