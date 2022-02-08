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
    public partial class Manage_Contact_Frm : Form
    {
        public Contact Contact_Data = new Contact();

        public Manage_Contact_Frm()
        {
            InitializeComponent();
        }

        private void Manage_Contact_Frm_Load(object sender, EventArgs e)
        {
            Get_Contact_Data();
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

شما باید مشخصات مخاطب را ویرایش کنید کنید و سپس کنید ویرایش مخاطب را بزنید !
", "آموزش", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error : " + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Manage_Contact(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Txt_Name_Last.Text) && !string.IsNullOrWhiteSpace(Txt_Name_Last.Text) && !string.IsNullOrEmpty(Txt_Phone_Number.Text) && !string.IsNullOrWhiteSpace(Txt_Phone_Number.Text))
                {
                    if (Txt_Name_Last.TextLength >= 3)
                    {
                        if (Txt_Phone_Number.TextLength == 11)
                        {
                            if (MessageBox.Show("مخاطب در سیستم ویرایش شود ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                            {
                                Contact Updated_Contact = new Contact();
                                Updated_Contact.Name_Last = Txt_Name_Last.Text;
                                Updated_Contact.Phone_Number = Txt_Phone_Number.Text;
                                Updated_Contact.Description = Txt_Description.Text;

                                string Result = new Business_Logical_Contact().Update(Contact_Data.ID, Updated_Contact);


                                if (Result == "مخاطب با موفقیت ویرایش شد")
                                {
                                    MessageBox.Show(Result, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                }
                                else
                                {
                                    MessageBox.Show("Error : " + Result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                }
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
                    MessageBox.Show("لطفا همه مقادیر را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error : " + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Get_Contact_Data()
        {
            try
            {
                Txt_Name_Last.Text = Contact_Data.Name_Last;
                Txt_Phone_Number.Text = Contact_Data.Phone_Number;
                Txt_Description.Text = Contact_Data.Description;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error : " + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
