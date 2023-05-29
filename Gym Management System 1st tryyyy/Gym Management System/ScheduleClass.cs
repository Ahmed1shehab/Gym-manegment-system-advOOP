using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System
{
     class ScheduleClass
    {
        public static void InsertSchedule(int SId, string SStart, string SFinish,int MId)
        {

            DataAccess.ExecuteNonQuery("insertschedule",
                        DataAccess.CreateParameters("@SId", SqlDbType.Int,SId),
                        DataAccess.CreateParameters("@SStart", SqlDbType.VarChar, SStart),
                        DataAccess.CreateParameters("@SFinish", SqlDbType.VarChar, SFinish),
                        DataAccess.CreateParameters("@MId", SqlDbType.Int, MId)
                       );
        }
        public static void UpdateSchedule(int SId, string SStart, string SFinish, int MId)
        {

            DataAccess.ExecuteNonQuery("updateschedule",
                        DataAccess.CreateParameters("@SId", SqlDbType.Int, SId),
                        DataAccess.CreateParameters("@SStart", SqlDbType.VarChar, SStart),
                        DataAccess.CreateParameters("@SFinish", SqlDbType.VarChar, SFinish),
                        DataAccess.CreateParameters("@MId", SqlDbType.Int, MId)
                       );
        }
        public static void DeleteMember(int SId)
        {
            DataAccess.ExecuteNonQuery("deleteschedule",
                          DataAccess.CreateParameters("@SId", SqlDbType.Int, SId)

                                    );
        }
    }
}
