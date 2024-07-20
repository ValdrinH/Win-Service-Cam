namespace WinServiceCamera
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
            this.filePath = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filePath
            // 
            this.filePath.AutoSize = true;
            this.filePath.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePath.ForeColor = System.Drawing.SystemColors.Control;
            this.filePath.Location = new System.Drawing.Point(84, 21);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(265, 37);
            this.filePath.TabIndex = 10;
            this.filePath.Text = "Show web cam activity";
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(103)))), ((int)(((byte)(187)))));
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSend.Location = new System.Drawing.Point(112, 172);
            this.buttonSend.MaximumSize = new System.Drawing.Size(211, 35);
            this.buttonSend.MinimumSize = new System.Drawing.Size(211, 35);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(211, 35);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "Create Service";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Poppins SemiBold", 8.75F, System.Drawing.FontStyle.Bold);
            this.label.ForeColor = System.Drawing.SystemColors.Control;
            this.label.Location = new System.Drawing.Point(16, 104);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(413, 22);
            this.label.TabIndex = 11;
            this.label.Text = "With this service you will be able to see when your camera is open.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(441, 232);
            this.Controls.Add(this.label);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.buttonSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filePath;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label;
    }
}

