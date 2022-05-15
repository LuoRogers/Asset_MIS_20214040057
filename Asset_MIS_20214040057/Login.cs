using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_MIS_20214040057
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            RegFrm regfrm = new RegFrm();
            this.Hide();
            regfrm.ShowDialog(this);
            Application.ExitThread();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string passwd = Passwd.Text;


            //1.连接数据库
            //连接数据库
            string connstr = "Data Source=.;Initial Catalog=Asset_DB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            //创建SqlCommand对象：数据命令对象，主要功能向数据库发送查询、更新、删除、修改操作的SQL语句
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandText = "select * from Staff_Table where Staff_Uid = '" + username + "'";
            // 用SqlDataReader类对象从SQL Server数据库中读取行
            SqlDataReader sdr;
            sdr = comm.ExecuteReader();


            //2.判断用户名和密码是否是数据库一致
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    if (username == sdr["Staff_Uid"].ToString() && passwd == sdr["Password"].ToString())//判定的是输入的和数据库里的数据
                    {
                        if (sdr["IsManage"].ToString() == "True")
                        {
                            MessageBox.Show("管理员，登录成功");

                        }
                        else
                        {
                            MessageBox.Show("普通用户，登录成功");

                        }


                    }
                    else
                    {
                        MessageBox.Show("账号或者密码错误");
                    }
                }
            }
            else
            {
                MessageBox.Show("请检查用户名是否存在");
            }

        }

        private void Showpwd_CheckedChanged(object sender, EventArgs e)
        {
            if (Showpwd.Checked == true)
            {
                Passwd.UseSystemPasswordChar = false;
            }
            else
            {
                Passwd.UseSystemPasswordChar = true;
            }
        }

        private void Forgot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("要不您再好好想想");
        }
    }
}
