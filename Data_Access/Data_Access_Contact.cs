using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Entity;

namespace Data_Access
{
    public class Data_Access_Contact
    {
        public object Read()
        {
            try
            {
                var q = from i in new Db().Db_Context select i;
                return q.ToList();
            }
            catch (Exception Ex)
            {
                List<string> Error_List = new List<string>();
                Error_List.Add("Error : ");
                Error_List.Add("Error : " + Ex.Message);
                return Error_List.ToList();
            }
        }

        public string Create(Contact Cnt)
        {
            try
            {
                Db New_Contact_Db = new Db();
                New_Contact_Db.Db_Context.Add(Cnt);
                New_Contact_Db.SaveChanges();
                return "مخاطب در سیستم ثبت شد";
            }
            catch (Exception Ex)
            {
                return Ex.Message;
            }
        }

        public string Exist(Contact Cnt)
        {
            try
            {
                string Return_Data = "FALSE";

                var q_Name_Last = from i in new Db().Db_Context where i.Name_Last == Cnt.Name_Last select i;
                var q_Phone_Number = from i in new Db().Db_Context where i.Phone_Number == Cnt.Phone_Number select i;

                if (q_Name_Last.Count() >= 1)
                {
                    Return_Data = "TRUE";
                }
                else
                {
                    return "FALSE";
                }

                if (q_Phone_Number.Count() >= 1)
                {
                    Return_Data = "TRUE";
                }
                else
                {
                    return "FALSE";
                }

                return Return_Data;
            }
            catch (Exception Ex)
            {
                return Ex.Message;
            }
        }

        public string Delete(int Delete_ID)
        {
            try
            {
                Db D = new Db();
                var q = D.Db_Context.Where(i => i.ID == Delete_ID);
                if (q.Count() == 1)
                {
                    D.Db_Context.Remove(q.Single());
                    D.SaveChanges();
                    return "مخاطب با موفقیت حذف شد";
                }
                else if(q.Count() > 1)
                {
                    return "خطای رکورد تکراری دوباره تلاش کنید";
                }
                else
                {
                    return "خطایی پیش آمد مخاطب حذف نشد دوباره تلاش کنید";
                }
            }
            catch (Exception Ex)
            {
                return Ex.Message;
            }
        }

        public string Update(int ID,Contact Contact_Update_Data)
        {
            try
            {
                Contact Managed_Contact = new Contact();

                Db Data = new Db();
                var q = from i in Data.Db_Context where i.ID == ID select i;
                if (q.Count() == 1)
                {
                    Contact Managed = new Contact();

                    Managed = q.Single();

                    Managed.Name_Last = Contact_Update_Data.Name_Last;
                    Managed.Phone_Number = Contact_Update_Data.Phone_Number;
                    Managed.Description = Contact_Update_Data.Description;

                    Data.SaveChanges();
                    return "مخاطب با موفقیت ویرایش شد";
                }
                else if (q.Count() > 1)
                {
                    return "خطای رکورد تکراری دوباره تلاش کنید";
                }
                else
                {
                    return "خطایی پیش آمد دوباره تلاش کنید";
                }

            }
            catch (Exception Ex)
            {
                return Ex.Message;
            }
        }
    }
}
