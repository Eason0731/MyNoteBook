﻿namespace My_NoteBook
{
    partial class Frm_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Edit));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClassification = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(239, 519);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tips：最多输入65536个字符！";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(41, 676);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "记录时间：";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_save.Location = new System.Drawing.Point(317, 752);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 42);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "更新";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_back.Location = new System.Drawing.Point(471, 752);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 42);
            this.btn_back.TabIndex = 14;
            this.btn_back.Text = "返回";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("宋体", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 669);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 30);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("宋体", 12F);
            this.txtContent.Location = new System.Drawing.Point(167, 125);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4);
            this.txtContent.MaxLength = 65536;
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(645, 374);
            this.txtContent.TabIndex = 12;
            this.txtContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStatus_KeyDown);
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("宋体", 12F);
            this.txtTitle.Location = new System.Drawing.Point(167, 49);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(361, 34);
            this.txtTitle.TabIndex = 11;
            this.txtTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStatus_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(81, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "内容：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(81, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "标题：";
            // 
            // cmbClassification
            // 
            this.cmbClassification.DropDownHeight = 116;
            this.cmbClassification.FormattingEnabled = true;
            this.cmbClassification.IntegralHeight = false;
            this.cmbClassification.Items.AddRange(new object[] {
            "工作类",
            "技术类",
            "其他类"});
            this.cmbClassification.Location = new System.Drawing.Point(163, 598);
            this.cmbClassification.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbClassification.Name = "cmbClassification";
            this.cmbClassification.Size = new System.Drawing.Size(271, 23);
            this.cmbClassification.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(41, 598);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "笔记分类：";
            // 
            // Frm_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 840);
            this.Controls.Add(this.cmbClassification);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Edit";
            this.Text = "更新笔记";
            this.Load += new System.EventHandler(this.Frm_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Button btn_back;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox txtContent;
        public System.Windows.Forms.TextBox txtTitle;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmbClassification;
    }
}