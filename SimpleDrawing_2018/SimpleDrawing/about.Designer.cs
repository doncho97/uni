namespace SimpleDrawing
{
    partial class about
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
            this.btnOk = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.fNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(139, 112);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(136, 45);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(77, 13);
            this.name.TabIndex = 1;
            this.name.Text = "Андон Райчев";
            // 
            // fNumber
            // 
            this.fNumber.AutoSize = true;
            this.fNumber.Location = new System.Drawing.Point(112, 79);
            this.fNumber.Name = "fNumber";
            this.fNumber.Size = new System.Drawing.Size(131, 13);
            this.fNumber.TabIndex = 2;
            this.fNumber.Text = "Фак. номер:1601261084";
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 165);
            this.Controls.Add(this.fNumber);
            this.Controls.Add(this.name);
            this.Controls.Add(this.btnOk);
            this.Name = "about";
            this.Text = "Аbout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label fNumber;
    }
}