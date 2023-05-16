
namespace prj_pttk_httt
{
    partial class menu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnquanlyphong = new System.Windows.Forms.Button();
            this.btnlapphieuphong = new System.Windows.Forms.Button();
            this.btnpayment = new System.Windows.Forms.Button();
            this.btnsearchservice = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1063, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "menu";
            // 
            // btnquanlyphong
            // 
            this.btnquanlyphong.Location = new System.Drawing.Point(0, 104);
            this.btnquanlyphong.Name = "btnquanlyphong";
            this.btnquanlyphong.Size = new System.Drawing.Size(140, 57);
            this.btnquanlyphong.TabIndex = 1;
            this.btnquanlyphong.Text = "room manager";
            this.btnquanlyphong.UseVisualStyleBackColor = true;
            this.btnquanlyphong.Click += new System.EventHandler(this.btnquanlyphong_Click);
            // 
            // btnlapphieuphong
            // 
            this.btnlapphieuphong.Location = new System.Drawing.Point(146, 104);
            this.btnlapphieuphong.Name = "btnlapphieuphong";
            this.btnlapphieuphong.Size = new System.Drawing.Size(140, 57);
            this.btnlapphieuphong.TabIndex = 2;
            this.btnlapphieuphong.Text = "room reservation";
            this.btnlapphieuphong.UseVisualStyleBackColor = true;
            this.btnlapphieuphong.Click += new System.EventHandler(this.btnlapphieuphong_Click);
            // 
            // btnpayment
            // 
            this.btnpayment.Location = new System.Drawing.Point(292, 104);
            this.btnpayment.Name = "btnpayment";
            this.btnpayment.Size = new System.Drawing.Size(140, 57);
            this.btnpayment.TabIndex = 3;
            this.btnpayment.Text = "payment";
            this.btnpayment.UseVisualStyleBackColor = true;
            this.btnpayment.Click += new System.EventHandler(this.btnpayment_Click);
            // 
            // btnsearchservice
            // 
            this.btnsearchservice.Location = new System.Drawing.Point(438, 104);
            this.btnsearchservice.Name = "btnsearchservice";
            this.btnsearchservice.Size = new System.Drawing.Size(140, 57);
            this.btnsearchservice.TabIndex = 4;
            this.btnsearchservice.Text = "search service";
            this.btnsearchservice.UseVisualStyleBackColor = true;
            this.btnsearchservice.Click += new System.EventHandler(this.btnsearchroom_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 450);
            this.Controls.Add(this.btnsearchservice);
            this.Controls.Add(this.btnpayment);
            this.Controls.Add(this.btnlapphieuphong);
            this.Controls.Add(this.btnquanlyphong);
            this.Controls.Add(this.groupBox1);
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnquanlyphong;
        private System.Windows.Forms.Button btnlapphieuphong;
        private System.Windows.Forms.Button btnpayment;
        private System.Windows.Forms.Button btnsearchservice;
    }
}