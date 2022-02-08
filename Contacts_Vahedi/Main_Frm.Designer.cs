namespace Contacts_Vahedi
{
    partial class Main_Frm
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
            this.components = new System.ComponentModel.Container();
            this.Dgv_Show_Data = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cms_Dgv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.مخاطبجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتمخاطبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفمخاطبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_Add_Context = new System.Windows.Forms.Label();
            this.Lbl_Delete_Contact = new System.Windows.Forms.Label();
            this.Lbl_About_US = new System.Windows.Forms.Label();
            this.Lb_Manage_Contact = new System.Windows.Forms.Label();
            this.Ptb_About_US = new System.Windows.Forms.PictureBox();
            this.Ptb_Manage_Contact = new System.Windows.Forms.PictureBox();
            this.Ptb_Delete_Contact = new System.Windows.Forms.PictureBox();
            this.Ptb_Add_Contact = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Show_Data)).BeginInit();
            this.Cms_Dgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_About_US)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Manage_Contact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Delete_Contact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Add_Contact)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Show_Data
            // 
            this.Dgv_Show_Data.AllowUserToAddRows = false;
            this.Dgv_Show_Data.AllowUserToDeleteRows = false;
            this.Dgv_Show_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Show_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Show_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Show_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name_Last,
            this.Phone_Number,
            this.Description});
            this.Dgv_Show_Data.ContextMenuStrip = this.Cms_Dgv;
            this.Dgv_Show_Data.Location = new System.Drawing.Point(0, 105);
            this.Dgv_Show_Data.Name = "Dgv_Show_Data";
            this.Dgv_Show_Data.ReadOnly = true;
            this.Dgv_Show_Data.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Dgv_Show_Data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Dgv_Show_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Show_Data.Size = new System.Drawing.Size(850, 413);
            this.Dgv_Show_Data.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "کد مخاطب";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Name_Last
            // 
            this.Name_Last.DataPropertyName = "Name_Last";
            this.Name_Last.HeaderText = "نام و نام خوانوادگی";
            this.Name_Last.Name = "Name_Last";
            this.Name_Last.ReadOnly = true;
            // 
            // Phone_Number
            // 
            this.Phone_Number.DataPropertyName = "Phone_Number";
            this.Phone_Number.HeaderText = "شماره تماس";
            this.Phone_Number.Name = "Phone_Number";
            this.Phone_Number.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Cms_Dgv
            // 
            this.Cms_Dgv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مخاطبجدیدToolStripMenuItem,
            this.مدیریتمخاطبToolStripMenuItem,
            this.حذفمخاطبToolStripMenuItem});
            this.Cms_Dgv.Name = "contextMenuStrip1";
            this.Cms_Dgv.Size = new System.Drawing.Size(154, 70);
            // 
            // مخاطبجدیدToolStripMenuItem
            // 
            this.مخاطبجدیدToolStripMenuItem.Image = global::Contacts_Vahedi.Properties.Resources.New_Human;
            this.مخاطبجدیدToolStripMenuItem.Name = "مخاطبجدیدToolStripMenuItem";
            this.مخاطبجدیدToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.مخاطبجدیدToolStripMenuItem.Text = "مخاطب جدید";
            this.مخاطبجدیدToolStripMenuItem.Click += new System.EventHandler(this.New_Contact_Click);
            // 
            // مدیریتمخاطبToolStripMenuItem
            // 
            this.مدیریتمخاطبToolStripMenuItem.Image = global::Contacts_Vahedi.Properties.Resources.Manage_Human;
            this.مدیریتمخاطبToolStripMenuItem.Name = "مدیریتمخاطبToolStripMenuItem";
            this.مدیریتمخاطبToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.مدیریتمخاطبToolStripMenuItem.Text = "مدیریت مخاطب";
            this.مدیریتمخاطبToolStripMenuItem.Click += new System.EventHandler(this.Manage_Contact_Click);
            // 
            // حذفمخاطبToolStripMenuItem
            // 
            this.حذفمخاطبToolStripMenuItem.Image = global::Contacts_Vahedi.Properties.Resources.Delete_Human;
            this.حذفمخاطبToolStripMenuItem.Name = "حذفمخاطبToolStripMenuItem";
            this.حذفمخاطبToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.حذفمخاطبToolStripMenuItem.Text = "حذف مخاطب";
            this.حذفمخاطبToolStripMenuItem.Click += new System.EventHandler(this.Delete_Contact_Click);
            // 
            // Lbl_Add_Context
            // 
            this.Lbl_Add_Context.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Add_Context.AutoSize = true;
            this.Lbl_Add_Context.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_Add_Context.Location = new System.Drawing.Point(770, 87);
            this.Lbl_Add_Context.Name = "Lbl_Add_Context";
            this.Lbl_Add_Context.Size = new System.Drawing.Size(68, 15);
            this.Lbl_Add_Context.TabIndex = 2;
            this.Lbl_Add_Context.Text = "اضافه مخاطب";
            this.Lbl_Add_Context.Click += new System.EventHandler(this.New_Contact_Click);
            // 
            // Lbl_Delete_Contact
            // 
            this.Lbl_Delete_Contact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Delete_Contact.AutoSize = true;
            this.Lbl_Delete_Contact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_Delete_Contact.Location = new System.Drawing.Point(618, 87);
            this.Lbl_Delete_Contact.Name = "Lbl_Delete_Contact";
            this.Lbl_Delete_Contact.Size = new System.Drawing.Size(66, 15);
            this.Lbl_Delete_Contact.TabIndex = 4;
            this.Lbl_Delete_Contact.Text = "حذف مخاطب";
            this.Lbl_Delete_Contact.Click += new System.EventHandler(this.Delete_Contact_Click);
            // 
            // Lbl_About_US
            // 
            this.Lbl_About_US.AutoSize = true;
            this.Lbl_About_US.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_About_US.Location = new System.Drawing.Point(22, 87);
            this.Lbl_About_US.Name = "Lbl_About_US";
            this.Lbl_About_US.Size = new System.Drawing.Size(48, 15);
            this.Lbl_About_US.TabIndex = 8;
            this.Lbl_About_US.Text = "درباره من";
            this.Lbl_About_US.Click += new System.EventHandler(this.About_US_Click);
            // 
            // Lb_Manage_Contact
            // 
            this.Lb_Manage_Contact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Manage_Contact.AutoSize = true;
            this.Lb_Manage_Contact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lb_Manage_Contact.Location = new System.Drawing.Point(688, 87);
            this.Lb_Manage_Contact.Name = "Lb_Manage_Contact";
            this.Lb_Manage_Contact.Size = new System.Drawing.Size(78, 15);
            this.Lb_Manage_Contact.TabIndex = 6;
            this.Lb_Manage_Contact.Text = "مدیریت مخاطب";
            this.Lb_Manage_Contact.Click += new System.EventHandler(this.Manage_Contact_Click);
            // 
            // Ptb_About_US
            // 
            this.Ptb_About_US.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ptb_About_US.Image = global::Contacts_Vahedi.Properties.Resources.about;
            this.Ptb_About_US.Location = new System.Drawing.Point(12, 14);
            this.Ptb_About_US.Name = "Ptb_About_US";
            this.Ptb_About_US.Size = new System.Drawing.Size(70, 70);
            this.Ptb_About_US.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ptb_About_US.TabIndex = 7;
            this.Ptb_About_US.TabStop = false;
            this.Ptb_About_US.Click += new System.EventHandler(this.About_US_Click);
            // 
            // Ptb_Manage_Contact
            // 
            this.Ptb_Manage_Contact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ptb_Manage_Contact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ptb_Manage_Contact.Image = global::Contacts_Vahedi.Properties.Resources.Manage_Human;
            this.Ptb_Manage_Contact.Location = new System.Drawing.Point(692, 14);
            this.Ptb_Manage_Contact.Name = "Ptb_Manage_Contact";
            this.Ptb_Manage_Contact.Size = new System.Drawing.Size(70, 70);
            this.Ptb_Manage_Contact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ptb_Manage_Contact.TabIndex = 5;
            this.Ptb_Manage_Contact.TabStop = false;
            this.Ptb_Manage_Contact.Click += new System.EventHandler(this.Manage_Contact_Click);
            // 
            // Ptb_Delete_Contact
            // 
            this.Ptb_Delete_Contact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ptb_Delete_Contact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ptb_Delete_Contact.Image = global::Contacts_Vahedi.Properties.Resources.Delete_Human;
            this.Ptb_Delete_Contact.Location = new System.Drawing.Point(616, 14);
            this.Ptb_Delete_Contact.Name = "Ptb_Delete_Contact";
            this.Ptb_Delete_Contact.Size = new System.Drawing.Size(70, 70);
            this.Ptb_Delete_Contact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ptb_Delete_Contact.TabIndex = 3;
            this.Ptb_Delete_Contact.TabStop = false;
            this.Ptb_Delete_Contact.Click += new System.EventHandler(this.Delete_Contact_Click);
            // 
            // Ptb_Add_Contact
            // 
            this.Ptb_Add_Contact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ptb_Add_Contact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ptb_Add_Contact.Image = global::Contacts_Vahedi.Properties.Resources.New_Human;
            this.Ptb_Add_Contact.Location = new System.Drawing.Point(768, 14);
            this.Ptb_Add_Contact.Name = "Ptb_Add_Contact";
            this.Ptb_Add_Contact.Size = new System.Drawing.Size(70, 70);
            this.Ptb_Add_Contact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ptb_Add_Contact.TabIndex = 1;
            this.Ptb_Add_Contact.TabStop = false;
            this.Ptb_Add_Contact.Click += new System.EventHandler(this.New_Contact_Click);
            // 
            // Main_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 518);
            this.Controls.Add(this.Lbl_About_US);
            this.Controls.Add(this.Ptb_About_US);
            this.Controls.Add(this.Lb_Manage_Contact);
            this.Controls.Add(this.Ptb_Manage_Contact);
            this.Controls.Add(this.Lbl_Delete_Contact);
            this.Controls.Add(this.Ptb_Delete_Contact);
            this.Controls.Add(this.Lbl_Add_Context);
            this.Controls.Add(this.Ptb_Add_Contact);
            this.Controls.Add(this.Dgv_Show_Data);
            this.Font = new System.Drawing.Font("Shabnam", 8.25F);
            this.MinimumSize = new System.Drawing.Size(338, 360);
            this.Name = "Main_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم مخاطبین";
            this.Load += new System.EventHandler(this.Main_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Show_Data)).EndInit();
            this.Cms_Dgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_About_US)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Manage_Contact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Delete_Contact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Add_Contact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Show_Data;
        private System.Windows.Forms.PictureBox Ptb_Add_Contact;
        private System.Windows.Forms.Label Lbl_Add_Context;
        private System.Windows.Forms.Label Lbl_Delete_Contact;
        private System.Windows.Forms.PictureBox Ptb_Delete_Contact;
        private System.Windows.Forms.Label Lbl_About_US;
        private System.Windows.Forms.PictureBox Ptb_About_US;
        private System.Windows.Forms.Label Lb_Manage_Contact;
        private System.Windows.Forms.PictureBox Ptb_Manage_Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Last;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.ContextMenuStrip Cms_Dgv;
        private System.Windows.Forms.ToolStripMenuItem مخاطبجدیدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتمخاطبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفمخاطبToolStripMenuItem;
    }
}

