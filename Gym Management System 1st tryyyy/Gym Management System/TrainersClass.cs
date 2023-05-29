using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System
{
    class TrainersClass
    {
        public static void InsertTrainer(string TName, string TPhone, int TAge, int TSalary)
        {

            DataAccess.ExecuteNonQuery("Inserttrainer",
                        DataAccess.CreateParameters("@TName", SqlDbType.NVarChar, TName),
                        DataAccess.CreateParameters("@TPhone", SqlDbType.NVarChar, TPhone),
                        DataAccess.CreateParameters("@TAge", SqlDbType.Int, TAge),
                        DataAccess.CreateParameters("@TSalary", SqlDbType.Money, TSalary)            
                       );

        }
        public static void UpdateTrainer(int TId, string TName, string TPhone, int TAge, int TSalary)
        {

            DataAccess.ExecuteNonQuery("Updatetrainer",
                        DataAccess.CreateParameters("@TId", SqlDbType.NVarChar, TId),
                        DataAccess.CreateParameters("@TName", SqlDbType.NVarChar, TName),
                        DataAccess.CreateParameters("@TPhone", SqlDbType.NVarChar, TPhone),
                        DataAccess.CreateParameters("@TAge", SqlDbType.Int, TAge),
                        DataAccess.CreateParameters("@TSalary", SqlDbType.Int, TSalary)
                       );

        }
        public static void DeleteTrainer(int TId)
        { 

           DataAccess.ExecuteNonQuery("Deletetrainer",
               DataAccess.CreateParameters("@TId", SqlDbType.Int, TId)
               );
        }
        public static DataTable GetAllTrainers()
        {

            DataTable dt = new DataTable();
            dt = DataAccess.SelectData("GetAllTrainers", null);
            return dt;

        }
    }
}
