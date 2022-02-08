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
    public partial class Main_Frm : Form
    {
        public Main_Frm()
        {
            InitializeComponent();

            MessageBoxManage();
        }

        private void Main_Frm_Load(object sender, EventArgs e)
        {
            Get_Contact_Data();
        }

        private void New_Contact_Click(object sender, EventArgs e)
        {
            try
            {
                new New_Contact_Frm().ShowDialog();
                Get_Contact_Data();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error : " + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Manage_Contact_Click(object sender, EventArgs e)
        {
            try
            {
                Manage_Contact_Frm Mcf = new Manage_Contact_Frm();
                Mcf.Contact_Data.ID = int.Parse(Dgv_Show_Data.SelectedRows[0].Cells[0].Value.ToString());
                Mcf.Contact_Data.Name_Last = Dgv_Show_Data.SelectedRows[0].Cells[1].Value.ToString();
                Mcf.Contact_Data.Phone_Number = Dgv_Show_Data.SelectedRows[0].Cells[2].Value.ToString();
                Mcf.Contact_Data.Description = Dgv_Show_Data.SelectedRows[0].Cells[3].Value.ToString();
                Mcf.ShowDialog();

                Get_Contact_Data();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("رکوردی وجود ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error : " + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Contact_Click(object sender, EventArgs e)
        {
            try
            {
                int Selected_Contact_For_Delete = int.Parse(Dgv_Show_Data.SelectedRows[0].Cells[0].Value.ToString());
                if (MessageBox.Show("آیا مخاطب انتخاب شده حذف گردد ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    string Result = new Business_Logical_Contact().Delete(Selected_Contact_For_Delete);

                    if (Result == "مخاطب با موفقیت حذف شد")
                    {
                        MessageBox.Show(Result, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Result == "خطایی پیش آمد مخاطب حذف نشد دوباره تلاش کنید")
                    {
                        MessageBox.Show(Result, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(Result, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                Get_Contact_Data();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("رکوردی وجود ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error : " + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void About_US_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ساخته شده توسط محمد متین واحدی","درباره سازنده",MessageBoxButtons.OK,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
        }

        private void Get_Contact_Data()
        {
            try
            {
                Dgv_Show_Data.DataSource = new Business_Logical_Contact().Read();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error : " + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MessageBoxManage()
        {
            MessageBoxManager.Unregister();
            MessageBoxManager.OK = "تایید";
            MessageBoxManager.Yes = "بلی";
            MessageBoxManager.No = "خیر";
            MessageBoxManager.Retry = "تلاش مجدد";
            MessageBoxManager.Cancel= "لغو";
            MessageBoxManager.Abort = "گزارش";
            MessageBoxManager.Ignore = "می دانم";
            MessageBoxManager.Register();
        }
    }
}
