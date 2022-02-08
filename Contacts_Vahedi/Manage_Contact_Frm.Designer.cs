namespace Contacts_Vahedi
{
    partial class Manage_Contact_Frm
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
            this.Txt_Name_Last = new System.Windows.Forms.TextBox();
            this.Txt_Phone_Number = new System.Windows.Forms.TextBox();
            this.Txt_Description = new System.Windows.Forms.TextBox();
            this.Lbl_Name_Last = new System.Windows.Forms.Label();
            this.Lbl_Phone_Number = new System.Windows.Forms.Label();
            this.Lbl_Description = new System.Windows.Forms.Label();
            this.Lbl_Add_Context = new System.Windows.Forms.Label();
            this.Ptb_Add_Contact = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Add_Contact)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Name_Last
            // 
            this.Txt_Name_Last.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Name_Last.Location = new System.Drawing.Point(12, 109);
            this.Txt_Name_Last.MaxLength = 45;
            this.Txt_Name_Last.Name = "Txt_Name_Last";
            this.Txt_Name_Last.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Name_Last.Size = new System.Drawing.Size(298, 22);
            this.Txt_Name_Last.TabIndex = 0;
            // 
            // Txt_Phone_Number
            // 
            this.Txt_Phone_Number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Phone_Number.Location = new System.Drawing.Point(12, 137);
            this.Txt_Phone_Number.MaxLength = 11;
            this.Txt_Phone_Number.Name = "Txt_Phone_Number";
            this.Txt_Phone_Number.Size = new System.Drawing.Size(298, 22);
            this.Txt_Phone_Number.TabIndex = 1;
            this.Txt_Phone_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_Key_Phone_Number);
            // 
            // Txt_Description
            // 
            this.Txt_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Description.Location = new System.Drawing.Point(12, 184);
            this.Txt_Description.MaxLength = 3000;
            this.Txt_Description.Multiline = true;
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Description.Size = new System.Drawing.Size(367, 110);
            this.Txt_Description.TabIndex = 2;
            // 
            // Lbl_Name_Last
            // 
            this.Lbl_Name_Last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Name_Last.AutoSize = true;
            this.Lbl_Name_Last.Location = new System.Drawing.Point(316, 112);
            this.Lbl_Name_Last.Name = "Lbl_Name_Last";
            this.Lbl_Name_Last.Size = new System.Drawing.Size(57, 13);
            this.Lbl_Name_Last.TabIndex = 3;
            this.Lbl_Name_Last.Text = "نام مخاطب";
            // 
            // Lbl_Phone_Number
            // 
            this.Lbl_Phone_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Phone_Number.AutoSize = true;
            this.Lbl_Phone_Number.Location = new System.Drawing.Point(316, 140);
            this.Lbl_Phone_Number.Name = "Lbl_Phone_Number";
            this.Lbl_Phone_Number.Size = new System.Drawing.Size(64, 13);
            this.Lbl_Phone_Number.TabIndex = 4;
            this.Lbl_Phone_Number.Text = "شماره تماس";
            // 
            // Lbl_Description
            // 
            this.Lbl_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Description.AutoSize = true;
            this.Lbl_Description.Location = new System.Drawing.Point(316, 168);
            this.Lbl_Description.Name = "Lbl_Description";
            this.Lbl_Description.Size = new System.Drawing.Size(51, 13);
            this.Lbl_Description.TabIndex = 5;
            this.Lbl_Description.Text = "توضیحات";
            // 
            // Lbl_Add_Context
            // 
            this.Lbl_Add_Context.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Add_Context.AutoSize = true;
            this.Lbl_Add_Context.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_Add_Context.Location = new System.Drawing.Point(300, 85);
            this.Lbl_Add_Context.Name = "Lbl_Add_Context";
            this.Lbl_Add_Context.Size = new System.Drawing.Size(79, 13);
            this.Lbl_Add_Context.TabIndex = 7;
            this.Lbl_Add_Context.Text = "ویرایش مخاطب";
            this.Lbl_Add_Context.Click += new System.EventHandler(this.Manage_Contact);
            // 
            // Ptb_Add_Contact
            // 
            this.Ptb_Add_Contact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ptb_Add_Contact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ptb_Add_Contact.Image = global::Contacts_Vahedi.Properties.Resources.Manage_Human;
            this.Ptb_Add_Contact.Location = new System.Drawing.Point(304, 12);
            this.Ptb_Add_Contact.Name = "Ptb_Add_Contact";
            this.Ptb_Add_Contact.Size = new System.Drawing.Size(70, 70);
            this.Ptb_Add_Contact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ptb_Add_Contact.TabIndex = 6;
            this.Ptb_Add_Contact.TabStop = false;
            this.Ptb_Add_Contact.Click += new System.EventHandler(this.Manage_Contact);
            // 
            // Manage_Contact_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 306);
            this.Controls.Add(this.Lbl_Add_Context);
            this.Controls.Add(this.Ptb_Add_Contact);
            this.Controls.Add(this.Lbl_Description);
            this.Controls.Add(this.Lbl_Phone_Number);
            this.Controls.Add(this.Lbl_Name_Last);
            this.Controls.Add(this.Txt_Description);
            this.Controls.Add(this.Txt_Phone_Number);
            this.Controls.Add(this.Txt_Name_Last);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(477, 483);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(254, 320);
            this.Name = "Manage_Contact_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت مخاطب";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.New_Contact_Frm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Manage_Contact_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Add_Contact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Name_Last;
        private System.Windows.Forms.TextBox Txt_Phone_Number;
        private System.Windows.Forms.TextBox Txt_Description;
        private System.Windows.Forms.Label Lbl_Name_Last;
        private System.Windows.Forms.Label Lbl_Phone_Number;
        private System.Windows.Forms.Label Lbl_Description;
        private System.Windows.Forms.Label Lbl_Add_Context;
        private System.Windows.Forms.PictureBox Ptb_Add_Contact;
    }
}