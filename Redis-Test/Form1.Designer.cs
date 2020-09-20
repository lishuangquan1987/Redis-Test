namespace Redis_Test
{
    partial class RedisTest
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tb_psubscribe_channel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPsubscribe = new System.Windows.Forms.Button();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_subscribe_channel = new System.Windows.Forms.TextBox();
            this.rtbMsg = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Field_Hget = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHget = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Key_Hget = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Key_Get = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_Value_HSet = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_Value_Set = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_Field_Hset = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHset = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Key_Hset = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_Key_Set = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(77, 12);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(260, 21);
            this.tbIP.TabIndex = 0;
            this.tbIP.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(343, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tb_psubscribe_channel
            // 
            this.tb_psubscribe_channel.Location = new System.Drawing.Point(77, 39);
            this.tb_psubscribe_channel.Name = "tb_psubscribe_channel";
            this.tb_psubscribe_channel.Size = new System.Drawing.Size(100, 21);
            this.tb_psubscribe_channel.TabIndex = 3;
            this.tb_psubscribe_channel.Text = "*:set";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Channel:";
            // 
            // btnPsubscribe
            // 
            this.btnPsubscribe.Location = new System.Drawing.Point(183, 37);
            this.btnPsubscribe.Name = "btnPsubscribe";
            this.btnPsubscribe.Size = new System.Drawing.Size(75, 23);
            this.btnPsubscribe.TabIndex = 5;
            this.btnPsubscribe.Text = "Psubscribe";
            this.btnPsubscribe.UseVisualStyleBackColor = true;
            this.btnPsubscribe.Click += new System.EventHandler(this.btnPsubscribe_Click);
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(449, 37);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(75, 23);
            this.btnSubscribe.TabIndex = 8;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Channel:";
            // 
            // tb_subscribe_channel
            // 
            this.tb_subscribe_channel.Location = new System.Drawing.Point(343, 39);
            this.tb_subscribe_channel.Name = "tb_subscribe_channel";
            this.tb_subscribe_channel.Size = new System.Drawing.Size(100, 21);
            this.tb_subscribe_channel.TabIndex = 6;
            this.tb_subscribe_channel.Text = "mychannel";
            // 
            // rtbMsg
            // 
            this.rtbMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbMsg.Location = new System.Drawing.Point(0, 147);
            this.rtbMsg.Name = "rtbMsg";
            this.rtbMsg.Size = new System.Drawing.Size(694, 179);
            this.rtbMsg.TabIndex = 9;
            this.rtbMsg.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_Field_Hget);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnHget);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_Key_Hget);
            this.groupBox1.Controls.Add(this.btnGet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_Key_Get);
            this.groupBox1.Location = new System.Drawing.Point(20, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 75);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "获取值";
            // 
            // tb_Field_Hget
            // 
            this.tb_Field_Hget.Location = new System.Drawing.Point(144, 47);
            this.tb_Field_Hget.Name = "tb_Field_Hget";
            this.tb_Field_Hget.Size = new System.Drawing.Size(46, 21);
            this.tb_Field_Hget.TabIndex = 11;
            this.tb_Field_Hget.Text = "test";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Field:";
            // 
            // btnHget
            // 
            this.btnHget.Location = new System.Drawing.Point(196, 45);
            this.btnHget.Name = "btnHget";
            this.btnHget.Size = new System.Drawing.Size(45, 23);
            this.btnHget.TabIndex = 5;
            this.btnHget.Text = "Hget";
            this.btnHget.UseVisualStyleBackColor = true;
            this.btnHget.Click += new System.EventHandler(this.btnHget_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Key:";
            // 
            // tb_Key_Hget
            // 
            this.tb_Key_Hget.Location = new System.Drawing.Point(46, 47);
            this.tb_Key_Hget.Name = "tb_Key_Hget";
            this.tb_Key_Hget.Size = new System.Drawing.Size(46, 21);
            this.tb_Key_Hget.TabIndex = 3;
            this.tb_Key_Hget.Text = "mytest";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(196, 18);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(45, 23);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Key:";
            // 
            // tb_Key_Get
            // 
            this.tb_Key_Get.Location = new System.Drawing.Point(46, 20);
            this.tb_Key_Get.Name = "tb_Key_Get";
            this.tb_Key_Get.Size = new System.Drawing.Size(144, 21);
            this.tb_Key_Get.TabIndex = 0;
            this.tb_Key_Get.Text = "mykey";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_Value_HSet);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tb_Value_Set);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tb_Field_Hset);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnHset);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_Key_Hset);
            this.groupBox2.Controls.Add(this.btnSet);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_Key_Set);
            this.groupBox2.Location = new System.Drawing.Point(286, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 75);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设置值";
            // 
            // tb_Value_HSet
            // 
            this.tb_Value_HSet.Location = new System.Drawing.Point(233, 47);
            this.tb_Value_HSet.Name = "tb_Value_HSet";
            this.tb_Value_HSet.Size = new System.Drawing.Size(93, 21);
            this.tb_Value_HSet.TabIndex = 15;
            this.tb_Value_HSet.Text = "890";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(196, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "Value:";
            // 
            // tb_Value_Set
            // 
            this.tb_Value_Set.Location = new System.Drawing.Point(233, 20);
            this.tb_Value_Set.Name = "tb_Value_Set";
            this.tb_Value_Set.Size = new System.Drawing.Size(93, 21);
            this.tb_Value_Set.TabIndex = 13;
            this.tb_Value_Set.Text = "123";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(196, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "Value:";
            // 
            // tb_Field_Hset
            // 
            this.tb_Field_Hset.Location = new System.Drawing.Point(144, 47);
            this.tb_Field_Hset.Name = "tb_Field_Hset";
            this.tb_Field_Hset.Size = new System.Drawing.Size(46, 21);
            this.tb_Field_Hset.TabIndex = 11;
            this.tb_Field_Hset.Text = "test";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "Field:";
            // 
            // btnHset
            // 
            this.btnHset.Location = new System.Drawing.Point(332, 45);
            this.btnHset.Name = "btnHset";
            this.btnHset.Size = new System.Drawing.Size(45, 23);
            this.btnHset.TabIndex = 5;
            this.btnHset.Text = "Hset";
            this.btnHset.UseVisualStyleBackColor = true;
            this.btnHset.Click += new System.EventHandler(this.btnHset_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "Key:";
            // 
            // tb_Key_Hset
            // 
            this.tb_Key_Hset.Location = new System.Drawing.Point(46, 47);
            this.tb_Key_Hset.Name = "tb_Key_Hset";
            this.tb_Key_Hset.Size = new System.Drawing.Size(46, 21);
            this.tb_Key_Hset.TabIndex = 3;
            this.tb_Key_Hset.Text = "mytest";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(332, 20);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(45, 23);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "Key:";
            // 
            // tb_Key_Set
            // 
            this.tb_Key_Set.Location = new System.Drawing.Point(46, 20);
            this.tb_Key_Set.Name = "tb_Key_Set";
            this.tb_Key_Set.Size = new System.Drawing.Size(144, 21);
            this.tb_Key_Set.TabIndex = 0;
            this.tb_Key_Set.Text = "mykey";
            // 
            // RedisTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 326);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbMsg);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_subscribe_channel);
            this.Controls.Add(this.btnPsubscribe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_psubscribe_channel);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIP);
            this.Name = "RedisTest";
            this.Text = "RedisTest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tb_psubscribe_channel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPsubscribe;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_subscribe_channel;
        private System.Windows.Forms.RichTextBox rtbMsg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Field_Hget;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHget;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Key_Hget;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Key_Get;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_Value_HSet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_Value_Set;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_Field_Hset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_Key_Hset;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_Key_Set;
    }
}

