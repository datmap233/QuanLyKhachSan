﻿namespace QuanLyKhachSan
{
    partial class fListCustomerEachTour
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label18 = new Label();
            panel18 = new Panel();
            label13 = new Label();
            dataGridView1 = new DataGridView();
            btn_back = new Button();
            textBoxMaTour = new TextBox();
            panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(34, 27);
            label18.Name = "label18";
            label18.Size = new Size(355, 57);
            label18.TabIndex = 18;
            label18.Text = "Danh sách khách";
            label18.Click += label18_Click;
            // 
            // panel18
            // 
            panel18.BackColor = Color.FromArgb(151, 71, 255);
            panel18.Controls.Add(label13);
            panel18.Cursor = Cursors.Hand;
            panel18.Location = new Point(551, 37);
            panel18.Margin = new Padding(3, 4, 3, 4);
            panel18.Name = "panel18";
            panel18.Size = new Size(141, 39);
            panel18.TabIndex = 19;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(28, 3);
            label13.Name = "label13";
            label13.Size = new Size(99, 32);
            label13.TabIndex = 0;
            label13.Text = "Mã tour";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Cornsilk;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(162, 236);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1120, 436);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Transparent;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_back.ForeColor = Color.Black;
            btn_back.Location = new Point(54, 815);
            btn_back.Margin = new Padding(3, 4, 3, 4);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(141, 64);
            btn_back.TabIndex = 47;
            btn_back.Text = "< Quay lại";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // textBoxMaTour
            // 
            textBoxMaTour.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMaTour.Location = new Point(721, 37);
            textBoxMaTour.Margin = new Padding(3, 4, 3, 4);
            textBoxMaTour.Name = "textBoxMaTour";
            textBoxMaTour.Size = new Size(211, 39);
            textBoxMaTour.TabIndex = 20;
            // 
            // fListCustomerEachTour
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 241, 241);
            ClientSize = new Size(1445, 908);
            Controls.Add(btn_back);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxMaTour);
            Controls.Add(panel18);
            Controls.Add(label18);
            ForeColor = Color.Cornsilk;
            Location = new Point(28, 3);
            Name = "fListCustomerEachTour";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fListCustomerEachTour";
            Load += fListCustomerEachTour_Load;
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label18;
        private Panel panel18;
        private Label label13;
        public DataGridView dataGridView1;
        private Button btn_back;
        public TextBox textBoxMaTour;
    }
}