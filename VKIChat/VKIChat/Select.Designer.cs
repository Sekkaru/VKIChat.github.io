namespace VKIChat
{
    partial class Select
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
            this.ConfList = new System.Windows.Forms.Label();
            this.UsernameField = new System.Windows.Forms.Label();
            this.CreateConfBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConfList
            // 
            this.ConfList.AutoSize = true;
            this.ConfList.Location = new System.Drawing.Point(12, 67);
            this.ConfList.Name = "ConfList";
            this.ConfList.Size = new System.Drawing.Size(80, 13);
            this.ConfList.TabIndex = 0;
            this.ConfList.Text = "Список бесед:";
            // 
            // UsernameField
            // 
            this.UsernameField.AutoSize = true;
            this.UsernameField.Location = new System.Drawing.Point(459, 9);
            this.UsernameField.Name = "UsernameField";
            this.UsernameField.Size = new System.Drawing.Size(83, 13);
            this.UsernameField.TabIndex = 1;
            this.UsernameField.Text = "Пользователь:";
            // 
            // CreateConfBtn
            // 
            this.CreateConfBtn.Location = new System.Drawing.Point(15, 13);
            this.CreateConfBtn.Name = "CreateConfBtn";
            this.CreateConfBtn.Size = new System.Drawing.Size(116, 37);
            this.CreateConfBtn.TabIndex = 2;
            this.CreateConfBtn.Text = "Добавить беседу";
            this.CreateConfBtn.UseVisualStyleBackColor = true;
            this.CreateConfBtn.Click += new System.EventHandler(this.CreateConfBtn_Click);
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateConfBtn);
            this.Controls.Add(this.UsernameField);
            this.Controls.Add(this.ConfList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Select";
            this.Text = "Выбор чата";
            this.Load += new System.EventHandler(this.Select_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConfList;
        private System.Windows.Forms.Label UsernameField;
        private System.Windows.Forms.Button CreateConfBtn;
    }
}