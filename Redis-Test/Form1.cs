using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackExchange.Redis;

namespace Redis_Test
{
    public partial class RedisTest : Form
    {
        ConnectionMultiplexer _connection;
        IDatabase _database;
        public RedisTest()
        {
            InitializeComponent();
            DisableButtons(new List<string>() { nameof(btnConnect)});
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbIP.Text))
            {
                MessageBox.Show("请输入IP地址");
                return;
            }
            try
            {
                _connection = ConnectionMultiplexer.Connect(this.tbIP.Text);
                _database = _connection.GetDatabase(0);//默认使用db0
                EnableButtons(new List<string>());
            }
            catch (Exception ex)
            {
                MessageBox.Show("连接Redis出错："+ex.Message);
                _connection = null;
                _database = null;
                DisableButtons(new List<string>() { nameof(btnConnect) });
            }
        }
        private void EnableButtons(List<string> exceptButtonNames)
        {
            var controls = FindAllButtons(this);
            controls = controls.Where(x => !exceptButtonNames.Contains(x.Name)).ToList();
            controls.ForEach(x => x.Enabled = true);
        }
        private void DisableButtons(List<string> exceptButtonNames)
        {
            var controls = FindAllButtons(this);
            controls = controls.Where(x => !exceptButtonNames.Contains(x.Name)).ToList();
            controls.ForEach(x => x.Enabled = false);
        }
        
        private List<Button> FindAllButtons(Control parentControl)
        {
            if (parentControl.Controls == null || parentControl.Controls.Count == 0)
            {
                return new List<Button>();
            }
            List<Button> results = new List<Button>();
            foreach (Control control in parentControl.Controls)
            {
                if (control is Button btn)
                {
                    results.Add(btn);
                }
                else
                {
                    results.AddRange(FindAllButtons(control));
                }
            }
            return results;
        }
        private void btnPsubscribe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_psubscribe_channel.Text))
            {
                MessageBox.Show("请输入psubscribe的通道名称或者匹配名称");
                return;
            }
            var subscibe = _connection.GetSubscriber();
            subscibe.Subscribe(this.tb_psubscribe_channel.Text, (channel, message) =>
             {
                 Log($"接收psubscribe消息,channel:{channel},message:{message}");
             });

        }
        private void Log(string msg)
        {
            this.Invoke(new Action(() =>
            {
                this.rtbMsg.AppendText($"[{DateTime.Now.ToString("yyyy-mm-dd HH:mm:ss")}]:{msg}\r\n");
            }));
            
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_subscribe_channel.Text))
            {
                MessageBox.Show("请输入subscribe的通道名称或者匹配名称");
                return;
            }
            var subscibe = _connection.GetSubscriber();
            subscibe.Subscribe(this.tb_subscribe_channel.Text, (channel, message) =>
            {
                Log($"接收subscribe消息,channel:{channel},message:{message}");
            });
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_Key_Get.Text))
            {
                MessageBox.Show("请输入key");
                return;
            }
            var result = _database.StringGet(this.tb_Key_Get.Text);
            Log($"Get key:{this.tb_Key_Get},Value:{result}");
        }

        private void btnHget_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_Key_Hget.Text))
            {
                MessageBox.Show("请输入key");
                return;
            }
            if (string.IsNullOrEmpty(this.tb_Field_Hget.Text))
            {
                MessageBox.Show("请输入field");
                return;
            }
            var result = _database.HashGet(this.tb_Key_Hget.Text,this.tb_Field_Hget.Text);
            Log($"HGet key:{this.tb_Key_Hget.Text},field:{this.tb_Field_Hget.Text},Value:{result}");
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_Key_Set.Text))
            {
                MessageBox.Show("请输入key");
                return;
            }
            if (string.IsNullOrEmpty(this.tb_Value_Set.Text))
            {
                MessageBox.Show("请输入Value");
                return;
            }
            var result = _database.StringSet(this.tb_Key_Set.Text,this.tb_Value_Set.Text);
            Log($"Set key:{this.tb_Key_Set.Text},Value:{this.tb_Value_Set.Text},result:{result}");
        }

        private void btnHset_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_Key_Hset.Text))
            {
                MessageBox.Show("请输入key");
                return;
            }
            if (string.IsNullOrEmpty(this.tb_Value_HSet.Text))
            {
                MessageBox.Show("请输入Value");
                return;
            }
            if (string.IsNullOrEmpty(this.tb_Field_Hset.Text))
            {
                MessageBox.Show("请输入field");
                return;
            }
            _database.HashSet(this.tb_Key_Hset.Text, this.tb_Field_Hset.Text, this.tb_Value_HSet.Text);
            Log($"HSet key:{this.tb_Key_Hset.Text},field:{this.tb_Field_Hset.Text},value:{this.tb_Value_HSet.Text}");
        }
    }
}
