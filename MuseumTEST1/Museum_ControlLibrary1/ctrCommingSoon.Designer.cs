namespace Museum_ControlLibrary1
{
    partial class ctrCommingSoon
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
            this.lblCommingSoon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCommingSoon
            // 
            this.lblCommingSoon.AutoSize = true;
            this.lblCommingSoon.Location = new System.Drawing.Point(328, 138);
            this.lblCommingSoon.Name = "lblCommingSoon";
            this.lblCommingSoon.Size = new System.Drawing.Size(69, 13);
            this.lblCommingSoon.TabIndex = 0;
            this.lblCommingSoon.Text = "جاري العمل..";
            // 
            // ctrCommingSoon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCommingSoon);
            this.Name = "ctrCommingSoon";
            this.Size = new System.Drawing.Size(685, 297);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCommingSoon;
    }
}
