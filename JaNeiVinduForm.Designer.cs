namespace JaNeiVindu
{
    partial class JaNeiForm
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
            this.buttonJa = new System.Windows.Forms.Button();
            this.buttonNei = new System.Windows.Forms.Button();
            this.labelTekst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonJa
            // 
            this.buttonJa.Location = new System.Drawing.Point(12, 12);
            this.buttonJa.Name = "buttonJa";
            this.buttonJa.Size = new System.Drawing.Size(126, 76);
            this.buttonJa.TabIndex = 0;
            this.buttonJa.Text = "Ja";
            this.buttonJa.UseVisualStyleBackColor = true;
            this.buttonJa.Click += new System.EventHandler(this.ButtonJa_Click);
            // 
            // buttonNei
            // 
            this.buttonNei.Location = new System.Drawing.Point(176, 12);
            this.buttonNei.Name = "buttonNei";
            this.buttonNei.Size = new System.Drawing.Size(127, 75);
            this.buttonNei.TabIndex = 1;
            this.buttonNei.Text = "Nei";
            this.buttonNei.UseVisualStyleBackColor = true;
            this.buttonNei.Click += new System.EventHandler(this.ButtonNei_Click);
            // 
            // labelTekst
            // 
            this.labelTekst.AutoSize = true;
            this.labelTekst.Location = new System.Drawing.Point(16, 118);
            this.labelTekst.Name = "labelTekst";
            this.labelTekst.Size = new System.Drawing.Size(0, 13);
            this.labelTekst.TabIndex = 2;
            // 
            // JaNeiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 266);
            this.Controls.Add(this.labelTekst);
            this.Controls.Add(this.buttonNei);
            this.Controls.Add(this.buttonJa);
            this.Name = "JaNeiForm";
            this.Text = "JaNeiForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonJa;
        private System.Windows.Forms.Button buttonNei;
        private System.Windows.Forms.Label labelTekst;
    }
}
