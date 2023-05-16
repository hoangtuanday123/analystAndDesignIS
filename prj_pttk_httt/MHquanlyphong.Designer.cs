
namespace prj_pttk_httt
{
    partial class MHquanlyphong
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbbloaiphong = new System.Windows.Forms.ComboBox();
            this.dgvdsphong = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtidphong = new System.Windows.Forms.TextBox();
            this.txtloaiphong = new System.Windows.Forms.TextBox();
            this.txttinhtrang = new System.Windows.Forms.TextBox();
            this.txttrangthaidichvu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btninsertphong = new System.Windows.Forms.Button();
            this.btnupdatephong = new System.Windows.Forms.Button();
            this.btndeletephong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsphong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1063, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "room manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "type room";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbbloaiphong
            // 
            this.cbbloaiphong.FormattingEnabled = true;
            this.cbbloaiphong.Location = new System.Drawing.Point(51, 118);
            this.cbbloaiphong.Margin = new System.Windows.Forms.Padding(4);
            this.cbbloaiphong.Name = "cbbloaiphong";
            this.cbbloaiphong.Size = new System.Drawing.Size(160, 24);
            this.cbbloaiphong.TabIndex = 2;
            this.cbbloaiphong.SelectedIndexChanged += new System.EventHandler(this.cbbloaiphong_SelectedIndexChanged);
            // 
            // dgvdsphong
            // 
            this.dgvdsphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsphong.Location = new System.Drawing.Point(51, 151);
            this.dgvdsphong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdsphong.Name = "dgvdsphong";
            this.dgvdsphong.RowHeadersWidth = 51;
            this.dgvdsphong.Size = new System.Drawing.Size(759, 185);
            this.dgvdsphong.TabIndex = 3;
            this.dgvdsphong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdsphong_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtidphong);
            this.groupBox2.Controls.Add(this.txtloaiphong);
            this.groupBox2.Controls.Add(this.txttinhtrang);
            this.groupBox2.Controls.Add(this.txttrangthaidichvu);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(51, 354);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(759, 244);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // txtidphong
            // 
            this.txtidphong.Location = new System.Drawing.Point(212, 30);
            this.txtidphong.Margin = new System.Windows.Forms.Padding(4);
            this.txtidphong.Name = "txtidphong";
            this.txtidphong.ReadOnly = true;
            this.txtidphong.Size = new System.Drawing.Size(332, 22);
            this.txtidphong.TabIndex = 7;
            // 
            // txtloaiphong
            // 
            this.txtloaiphong.Location = new System.Drawing.Point(212, 78);
            this.txtloaiphong.Margin = new System.Windows.Forms.Padding(4);
            this.txtloaiphong.Name = "txtloaiphong";
            this.txtloaiphong.Size = new System.Drawing.Size(332, 22);
            this.txtloaiphong.TabIndex = 6;
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.Location = new System.Drawing.Point(212, 129);
            this.txttinhtrang.Margin = new System.Windows.Forms.Padding(4);
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(332, 22);
            this.txttinhtrang.TabIndex = 5;
            // 
            // txttrangthaidichvu
            // 
            this.txttrangthaidichvu.Location = new System.Drawing.Point(212, 196);
            this.txttrangthaidichvu.Margin = new System.Windows.Forms.Padding(4);
            this.txttrangthaidichvu.Name = "txttrangthaidichvu";
            this.txttrangthaidichvu.Size = new System.Drawing.Size(332, 22);
            this.txttrangthaidichvu.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Status service";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Status";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Type room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id room";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btninsertphong
            // 
            this.btninsertphong.Location = new System.Drawing.Point(900, 394);
            this.btninsertphong.Margin = new System.Windows.Forms.Padding(4);
            this.btninsertphong.Name = "btninsertphong";
            this.btninsertphong.Size = new System.Drawing.Size(100, 28);
            this.btninsertphong.TabIndex = 5;
            this.btninsertphong.Text = "Insert";
            this.btninsertphong.UseVisualStyleBackColor = true;
            this.btninsertphong.Click += new System.EventHandler(this.btninsertphong_Click);
            // 
            // btnupdatephong
            // 
            this.btnupdatephong.Location = new System.Drawing.Point(900, 466);
            this.btnupdatephong.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdatephong.Name = "btnupdatephong";
            this.btnupdatephong.Size = new System.Drawing.Size(100, 28);
            this.btnupdatephong.TabIndex = 6;
            this.btnupdatephong.Text = "Update";
            this.btnupdatephong.UseVisualStyleBackColor = true;
            this.btnupdatephong.Click += new System.EventHandler(this.btnupdatephong_Click);
            // 
            // btndeletephong
            // 
            this.btndeletephong.Location = new System.Drawing.Point(900, 550);
            this.btndeletephong.Margin = new System.Windows.Forms.Padding(4);
            this.btndeletephong.Name = "btndeletephong";
            this.btndeletephong.Size = new System.Drawing.Size(100, 28);
            this.btndeletephong.TabIndex = 7;
            this.btndeletephong.Text = "Delete";
            this.btndeletephong.UseVisualStyleBackColor = true;
            this.btndeletephong.Click += new System.EventHandler(this.btndeletephong_Click);
            // 
            // MHquanlyphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 615);
            this.Controls.Add(this.btndeletephong);
            this.Controls.Add(this.btnupdatephong);
            this.Controls.Add(this.btninsertphong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvdsphong);
            this.Controls.Add(this.cbbloaiphong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MHquanlyphong";
            this.Text = "MHquanlyphong";
            this.Load += new System.EventHandler(this.MHquanlyphong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsphong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbloaiphong;
        private System.Windows.Forms.DataGridView dgvdsphong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidphong;
        private System.Windows.Forms.TextBox txtloaiphong;
        private System.Windows.Forms.TextBox txttinhtrang;
        private System.Windows.Forms.TextBox txttrangthaidichvu;
        private System.Windows.Forms.Button btninsertphong;
        private System.Windows.Forms.Button btnupdatephong;
        private System.Windows.Forms.Button btndeletephong;
    }
}