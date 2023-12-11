namespace Hasan.Badr_harjoitus5
{
    partial class LukujenJarjestys
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
            UusiLukuTB = new TextBox();
            VastausLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(245, 30);
            label1.TabIndex = 0;
            label1.Text = "Anna luku (-999 lopetus):";
            // 
            // UusiLukuTB
            // 
            UusiLukuTB.Location = new Point(272, 18);
            UusiLukuTB.Name = "UusiLukuTB";
            UusiLukuTB.Size = new Size(193, 35);
            UusiLukuTB.TabIndex = 1;
            UusiLukuTB.KeyPress += UusiLukuTB_KeyPress;
            // 
            // VastausLB
            // 
            VastausLB.AllowDrop = true;
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(21, 65);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(83, 30);
            VastausLB.TabIndex = 2;
            VastausLB.Text = "Vastaus";
            VastausLB.UseWaitCursor = true;
            VastausLB.Visible = false;
            // 
            // LukujenJarjestys
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 119);
            Controls.Add(VastausLB);
            Controls.Add(UusiLukuTB);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "LukujenJarjestys";
            Text = "Lukujen jäärjestys";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox UusiLukuTB;
        private Label VastausLB;
    }
}