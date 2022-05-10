using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winform0302_2.DTO;

namespace winform0302_2
{
    internal class DaoOracle
    {
        static DaoOracle inst;
        string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "User Id=test2;Password=1234;";

        OracleConnection conn;
        OracleCommand cmd;
        List<AddrUser> userList = new List<AddrUser>();

        public static DaoOracle Instance()
        {
            if (inst == null)
            {
                inst = new DaoOracle();
            }
            return inst;
        }

        public DaoOracle()
        {
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
            dbConn();
        }

        // 소멸자
        ~DaoOracle()
        {
            dbClose();
        }

        public void dbConn()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 DB 접속 성공");
            }
            catch (OracleException ex)
            {
                Console.WriteLine("접속 에러: " + ex.Message);
                return;
            }
        }

        public void dbClose()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                    Console.WriteLine("오라클 DB 접속 해제");
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("접속 해제 에러: " + ex.Message);
            }
        }

        public void createTable()
        {
            try
            {
                string sql = "create table testTB1 (" +
                    "id number not null," +
                    "name varchar2(20) not null," +
                    "age number not null," +
                    "addr varchar2(80) not null," +
                    "constraint pk_testTB1_id primary key(id))";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블 생성 성공!");

                string sql2 = "create sequence seq_id increment " +
                    "by 1 start with 1";
                cmd.CommandText = sql2;
                cmd.ExecuteNonQuery();
                Console.WriteLine("시퀀스 생성 성공!");
            }
            catch (OracleException ex)
            {
                Console.WriteLine("테이블+시퀀스 생성 에러: " + ex.Message);
            }
        }

        public void dropTable()
        {
            try
            {
                string sql = "drop table testTB1";
                cmd.Connection=conn;
                cmd.CommandText=sql;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블 삭제 성공!");

                string sql2 = "drop sequence seq_id";
                cmd.CommandText = sql2;
                cmd.ExecuteNonQuery();
                Console.WriteLine("시퀀스 삭제 성공!");
            }
            catch(OracleException ex)
            {
                Console.WriteLine("테이블+시퀀스 삭제 에러: " + ex.Message);
            }
        }

        public void insertDB()
        {
            try
            {
                string name = "홍길동";
                int age = 300;
                string addr = "조선 한양 홍대감댁 11번지";
                string sql = string.Format($"insert into testTB1 values " +
                    $"(seq_id.nextval, '{name}', {age}, '{addr}')");
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("데이터 추가 에러: " + ex.Message);
            }
        }

        public void insertDB(AddrUser user)
        {
            try
            {
                string sql = string.Format($"insert into testTB1 values " +
                    $"(seq_id.nextval, '{user.Name}', {user.Age}, '{user.Addr}')");
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("데이터 추가 에러: " + ex.Message);
            }
        }

        public void showDB()
        {
            try
            {
                string sql = "select * from testTB1 order by id desc";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("ID: " + reader["id"]);
                        Console.WriteLine("이름: " + reader["name"]);
                        Console.WriteLine("나이: " + reader["age"]);
                        Console.WriteLine("주소: " + reader["addr"]);
                        Console.WriteLine("-------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("데이터 보기 에러: " + ex.Message);
            }
        }

        public List<AddrUser> getDB()
        {
            try
            {
                string sql = "select * from testTB1 order by id desc";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                userList.Clear();
                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        userList.Add(new AddrUser(reader["name"].ToString(),int.Parse(reader["age"].ToString()),reader["addr"].ToString()));
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("데이터 보기 에러: " + ex.Message);
            }
            return userList;
        }

        public void updateDB()
        {
            try
            {
                string sql = "update testTB1 set name = '전우치' where id = 30";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("데이터 수정 에러: " + ex.Message);
            }
        }

        public void deleteDB()
        {
            try
            {
                string sql = "delete from testTB1 where id=20";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("데이터 삭제 에러: " + ex.Message);
            }
        }
    }
}
