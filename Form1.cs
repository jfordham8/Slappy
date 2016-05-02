using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net;
using System.IO;

namespace Slappy
{
    public partial class Form1 : Form
    {
        DateTime alarm = DateTime.Now;
        
        public Form1()
        {
            InitializeComponent();
            //COM7.Open();
            button1.Text = char.ConvertFromUtf32(8593);
            button2.Text = char.ConvertFromUtf32(8595);
            button3.Text = char.ConvertFromUtf32(8593);
            button4.Text = char.ConvertFromUtf32(8595);
            label4.Text = alarm.ToString("hh:mm tt");
            string time = DateTime.Now.ToString("hh:mm tt");
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //label4.Text = DateTime.Now.ToString("HH:mm");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            alarm = alarm.AddHours(1);
            label4.Text = alarm.ToString("hh:mm tt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            alarm = alarm.AddHours(-1);
            label4.Text = alarm.ToString("hh:mm tt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            alarm = alarm.AddMinutes(1);
            label4.Text = alarm.ToString("hh:mm tt");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            alarm = alarm.AddMinutes(-1);
            label4.Text = alarm.ToString("hh:mm tt");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //string requestmethod = "POST";
            //string postData = "var1=Hello&var2=Server!";
            //byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            //string URL = "http://www.google.com";
            string URL = textBox1.Text;
            int hour = (alarm.Hour % 12);
            string hour1 = hour.ToString();
            int min = alarm.Minute;
            string min1 = min.ToString();
            //string arg1 = alarm.Hour.ToString();
            string arg2 = alarm.Minute.ToString();
            string ampm = alarm.ToString("tt");
            if (ampm == "PM")
            {
                ampm = "1";
            }
            else if (ampm == "AM")
            {
                ampm = "0";
            }
            //Uri uriAddress = new Uri(textBox1.Text + '/' + hour + '/' + min + '/');
            string url1 = textBox1.Text;
            string test = "/Alarm/updateAlarmPreference?arg1=";
            string test2 = "&arg2=";
            Uri uriAddress = new Uri(url1 + test + hour1 + test2 + min1 + test2 + ampm);
            webBrowser1.Url = uriAddress;
            textBox2.Text = uriAddress.ToString();
            //string contenttype = "application/x-www-form-urlencoded";
            //string responseFromServer = null;
            //WebRequest request = WebRequest.Create(URL);
            //Stream dataStream;            
            //WebResponse response;            
            //StreamReader reader;            
            //request.Method = requestmethod;
            //request.ContentType = contenttype;
            //request.ContentLength = byteArray.Length;
            //dataStream = request.GetRequestStream();
            //dataStream.Write(byteArray, 0, byteArray.Length);
            //dataStream.Close();           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string URL = textBox1.Text;
            Uri uriAddress = new Uri(textBox1.Text + "/setAlarm");
            webBrowser1.Url = uriAddress;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string URL = textBox1.Text;
            Uri uriAddress = new Uri(textBox1.Text + "/Alarm/new?name=Alarm");
            webBrowser1.Url = uriAddress;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string URL = textBox1.Text;
            int hour = (alarm.Hour % 12);
            string hour1 = hour.ToString();
            int min = alarm.Minute;
            string min1 = min.ToString();
            //string arg1 = alarm.Hour.ToString();
            string arg2 = alarm.Minute.ToString();
            string ampm = alarm.ToString("tt");
            if (ampm == "PM")
            {
                ampm = "1";
            }
            else if (ampm == "AM")
            {
                ampm = "0";
            }
            //Uri uriAddress = new Uri(textBox1.Text + '/' + hour + '/' + min + '/');
            string url1 = textBox1.Text;
            string test = "/Alarm/updateAlarmPreference?arg1=";
            string test2 = "&arg2=";
            Uri uriAddress = new Uri(url1 + test + hour1 + test2 + min1 + test2 + ampm);
            webBrowser1.Url = uriAddress;
            textBox2.Text = uriAddress.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string url1 = "http://www.google.com";
            Uri uriAddress = new Uri(url1);
            webBrowser1.Url = uriAddress;
        }
    }
}
