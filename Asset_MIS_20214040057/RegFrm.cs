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
    public partial class RegFrm : Form
    {
        public RegFrm()
        {
            InitializeComponent();
            Random random = new Random();
            int vercode = random.Next(1000, 10000);
            VerCode.Text = vercode.ToString();
        }

        private void BackLoginBtn_Click(object sender, EventArgs e)
        {
            Login loginfrm = new Login();
            this.Hide();
            loginfrm.ShowDialog(this);
            Application.ExitThread();
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            //注册信息输入
            string username = Username.Text;
            string passwd = Passwd.Text;
            string repasswd = RePasswd.Text;
            string inputvercode = InputVerCode.Text;
            if(inputvercode == VerCode.Text) { 
            int ismanage = 0;
            if (IsManage.Checked)
            {
                ismanage = 1;
            }
            else
            {
                ismanage = 0;
            }

            //连接数据库
            if(username !="" && passwd != "" && repasswd != "")
            {
                if (passwd == repasswd)
                {
                    //输入无误，操作数据库

                    //连接数据库
                    string connstr = "Data Source=.;Initial Catalog=Asset_DB;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(connstr);
                    conn.Open();
                    //查询输入用户名是否存在
                    string sqlstr = "select * from Staff_Table where Staff_Uid ='" + username + "'";
                    SqlCommand cmd = new SqlCommand(sqlstr, conn);

                    SqlDataAdapter sdr = new SqlDataAdapter(sqlstr, conn);
                    DataTable dt = new DataTable();
                    sdr.Fill(dt);

                    if (dt.Rows.Count == 0)//执行完查询后，返回的行数
                    {
                        String sql = "insert into Staff_Table values('" + username + "','" + passwd + "','" + ismanage + "')";//SQL语句向表中写入数据
                        SqlCommand comm = new SqlCommand(sql, conn);
                        int x = comm.ExecuteNonQuery();

                        if (x > 0)
                        {
                            MessageBox.Show("注册成功");

                        }

                    }
                    else//查询结果不是0
                    {
                        MessageBox.Show("该用户已存在");
                    }

                }
                else
                {
                    MessageBox.Show("两次密码要一致！！！");
                }
            }
            else
            {
                MessageBox.Show("账号或密码不能为空！！！");
            }

            //写入数据
        }
    }

        private void VerCode_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int vercode = random.Next(1000, 10000);
            VerCode.Text = vercode.ToString();
        }
    }
}
