namespace QLTV_CNTTK15B
{
    partial class frmCNLoaiSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCNLoaiSach));
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTls = new System.Windows.Forms.TextBox();
            this.DgvLoaiSach = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKs = new System.Windows.Forms.TextBox();
            this.txtMls = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntSave = new System.Windows.Forms.Button();
            this.bntOut = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.bntEdit = new System.Windows.Forms.Button();
            this.bntAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLoaiSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "KieuSach";
            this.Column3.HeaderText = "Kiểu sách";
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaLoaiSach";
            this.Column1.HeaderText = "Mã loại sách";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // txtTls
            // 
            this.txtTls.Location = new System.Drawing.Point(145, 89);
            this.txtTls.Name = "txtTls";
            this.txtTls.Size = new System.Drawing.Size(173, 26);
            this.txtTls.TabIndex = 1;
            // 
            // DgvLoaiSach
            // 
            this.DgvLoaiSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLoaiSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvLoaiSach.Location = new System.Drawing.Point(0, 19);
            this.DgvLoaiSach.Name = "DgvLoaiSach";
            this.DgvLoaiSach.Size = new System.Drawing.Size(829, 219);
            this.DgvLoaiSach.TabIndex = 0;
            this.DgvLoaiSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLoaiSach_CellClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenLoai";
            this.Column2.HeaderText = "Tên loại sách";
            this.Column2.Name = "Column2";
            this.Column2.Width = 340;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.YellowGreen;
            this.groupBox2.Controls.Add(this.DgvLoaiSach);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(829, 238);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiện thị Loại Sách";
            // 
            // txtKs
            // 
            this.txtKs.Location = new System.Drawing.Point(563, 39);
            this.txtKs.Name = "txtKs";
            this.txtKs.Size = new System.Drawing.Size(173, 26);
            this.txtKs.TabIndex = 1;
            // 
            // txtMls
            // 
            this.txtMls.Location = new System.Drawing.Point(145, 43);
            this.txtMls.Name = "txtMls";
            this.txtMls.Size = new System.Drawing.Size(173, 26);
            this.txtMls.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kiểu sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại sách:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.groupBox1.Controls.Add(this.bntSave);
            this.groupBox1.Controls.Add(this.bntOut);
            this.groupBox1.Controls.Add(this.bntDelete);
            this.groupBox1.Controls.Add(this.bntEdit);
            this.groupBox1.Controls.Add(this.bntAdd);
            this.groupBox1.Controls.Add(this.txtTls);
            this.groupBox1.Controls.Add(this.txtKs);
            this.groupBox1.Controls.Add(this.txtMls);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật Loại Sách";
            // 
            // bntSave
            // 
            this.bntSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSave.Image = global::QLTV_CNTTK15B.Properties.Resources.Save_24x24;
            this.bntSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSave.Location = new System.Drawing.Point(211, 137);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(94, 57);
            this.bntSave.TabIndex = 0;
            this.bntSave.Text = "Lưu";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // bntOut
            // 
            this.bntOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntOut.Image = global::QLTV_CNTTK15B.Properties.Resources.Log_Out_24x24;
            this.bntOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntOut.Location = new System.Drawing.Point(705, 137);
            this.bntOut.Name = "bntOut";
            this.bntOut.Size = new System.Drawing.Size(94, 57);
            this.bntOut.TabIndex = 0;
            this.bntOut.Text = "Thoát";
            this.bntOut.UseVisualStyleBackColor = true;
            this.bntOut.Click += new System.EventHandler(this.bntOut_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDelete.Image = global::QLTV_CNTTK15B.Properties.Resources.Delete_24x24;
            this.bntDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntDelete.Location = new System.Drawing.Point(552, 137);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(94, 57);
            this.bntDelete.TabIndex = 0;
            this.bntDelete.Text = "Xóa";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // bntEdit
            // 
            this.bntEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntEdit.Image = global::QLTV_CNTTK15B.Properties.Resources.Edit_24x24;
            this.bntEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntEdit.Location = new System.Drawing.Point(387, 137);
            this.bntEdit.Name = "bntEdit";
            this.bntEdit.Size = new System.Drawing.Size(94, 57);
            this.bntEdit.TabIndex = 0;
            this.bntEdit.Text = "Sửa";
            this.bntEdit.UseVisualStyleBackColor = true;
            this.bntEdit.Click += new System.EventHandler(this.bntEdit_Click);
            // 
            // bntAdd
            // 
            this.bntAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAdd.Image = global::QLTV_CNTTK15B.Properties.Resources.Add_24x24;
            this.bntAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntAdd.Location = new System.Drawing.Point(46, 137);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(93, 57);
            this.bntAdd.TabIndex = 0;
            this.bntAdd.Text = "Thêm";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại sách:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(840, 476);
            this.splitContainer1.SplitterDistance = 219;
            this.splitContainer1.TabIndex = 1;
            // 
            // frmCNLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 476);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCNLoaiSach";
            this.Text = "Cập nhật loại sách";
            this.Load += new System.EventHandler(this.frmCNLoaiSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLoaiSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.Button bntOut;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Button bntEdit;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.TextBox txtTls;
        private System.Windows.Forms.DataGridView DgvLoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKs;
        private System.Windows.Forms.TextBox txtMls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

