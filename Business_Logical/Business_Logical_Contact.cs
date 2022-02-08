using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access;
using Business_Entity;

namespace Business_Logical
{
    public class Business_Logical_Contact
    {
        public object Read()
        {
            try
            {
                return new Data_Access_Contact().Read();
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
                if (new Data_Access_Contact().Exist(Cnt) == "FALSE")
                {
                    return new Data_Access_Contact().Create(Cnt);
                }
                else
                {
                    return "شماره و یا نام تکراری می باشد";
                }
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
                return new Data_Access_Contact().Delete(Delete_ID);
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
                return new Data_Access_Contact().Update(ID,Contact_Update_Data);
            }
            catch (Exception Ex)
            {
                return Ex.Message;
            }
        }
    }
}
