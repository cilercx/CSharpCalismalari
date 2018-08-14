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
            this.components = new System.ComponentModel.Container();
            this.txtGirilenDeger = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnmvsmkntrl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGirilenDeger
            // 
            this.txtGirilenDeger.Location = new System.Drawing.Point(32, 28);
            this.txtGirilenDeger.Name = "txtGirilenDeger";
            this.txtGirilenDeger.Size = new System.Drawing.Size(160, 20);
            this.txtGirilenDeger.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnmvsmkntrl
            // 
            this.btnmvsmkntrl.Location = new System.Drawing.Point(32, 69);
            this.btnmvsmkntrl.Name = "btnmvsmkntrl";
            this.btnmvsmkntrl.Size = new System.Drawing.Size(160, 23);
            this.btnmvsmkntrl.TabIndex = 2;
            this.btnmvsmkntrl.Text = "Mevsim Kontrolü";
            this.btnmvsmkntrl.UseVisualStyleBackColor = true;
            this.btnmvsmkntrl.Click += new System.EventHandler(this.btnmvsmkntrl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 229);
            this.Controls.Add(this.btnmvsmkntrl);
            this.Controls.Add(this.txtGirilenDeger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGirilenDeger;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnmvsmkntrl;
    }
}

