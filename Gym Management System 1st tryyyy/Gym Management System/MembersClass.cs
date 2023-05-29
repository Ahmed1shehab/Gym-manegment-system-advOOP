using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System
{
    class MembersClass 
    {

        public static void InsertMember(string MName,string MPhone, int MAge, string MGender, string MPlan, int TId)
        {

            DataAccess.ExecuteNonQuery("Insertmember",                        
                        DataAccess.CreateParameters("@MName", SqlDbType.NVarChar, MName),
                        DataAccess.CreateParameters("@MPhone", SqlDbType.NVarChar, MPhone),
                        DataAccess.CreateParameters("@MAge", SqlDbType.Int, MAge),
                        DataAccess.CreateParameters("@MGender", SqlDbType.NVarChar, MGender),
                        DataAccess.CreateParameters("@MPlan", SqlDbType.NVarChar, MPlan),
                        DataAccess.CreateParameters("@TId", SqlDbType.Int, TId)
                       );

        }



        public static void DeleteMember(int MId)
        {
            DataAccess.ExecuteNonQuery("DeleteMember",
                          DataAccess.CreateParameters("@MId", SqlDbType.Int, MId)

                                    );
        }



        public static void UpdateMember(int MId, string MName, string MPhone, int MAge, string MGender, string MPlan, int TId)
        {

            DataAccess.ExecuteNonQuery("Updatemember",
                DataAccess.CreateParameters("@MId", SqlDbType.Int, MId),
                DataAccess.CreateParameters("@MName", SqlDbType.NVarChar,MName),
                DataAccess.CreateParameters("@MPhone", SqlDbType.NVarChar, MPhone),
                DataAccess.CreateParameters("@MAge", SqlDbType.Int, MAge),
                DataAccess.CreateParameters("@MGender", SqlDbType.NVarChar, MGender),
                DataAccess.CreateParameters("@MPlan", SqlDbType.NVarChar, MPlan),
                DataAccess.CreateParameters("@TId", SqlDbType.Int, TId)
                );
                
        }


        public static DataSet GetAllMembers()
        {

            return DataAccess.GetDataSet("GetAllMembers", "member");

        }
        public static DataTable SearchByName()
        {

            DataTable dt = new DataTable();
            dt = DataAccess.SelectData("SearchByName", null);
            return dt;

        }
    }
}
