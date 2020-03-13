namespace smartcart_1
{
    partial class ProductModify
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMdfy = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "상품 수정";
            // 
            // btnMdfy
            // 
            this.btnMdfy.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMdfy.FlatAppearance.BorderSize = 0;
            this.btnMdfy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMdfy.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMdfy.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMdfy.Location = new System.Drawing.Point(84, 361);
            this.btnMdfy.Name = "btnMdfy";
            this.btnMdfy.Size = new System.Drawing.Size(90, 34);
            this.btnMdfy.TabIndex = 2;
            this.btnMdfy.Text = "수정";
            this.btnMdfy.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(193, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 34);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // ProductModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(375, 454);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMdfy);
            this.Controls.Add(this.label1);
            this.Name = "ProductModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "상품수정";
            this.Load += new System.EventHandler(this.ProductModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMdfy;
        private System.Windows.Forms.Button btnCancel;
    }
}