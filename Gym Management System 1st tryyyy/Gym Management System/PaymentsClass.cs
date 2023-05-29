using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System
{
    class PaymentsClass
    {
        public static void InsertPayment(int PAmount, DateTime PDate, int MId)
        {

            DataAccess.ExecuteNonQuery("Insertpayment",
                        DataAccess.CreateParameters("@PAmount", SqlDbType.Money, PAmount),
                        DataAccess.CreateParameters("@PDate", SqlDbType.Date, PDate),     
                        DataAccess.CreateParameters("@MId", SqlDbType.Int, MId)

                       );

        }
    }
}
