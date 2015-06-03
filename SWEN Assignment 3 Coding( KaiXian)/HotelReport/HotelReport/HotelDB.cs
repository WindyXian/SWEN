using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace HotelReport
{
    class HotelDB
    {
        private const string GSM_CONN_STR = "data source=localhost;initial catalog=HotelDB;integrated security=true;";

        //Room status report
        public static ArrayList GetAllRoomStatus()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList products = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT * From Room";
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Rooms p = new Rooms();
                    p.RoomNum = (int)dr["RoomNumber"];
                    p.RoomType = (string)dr["RoomType"];
                    p.Floor = (int)dr["Floor"];
                    p.Status = (string)dr["Status"];
                    products.Add(p);
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return products;

        }

        //List all the guest in 1 room report
        public static ArrayList GetOccupantNumbers(int rmNo)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList numOccu = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT b.NumberOfAdults , b.NumberOfChildren From Booking b, Room r Where r.RoomNumber = @Rmno and r.BookingID = b.BookingID";
                comm.Parameters.AddWithValue("@rmNo", rmNo);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Rooms p = new Rooms();
                    p.Adult = (int)dr["NumberOfAdults"];
                    p.Children = (int)dr["NumberOfChildren"];
                    numOccu.Add(p);
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return numOccu;
        }

        public static ArrayList GetOccupantNumbersByID(int id)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList numOccu = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT NumberOfAdults , NumberOfChildren From Booking Where BookingID = @id";
                comm.Parameters.AddWithValue("@id", id);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Rooms p = new Rooms();
                    p.Adult = (int)dr["NumberOfAdults"];
                    p.Children = (int)dr["NumberOfChildren"];
                    numOccu.Add(p);
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return numOccu;
        }

        //Room occupacny report

        //Daily
        public static ArrayList GetStatsByDay(DateTime date)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList rmCount = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT COUNT(BookingID) as \"TotalCount\" From CheckInOut Where CheckInDate <= @date AND CheckOutDate >= @date";
                comm.Parameters.AddWithValue("@date", date);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    RoomCounts r = new RoomCounts();
                    r.TotalCount = (int)dr["TotalCount"];
                    rmCount.Add(r);
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return rmCount;
        }

        public static ArrayList GetFloor2StatsByDay(DateTime date)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList rmCount = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT COUNT(r.RoomNumber) as \"TotalCount\" From Room r, Booking b,CheckInOut c Where r.Floor = 2 AND c.CheckInDate <= @date AND c.CheckOutDate >= @date AND r.BookingID=b.BookingID AND b.BookingID = c.BookingID";
                comm.Parameters.AddWithValue("@date", date);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    RoomCounts r = new RoomCounts();
                    r.PerFloorCount = (int)dr["TotalCount"];
                    rmCount.Add(r);
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return rmCount;
        }

        public static ArrayList GetFloor3StatsByDay(DateTime date)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList rmCount = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT COUNT(r.RoomNumber) as \"TotalCount\" From Room r, Booking b,CheckInOut c Where r.Floor = 3 AND c.CheckInDate <= @date AND c.CheckOutDate >= @date AND r.BookingID=b.BookingID AND b.BookingID = c.BookingID";
                comm.Parameters.AddWithValue("@date", date);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    RoomCounts r = new RoomCounts();
                    r.PerFloorCount = (int)dr["TotalCount"];
                    rmCount.Add(r);
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return rmCount;
        }

        //Weekly
        public static ArrayList GetStatsByWeek(int week, int year)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList rmCount = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT COUNT(BookingID) as \"TotalCount\" FROM CheckInOut WHERE DATEPART(WEEK,CheckInDate)=@week OR DATEPART(WEEK,CheckOutDate)=@week AND YEAR(CheckInDate)=@year AND Year(CheckOutDate)=@year";
                comm.Parameters.AddWithValue("@week", week);
                comm.Parameters.AddWithValue("@year", year);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    RoomCounts r = new RoomCounts();
                    r.TotalCount = (int)dr["TotalCount"];
                    rmCount.Add(r);
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return rmCount;
        }

        public static ArrayList GetFloor2StatsByWeek(int week, int year)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList rmCount = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT COUNT(r.RoomNumber) as \"TotalCount\" From Room r, Booking b,CheckInOut c Where r.Floor = 2 AND (DATEPART(WEEK,CheckInDate)=@week OR DATEPART(WEEK,CheckOutDate)=@week AND YEAR(CheckInDate)=@year AND Year(CheckOutDate)=@year) AND r.BookingID=b.BookingID AND b.BookingID = c.BookingID";
                comm.Parameters.AddWithValue("@week", week);
                comm.Parameters.AddWithValue("@year", year);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    RoomCounts r = new RoomCounts();
                    r.PerFloorCount = (int)dr["TotalCount"];
                    rmCount.Add(r);
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return rmCount;
        }

        public static ArrayList GetFloor3StatsByWeek(int week, int year)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList rmCount = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT COUNT(r.RoomNumber) as \"TotalCount\" From Room r, Booking b,CheckInOut c Where r.Floor = 3 AND (DATEPART(WEEK,CheckInDate)=@week OR DATEPART(WEEK,CheckOutDate)=@week AND YEAR(CheckInDate)=@year AND Year(CheckOutDate)=@year) AND r.BookingID=b.BookingID AND b.BookingID = c.BookingID";
                comm.Parameters.AddWithValue("@week", week);
                comm.Parameters.AddWithValue("@year", year);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    RoomCounts r = new RoomCounts();
                    r.PerFloorCount = (int)dr["TotalCount"];
                    rmCount.Add(r);
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return rmCount;
        }

        //Monthly
        public static ArrayList GetStatsByMonth(DateTime date)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList rmCount = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT COUNT(BookingID) as \"TotalCount\" From CheckInOut Where DATEPART(MONTH,CheckInDate)=@month OR DATEPART(MONTH,CheckOutDate)=@month";
                comm.Parameters.AddWithValue("@month", date.Month);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    RoomCounts r = new RoomCounts();
                    r.TotalCount = (int)dr["TotalCount"];
                    rmCount.Add(r);
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return rmCount;
        }

        public static ArrayList GetFloor2StatsByMonth(DateTime date)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList rmCount = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT COUNT(r.RoomNumber) as \"TotalCount\" From Room r, Booking b,CheckInOut c Where r.Floor = 2 AND (DATEPART(MONTH,CheckInDate)=@month OR DATEPART(MONTH,CheckOutDate)=@month) AND r.BookingID=b.BookingID AND b.BookingID = c.BookingID";
                comm.Parameters.AddWithValue("@month", date.Month);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    RoomCounts r = new RoomCounts();
                    r.PerFloorCount = (int)dr["TotalCount"];
                    rmCount.Add(r);
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return rmCount;
        }

        public static ArrayList GetFloor3StatsByMonth(DateTime date)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList rmCount = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT COUNT(r.RoomNumber) as \"TotalCount\" From Room r, Booking b,CheckInOut c Where r.Floor = 3 AND (DATEPART(MONTH,CheckInDate)=@month OR DATEPART(MONTH,CheckOutDate)=@month) AND r.BookingID=b.BookingID AND b.BookingID = c.BookingID";
                comm.Parameters.AddWithValue("@month", date.Month);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    RoomCounts r = new RoomCounts();
                    r.PerFloorCount = (int)dr["TotalCount"];
                    rmCount.Add(r);
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return rmCount;
        }

        //Yearly
        public static ArrayList GetStatsByYear(DateTime date)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList rmCount = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT COUNT(BookingID) as \"TotalCount\" From CheckInOut Where DATEPART(YEAR,CheckInDate)=@year OR DATEPART(YEAR,CheckOutDate)=@year";
                comm.Parameters.AddWithValue("@year", date.Year);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    RoomCounts r = new RoomCounts();
                    r.TotalCount = (int)dr["TotalCount"];
                    rmCount.Add(r);
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return rmCount;
        }

        public static ArrayList GetFloor2StatsByYear(DateTime date)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList rmCount = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT COUNT(r.RoomNumber) as \"TotalCount\" From Room r, Booking b,CheckInOut c Where r.Floor = 2 AND (DATEPART(YEAR,CheckInDate)=@year OR DATEPART(YEAR,CheckOutDate)=@year) AND r.BookingID=b.BookingID AND b.BookingID = c.BookingID";
                comm.Parameters.AddWithValue("@year", date.Year);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    RoomCounts r = new RoomCounts();
                    r.PerFloorCount = (int)dr["TotalCount"];
                    rmCount.Add(r);
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return rmCount;
        }

        public static ArrayList GetFloor3StatsByYear(DateTime date)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList rmCount = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT COUNT(r.RoomNumber) as \"TotalCount\" From Room r, Booking b,CheckInOut c Where r.Floor = 3 AND (DATEPART(YEAR,CheckInDate)=@year OR DATEPART(YEAR,CheckOutDate)=@year) AND r.BookingID=b.BookingID AND b.BookingID = c.BookingID";
                comm.Parameters.AddWithValue("@year", date.Year);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    RoomCounts r = new RoomCounts();
                    r.PerFloorCount = (int)dr["TotalCount"];
                    rmCount.Add(r);
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return rmCount;
        }


        //List all guest and room at specific date report
        public static ArrayList GetAllGuestAndRoomFromDate(DateTime date)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList rms = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT r.RoomNumber, r.RoomType, b.BookingID, b.NumberOfAdults, b.NumberOfChildren From Room r, Booking b,CheckInOut c Where c.CheckInDate <= @date AND c.CheckOutDate >= @date AND r.BookingID=b.BookingID AND b.BookingID = c.BookingID";
                comm.Parameters.AddWithValue("@date", date);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Rooms r = new Rooms();
                    r.RoomNum = (int)dr["RoomNumber"];
                    r.RoomType = (string)dr["RoomType"];
                    r.BookingID = (int)dr["BookingID"];
                    r.Adult = (int)dr["NumberOfAdults"];
                    r.Children = (int)dr["NumberOfChildren"];
                    rms.Add(r);
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return rms;
        }


        //House Keeping Report

        //Daily
        public static ArrayList GetScheduleDaily(DateTime date)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList dutySche = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT EmployeeID, Duty From DutySchedule Where FromDate <= @date AND ToDate >= @date";
                comm.Parameters.AddWithValue("@date", date);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Duties d = new Duties();
                    d.EmployeeID = (int)dr["EmployeeID"];
                    d.Duty = (string)dr["Duty"];
                    dutySche.Add(d);
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return dutySche;
        }

        //Weekly
        public static ArrayList GetScheduleWeekly(int week, int year)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList dutySche = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT EmployeeID, Duty From DutySchedule WHERE DATEPART(WEEK,FromDate)=@week OR DATEPART(WEEK,ToDate)=@week AND YEAR(FromDate)=@year AND Year(ToDate)=@year";
                comm.Parameters.AddWithValue("@week", week);
                comm.Parameters.AddWithValue("@year", year);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Duties d = new Duties();
                    d.EmployeeID = (int)dr["EmployeeID"];
                    d.Duty = (string)dr["Duty"];
                    dutySche.Add(d);
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return dutySche;
        }

        //Monthly
        public static ArrayList GetScheduleMonthly(DateTime date)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList dutySche = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT EmployeeID, Duty From DutySchedule Where DATEPART(MONTH,FromDate)=@month OR DATEPART(MONTH,ToDate)=@month";
                comm.Parameters.AddWithValue("@month", date.Month);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Duties d = new Duties();
                    d.EmployeeID = (int)dr["EmployeeID"];
                    d.Duty = (string)dr["Duty"];
                    dutySche.Add(d);
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return dutySche;
        }

        //Login
        public static ArrayList GetLoginInfo(int id, string pass)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList info = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT Type From Account Where EmployeeID = @id AND Password = @pass";
                comm.Parameters.AddWithValue("@id", id);
                comm.Parameters.AddWithValue("@pass", pass);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    ReportLogin rl = new ReportLogin();
                    rl.Type = (string)dr["Type"];
                    info.Add(rl);
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return info;
        }


    }
}
