namespace My_NoteBook
{
    partial class Frm_ViewNoteDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ViewNoteDetail));
            this.label3 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblClassification = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtContent = new WinHtmlEditor.HtmlEditor();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(41, 761);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "记录时间：";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_back.Location = new System.Drawing.Point(810, 830);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 42);
            this.btn_back.TabIndex = 23;
            this.btn_back.Text = "返回";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(81, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 19;
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
            this.label1.TabIndex = 18;
            this.label1.Text = "标题：";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("宋体", 12F);
            this.txtTitle.Location = new System.Drawing.Point(165, 45);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(1400, 34);
            this.txtTitle.TabIndex = 26;
            this.txtTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStatus_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(41, 683);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "笔记分类：";
            // 
            // lblClassification
            // 
            this.lblClassification.AutoSize = true;
            this.lblClassification.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClassification.Location = new System.Drawing.Point(161, 683);
            this.lblClassification.Name = "lblClassification";
            this.lblClassification.Size = new System.Drawing.Size(0, 20);
            this.lblClassification.TabIndex = 30;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDate.Location = new System.Drawing.Point(161, 761);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 20);
            this.lblDate.TabIndex = 31;
            // 
            // txtContent
            // 
            this.txtContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtContent.BodyInnerHTML = null;
            this.txtContent.BodyInnerText = null;
            this.txtContent.EnterToBR = false;
            this.txtContent.FontName = null;
            this.txtContent.FontSize = WinHtmlEditor.FontSize.NA;
            this.txtContent.Location = new System.Drawing.Point(165, 125);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.ShowStatusBar = true;
            this.txtContent.ShowToolBar = true;
            this.txtContent.ShowWb = true;
            this.txtContent.Size = new System.Drawing.Size(1400, 521);
            this.txtContent.TabIndex = 32;
            this.txtContent.WebBrowserShortcutsEnabled = true;
            // 
            // Frm_ViewNoteDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1619, 932);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblClassification);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ViewNoteDetail";
            this.Text = "查看笔记";
            this.Load += new System.EventHandler(this.Frm_ViewNoteDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btn_back;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTitle;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblClassification;
        public System.Windows.Forms.Label lblDate;
        public WinHtmlEditor.HtmlEditor txtContent;
    }
}