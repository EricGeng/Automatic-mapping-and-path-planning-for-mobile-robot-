using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using SCIP_library;
using MathWorks.MATLAB.NET.Arrays;
//using MathWorks.MATLAB.NET.Utility;
using Modeling;
using Pathplanning;

namespace Auto_laser
{
    class Program
    {
        //初始值定义
        const int GET_NUM = 1;
        const int start_step = 0;
        const int d_times = 17;
        const int end_step = 1080;
        static NetworkStream stream;
        static TcpClient urg;
        static Socket socketsend;
        static SerialPort port;                          //serialport 
        static List<byte> signal = new List<byte>();     //data received from laser
        static string s;                                 //key word of socket
        static  int txt_num = 0;                                 //文本计数器
        static int sum = 1;                                     //扫描次数
        static int txt_name = 1;                                //文件名字
        static int o = 20;                                      //向上转要改这里的次数   0不计入  从1开始  80   -120
        // static List<List<double>> a = new List<List<double>>();
        static List<double> a = new List<double>();


        static void Main(string[] args)
        {
            /*-----------------create data file folder-----------------------------*/
            if (!Directory.Exists(".\\" + "laser_data"))
            {
                Directory.CreateDirectory(".\\" + "laser_data");
            }
            /*-----------------start serialport connect---------------------*/
            port = new SerialPort("COM4", 9600);
            port.Encoding = Encoding.ASCII;
            //port.Open();
            Console.WriteLine("port ready!");
            /*-----------------socket communication build------------*/
            socketsend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //create a new socket to receive the data from server
            IPAddress ip = IPAddress.Parse("192.0.0.10");//this is the ip of server computer
            IPEndPoint point = new IPEndPoint(ip, 2055);//port of communication
            socketsend.Connect(point);
            Console.WriteLine("connect to server successfully!");
            /*---------------------start laser thread---------------*/
           /* Thread laser = new Thread(link);
            laser.IsBackground = true;
            laser.Start();
            /*---------------------main control --------------------*/
            while (true)
            {
                byte[] buffer = new byte[1024];
                int r = socketsend.Receive(buffer);
                string receive_data = read_line(stream);
                s = Encoding.UTF8.GetString(buffer, 0, r);
                Console.WriteLine(s);
                if (s == "TL")        //通信自检
                {
                    toSend("TT");     //如果连接正常，这条语句执行正常，服务端会加收到“TT”
                    port.Write("2");
                }
                else if (s == "GL")   //开启功能自检功能
                {
                    if (receive_data!= null)
                    {
                        port.Write("3");
                        toSend("CT");
                        SendFile("C:/Users/EricGeng/Desktop/prewiew.jpg");
                    }
                }
                else if (s == "SL")   //开机正常扫描功能
                {
                    string value = ReadSerialData();
                    toSend("aa");                             //扫描前获取imu数据
                    List<double> imu = new List<double>();
                    s = Encoding.UTF8.GetString(buffer, 0, r);
                    List<string> ss = new List<string>();
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (s[j] != 'a')         //每个imu的数据后面加上‘a'的校验位，检测校验位来分割数据，写入list中
                        {
                            ss.Add(s[j].ToString());
                        }
                        else
                        {
                            string[] sss = ss.ToArray();  //list->string[]->string ，然后转化double格式的
                            string ssss = string.Join("", sss);
                            imu.Add(Convert.ToDouble(ssss));
                        }
                    }
                    double[] TR = new double[] { };
                    double[] TT = new double[] { };
                    double[] xyz = new double[] { };
                    double[] omap = new double[] { };
                    double[] rmap = new double[] { };
                    double[] fmap = new double[] { };
                    double[] ftra = new double[] { };
                    double[] bound = new double[] { };
                    double[] ocm = new double[] { };
                    double[] f = new double[] { };
                    double[] f102 = new double[] { };
                    //model meed
                    MWNumericArray Xyz = new MWNumericArray(3, 3, xyz);
                    MWNumericArray tr = new MWNumericArray(3, 3, TR);
                    MWNumericArray tt = new MWNumericArray(3, 1, TT);
                    MWNumericArray Ocm = new MWNumericArray(3, 3, ocm);
                    MWNumericArray Bound = new MWNumericArray(3,3,bound);
                    //path need
                    MWNumericArray Omap = new MWNumericArray(3, 3, omap);
                    MWNumericArray Rmap = new MWNumericArray(3, 3, rmap);
                    MWNumericArray Fmap = new MWNumericArray(3, 3, fmap);
                    MWNumericArray Ftra = new MWNumericArray(3, 3, ftra);
                    MWNumericArray F = new MWNumericArray(3, 3, f);
                    MWNumericArray F102 = new MWNumericArray(3, 3, f102);

                    MWArray[] ttt = new MWArray[] { tr, tt, Xyz, Bound, Ocm };
                    MWArray[] ppp = new MWArray[] {F, F102, Omap, Rmap, Fmap, Ftra };
                    if (value == "1")
                    {
                        Start(txt_name, o);      //==小车  内部630   总985    1600     总2.4s 
                        sum++;
                        o--;//俯仰角   !!!!!!!!!!!!!                                            
                        if (sum > 140)//(为防止多赚一次6-7，arduino顺序多加了serial.1)
                        {
                            o = o + sum - 1;
                            sum = 1;
                            txt_num = 0;
                            txt_name++;//文件名要累积加+1
                            Model mm = new Model();
                            double[] aa = a.ToArray();
                            MWArray bb = (MWNumericArray)aa;
                            double[] Imu = imu.ToArray();
                            MWNumericArray IMU = Imu;
                            //[XYZ_total,circle_point,map_x,map_y,x_left,x_right,y_down,y_up,bound_new,bound_old,TR,TT,oppupencyMap]=Modeling(m,modeling_num,imu,TR,TT,XYZ_total,oppupencyMap,bound_old)
                            MWArray[] result = mm.Modeling(13, bb, txt_num, IMU, ttt[0], ttt[1], ttt[2], ttt[3], ttt[4]);
                            MWArray[] result_old = result;
                            ttt[0] = result_old[10]; 
                            ttt[1] = result_old[11];
                            ttt[2] = result_old[12];
                            ttt[3] = result_old[0];
                            ttt[4] = result_old[9];
                            //Thread.Sleep(8000);//这是复位的线程暂停时间 20S 
                            Lujing path = new Lujing();//路径规划模块
                          //[path_point,F,F012,oppupencyMap,reacha  bleMap,froniterMap,final_target]=Pathplanning(modeling_num,XYZ_total,circle_point,map_x,map_y,x_left,...
                          //                            x_right,y_down,y_up,bound_new,bound_old,F,F012,oppupencyMap,reachableMap,froniterMap,final_target)
                            MWArray[] pas = path.Pathplanning(7, txt_name, result[0], result[1], result[2], result[3], result[4], result[5], result[6], result[7], result[8], result[9],ppp[0], ppp[1], ppp[2], ppp[3], ppp[4], ppp[5]);
                            MWArray[] path_old = pas;
                            ppp[0] = path_old[1];
                            ppp[1] = path_old[2];
                            ppp[2] = path_old[3];
                            ppp[3] = path_old[4];
                            ppp[4] = path_old[5];
                            ppp[5] = path_old[6];
                            Console.WriteLine("完成环境建模模块");
                            //toSend(pas[0].ToString());
                            using (StreamWriter fsb = new StreamWriter(".\\laser_data\\" + txt_name + "_路径全部数据" + ".txt", true))
                            {
                                fsb.WriteLine(pas[0].ToString());

                            }
                            /*using (FileStream fsRead = new FileStream(".\\laser_data\\" + txt_name + "_路径全部数据" + ".txt", FileMode.Open, FileAccess.Read))
                            {
                                byte[] buffer1 = new byte[1024 * 1024 * 5];
                                int rr = fsRead.Read(buffer, 0, buffer1.Length);
                                List<byte> list = new List<byte>();
                                //list.Add(1);
                                list.AddRange(buffer1);
                                byte[] newBuffer = list.ToArray();
                                socketsend.Send(newBuffer, 0, rr, SocketFlags.None);
                            */
                            SendFile(".\\laser_data\\" + txt_name + "_路径全部数据" + ".txt");
                            a.Clear();     //完成扫描后清除数据，为下一轮做准备
                            imu.Clear();   
                        }
                        else
                        {
                            port.WriteLine(value);
                        }
                    }
                }
                else
                    continue;
            }
        }
       // static List<List<double>> data = new List<List<double>>();//动态二维数组
        /// <summary>
        /// 给下位机arduino发“2”代表激光板和arduino之间的通信自检，发“3”代表功能自检，需要运动电机
        /// </summary>
        static void link()
        {
            /*--------------bulid laser tcp/ip connect----------------*/
            string ip_address;
            int port_number;
            //get_connect_information(out ip_address, out port_number);
            ip_address = "192.168.0.10";
            port_number = 10940;
            urg = new TcpClient();
            urg.Connect(ip_address, port_number);
            Console.WriteLine("linking\n");
            stream = urg.GetStream();
            write(stream, SCIP_Writer.SCIP2());
            read_line(stream);                           // ignore echo back
            write(stream, SCIP_Writer.MD(start_step, end_step));
            read_line(stream);                           // ignore echo back
            Console.WriteLine("link to radar successfully!\n");
        }
        /// <summary>
        /// 激光数据获取部分，list a中储存获取的数据，在激光工作的时候一直调用这个模块。
        /// </summary>
        /// <param name="q"></param>
        /// <param name="o"></param>
        static void Start(int q,int o)
        {
            List<long> distances = new List<long>();
            long time_stamp = 0;int z = 0;
            for(int i=1 ; i<d_times+1; i++)
            {
                string receive_data = read_line(stream);
                if (!SCIP_Reader.MD(receive_data, ref time_stamp, ref distances))//数据驱动
                {
                    Console.WriteLine(receive_data);
                    break;
                }
                if (distances.Count == 0)
                {
                    Console.WriteLine(receive_data);
                    continue;
                }
                z++;
                if(z==16)
                {
                    using (StreamWriter fsb = new StreamWriter(".\\laser_data\\" + q + "_R50mm全部数据" + ".txt", true))
                    {
                        for (int j = 180; j < 901; j++)    //180-901
                        {
                            fsb.WriteLine(" distance[" + j.ToString() + "] : " + j.ToString() + " " + distances[j].ToString() + " " + o.ToString());
                            a.Add(j);
                            a.Add(distances[i]);
                            a.Add(o);
                        }
                    }
                }
            }
            //return a;
        }
        static string ReadSerialData()
        {
            string value = "";
            if (port != null && port.BytesToRead > 0)
            {
                value = port.ReadExisting();
            }
            return value;
        }
        static void toSend(string e)
        {
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(e);
            socketsend.Send(buffer);
        }
        static void disposeserialport()       //销毁串口
        {
            if (port != null)
            {
                if (port.IsOpen)
                {
                    port.Close();
                }
                port.Dispose();
            }
        }
        static void unlink()
        {
            write(stream, SCIP_Writer.QT());    // stop measurement mode
            read_line(stream); // ignore echo back
            stream.Close();
            urg.Close();
        }
        static bool write(NetworkStream stream, string data)
        {
            if (stream.CanWrite)
            {
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                stream.Write(buffer, 0, buffer.Length);
                return true;
            }
            else
            {
                return false;
            }
        }
        static string read_line(NetworkStream stream)
        {
            if (stream.CanRead)
            {
                StringBuilder sb = new StringBuilder();
                bool is_NL2 = false;
                bool is_NL = false;
                do
                {
                    char buf = (char)stream.ReadByte();
                    if (buf == '\n')
                    {
                        if (is_NL)
                        {
                            is_NL2 = true;
                        }
                        else
                        {
                            is_NL = true;
                        }
                    }
                    else
                    {
                        is_NL = false;
                    }
                    sb.Append(buf);
                } while (!is_NL2);

                return sb.ToString();
            }
            else
            {
                return null;
            }
        }
        //发送文件
        static void SendFile(string path)
        {
            //string path = @"C:\Users\cj\Desktop\10.18ceshi\SerialCommunication\bin\Debug\map.jpg";
            using (FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer1 = new byte[1024 * 1024 * 5];
                int rr = fsRead.Read(buffer1, 0, buffer1.Length);
                List<byte> list = new List<byte>();
                //list.Add(1);
                list.AddRange(buffer1);
                byte[] newBuffer = list.ToArray();
                socketsend.Send(newBuffer, 0, rr, SocketFlags.None);
            }

        }

    }
}
    