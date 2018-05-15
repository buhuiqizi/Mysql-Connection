using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Mysql连接
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建数据库连接
            MySqlConnection mySql = new MySqlConnection("Database=myfirstweb;Data Source=127.0.0.1;User id=root;Password=LMBDsjkmm;SslMode=None;");
            //打开数据库
            mySql.Open();
            //建立一条数据库语句，并执行。(第一种方法)
            //MySqlCommand command = new MySqlCommand("insert into userinfo (u_id,u_name,u_password,u_sex,u_birthday,u_email,u_place) values ('4','佛祖','1234','男','1993-02-02','asfa@97.com','湖南')", mySql);
            ////command.ExecuteNonQuery();

            ////建立一条数据库语句，并执行。(第二种方法)
            //MySqlCommand command2 =new MySqlCommand("insert into userinfo (u_id,u_name,u_password,u_sex,u_birthday,u_email,u_place) values (@id,@name,@password,@sex,@birthday,@email,@diqu)", mySql);
            //command2.Parameters.AddWithValue("@id", '7');
            //command2.Parameters.AddWithValue("@name", "乙");
            //command2.Parameters.AddWithValue("@password", "asdfasdf");
            //command2.Parameters.AddWithValue("@sex", "男");
            //command2.Parameters.AddWithValue("@birthday", "1882-2-12");
            //command2.Parameters.AddWithValue("@email", "13424@12.com");
            //command2.Parameters.AddWithValue("@diqu", "山东");
            ////执行语句，并返回影响
            //Console.WriteLine(command2.ExecuteNonQuery());

            ////查询操作
            //MySqlCommand command3 = mySql.CreateCommand();
            ////command3.Connection=mySql2  可以指定连接的数据库
            //command3.CommandText = "select * from userinfo";
            //MySqlDataReader reader = command3.ExecuteReader();
            //while(reader.Read())
            //{
            //    Console.WriteLine(reader.GetInt32(0)+reader.GetString(1)+reader.GetString(2)+reader.GetString(3)+
            //        reader.GetString(4)+reader.GetString(5),reader.GetString(6));
            //}
            ////这时候的reader[0]为最后一条的第一个数据。
            //Console.WriteLine(reader[0]);

            ////更新操作
            //MySqlCommand command4=new MySqlCommand();
            //command4.Connection = mySql;
            //command4.CommandText = "UPDATE userinfo SET u_birthday = @birthday WHERE u_name = @name;";
            //command4.Parameters.AddWithValue("@birthday", "1999-9-9");
            //command4.Parameters.AddWithValue("@name", "甲");
            //int culm = command4.ExecuteNonQuery();
            //Console.WriteLine(culm);

            //删除数据也是用的ExecuteNonQuery方法，这里就不写了。

            //mySql.dispose;        一般情况下与Close没有什么区别
            mySql.Close();
        }
    }
}
