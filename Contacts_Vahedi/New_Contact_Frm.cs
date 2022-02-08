using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Entity;
using Business_Logical;

namespace Contacts_Vahedi
{
    public partial class New_Contact_Frm : Form
    {
        public New_Contact_Frm()
        {
            InitializeComponent();
        }

        private void Check_Key_Phone_Number(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error : " + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void New_Contact_Frm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            try
            {
                MessageBox.Show(@"

شما باید مشخصات مخاطب را وارد کنید و سپس کنید مخاطب جدید را بزنید !
", "آموزش", MessageBoxButtons.OK,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error : "+ Ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void New_Contact(object sender,EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Txt_Name_Last.Text) && !string.IsNullOrWhiteSpace(Txt_Name_Last.Text) && !string.IsNullOrEmpty(Txt_Phone_Number.Text) && !string.IsNullOrWhiteSpace(Txt_Phone_Number.Text))
                {
                    if (Txt_Name_Last.TextLength >= 3)
                    {
                        if (Txt_Phone_Number.TextLength == 11)
                        {
                            if (MessageBox.Show("مخاطب در سیستم ثبت شود ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                            {
                                Contact New_Contact = new Contact();
                                New_Contact.Name_Last = Txt_Name_Last.Text;
                                New_Contact.Phone_Number = Txt_Phone_Number.Text;
                                New_Contact.Description = Txt_Description.Text;

                                string Result = new Business_Logical_Contact().Create(New_Contact);

                                if (Result == "مخاطب در سیستم ثبت شد")
                                {
                                    MessageBox.Show(Result, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else if (Result == "شماره و یا نام تکراری می باشد")
                                {
                                    MessageBox.Show(Result, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    MessageBox.Show(Result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                Clear_Form();
                            }
                        }
                        else
                        {
                            MessageBox.Show("فرمت شماره را درست وارد کنید - مثال : 000-000-0000  \n یک شماره 11 رقمی بدون کاراکتر های واسطه", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                        }
                    }
                    else
                    {
                        MessageBox.Show("حداقل نام باید دارای 3 کارکتر باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                }
                else
                {
                    MessageBox.Show("لطفا همه مقادیر را وارد کنید","هشدار",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                 
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error : " + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear_Form()
        {
            foreach (var item in Controls)
            {
                if(item.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    (item as TextBox).Clear();
                }
            }
        }
    }
}
