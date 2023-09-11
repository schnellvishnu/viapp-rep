using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using Npgsql;

namespace responsive_app
{
    public partial class printerjobs : Form
    {
        JArray alljsondata = new JArray();
        string[] slnoarray;
        JArray alljsondata1 = new JArray();
        public printerjobs(string testvalue)
        {
            InitializeComponent();
            txtpo.Text = testvalue;

        }

        private void printerjobs_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[1024];
            byte[] bytes1 = new byte[1024];
            byte[] bytes2 = new byte[1024];
            byte[] bytes3 = new byte[1024];
            byte[] bytes4 = new byte[1024];

            byte[] bytes5 = new byte[1024];
            byte[] bytes6 = new byte[1024];
            byte[] bytes7 = new byte[1024];
            byte[] bytes8 = new byte[1024];
            byte[] bytes9 = new byte[1024];


            byte[] bytes10 = new byte[1024];
            byte[] bytes11 = new byte[1024];
            byte[] bytes12 = new byte[1024];
            byte[] bytes13 = new byte[1024];
            byte[] bytes14 = new byte[1024];
            try
            {
                // Connect to a Remote server
                // Get Host IP Address that is used to establish a connection
                // In this case, we get one IP address of localhost that is IP : 127.0.0.1
                // If a host has multiple addresses, you will get a list of addresses
                //IPHostEntry host = Dns.GetHostEntry("192.168.200.150");
                IPAddress ipAddress = IPAddress.Parse("192.168.200.150");
                //IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 34567);

                // Create a TCP/IP  socket.
                Socket sender1 = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);



                // Connect the socket to the remote endpoint. Catch any errors.
                try
                {
                    // Connect to Remote EndPoint
                    sender1.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}",
                        sender1.RemoteEndPoint.ToString());
                    // string[] slnoarray = { "455666", "566666" };

                    // string[] slnoarray = allJsonData.ToObject<string[]>();

                    // Encode the data string into a byte array.
                    if (txttype.Text == "type27")
                    {
                        byte[] msg = Encoding.ASCII.GetBytes("L,new3.lbl\x04");
                        // Send the data through the socket.
                        int bytesSent = sender1.Send(msg);
                        // Receive the response from the remote device.
                        int bytesRec = sender1.Receive(bytes);


                        msg = Encoding.ASCII.GetBytes("E\x04");
                        int bytesSent1 = sender1.Send(msg);
                        int bytesRec1 = sender1.Receive(bytes1);


                        foreach (string slno in slnoarray)
                        {


                            msg = Encoding.ASCII.GetBytes("QAH\x09qrcode\x09gtin1\x09gtinvalue\x09" + "exp\x09" + "exp1\x09lot\x09lotvalue\x09slno\x09slnovalue\x04");
                            int bytesSent2 = sender1.Send(msg);
                            int bytesRec2 = sender1.Receive(bytes2);

                            msg = Encoding.ASCII.GetBytes("QAC\x09" + "(01)" + txtgtin.Text + "(17)" + txtexp.Text + "(10)" + txtlot.Text + "(21)" + slno + "\x09" + "GTIN\x09" + txtgtin.Text + "\x09" + "Exp\x09" + txtexp.Text + "\x09Lot" + "\x09" + txtlot.Text + "\x09Slno" + "\x09" + slno + "\x04");
                            int bytesSent3 = sender1.Send(msg);
                            int bytesRec3 = sender1.Receive(bytes3);


                            msg = Encoding.ASCII.GetBytes("F2\x04");
                            int bytesSent4 = sender1.Send(msg);
                            int bytesRec4 = sender1.Receive(bytes4);



                            //msg = Encoding.ASCII.GetBytes("QAS\x09value\x0a"+"bdebaa\x09\x04"+"F2\x04");
                            //int bytesSent2 = sender1.Send(msg);
                            // int bytesRec2 = sender1.Receive(bytes2);
                            txtresponseprinter.Text = Encoding.ASCII.GetString(bytes, 0, bytesRec) + " " + Encoding.ASCII.GetString(bytes1, 0, bytesRec1) + " " + Encoding.ASCII.GetString(bytes2, 0, bytesRec2) + " " + Encoding.ASCII.GetString(bytes3, 0, bytesRec3) + " " + Encoding.ASCII.GetString(bytes4, 0, bytesRec4);
                            //textBox4.Text = Encoding.ASCII.GetString(bytes1, 0, bytesRec1);

                        };
                    }
                    else if (txttype.Text == "type29")
                    {
                        byte[] msg1 = Encoding.ASCII.GetBytes("L,new6.lbl\x04");
                        // Send the data through the socket.
                        int bytesSent5 = sender1.Send(msg1);
                        // Receive the response from the remote device.
                        int bytesRec5 = sender1.Receive(bytes5);


                        msg1 = Encoding.ASCII.GetBytes("E\x04");
                        int bytesSent6 = sender1.Send(msg1);
                        int bytesRec6 = sender1.Receive(bytes6);


                        foreach (string slno in slnoarray)
                        {




                            msg1 = Encoding.ASCII.GetBytes("QAH\x09" + "datamatrix" + "\x09" + "exp\x09" + "exp1\x09lot\x09lotvalue\x09gtin1\x09gtinvalue\x09slno\x09slnovalue" + "\x09" + "hrf" + "\x09" + "hrfvalue" + "\x04");
                            int bytesSent7 = sender1.Send(msg1);
                            int bytesRec7 = sender1.Receive(bytes7);

                            msg1 = Encoding.ASCII.GetBytes("QAC\x09" + "(17)" + txtexp.Text + "(10)" + txtlot.Text + "(01)" + txtgtin.Text + "(21)" + slno + "(714)" + hrfvalue.Text + "\x09" + "Exp\x09" + txtexp.Text + "\x09Lot" + "\x09" + txtlot.Text + "\x09" + "GTIN\x09" + txtgtin.Text + "\x09Slno" + "\x09" + slno + "\x09" + hrfkey.Text + "\x09" + hrfvalue.Text + "\x04");
                            int bytesSent8 = sender1.Send(msg1);
                            int bytesRec8 = sender1.Receive(bytes8);


                            msg1 = Encoding.ASCII.GetBytes("F2\x04");
                            int bytesSent9 = sender1.Send(msg1);
                            int bytesRec9 = sender1.Receive(bytes9);



                            //msg = Encoding.ASCII.GetBytes("QAS\x09value\x0a"+"bdebaa\x09\x04"+"F2\x04");
                            //int bytesSent2 = sender1.Send(msg);
                            // int bytesRec2 = sender1.Receive(bytes2);
                            txtresponseprinter.Text = Encoding.ASCII.GetString(bytes5, 0, bytesRec5) + " " + Encoding.ASCII.GetString(bytes6, 0, bytesRec6) + " " + Encoding.ASCII.GetString(bytes7, 0, bytesRec7) + " " + Encoding.ASCII.GetString(bytes8, 0, bytesRec8) + " " + Encoding.ASCII.GetString(bytes9, 0, bytesRec9);
                            //textBox4.Text = Encoding.ASCII.GetString(bytes1, 0, bytesRec1);

                        };

                    }
                    else if (txttype.Text == "type25")
                    {
                        byte[] msg2 = Encoding.ASCII.GetBytes("L,new5.lbl\x04");
                        // Send the data through the socket.
                        int bytesSent10 = sender1.Send(msg2);
                        // Receive the response from the remote device.
                        int bytesRec10 = sender1.Receive(bytes10);


                        msg2 = Encoding.ASCII.GetBytes("E\x04");
                        int bytesSent11 = sender1.Send(msg2);
                        int bytesRec11 = sender1.Receive(bytes11);


                        foreach (string slno in slnoarray)
                        {




                            msg2 = Encoding.ASCII.GetBytes("QAH\x09" + "datamatrix" + "\x09" + "exp\x09" + "exp1\x09lot\x09lotvalue\x09gtin1\x09gtinvalue\x09slno\x09slnovalue" + "\x04");
                            int bytesSent12 = sender1.Send(msg2);
                            int bytesRec12 = sender1.Receive(bytes12);

                            msg2 = Encoding.ASCII.GetBytes("QAC\x09" + "(17)" + txtexp.Text + "(10)" + txtlot.Text + "(01)" + txtgtin.Text + "(21)" + slno + "(714)" + hrfvalue.Text + "\x09" + "Exp\x09" + txtexp.Text + "\x09Lot" + "\x09" + txtlot.Text + "\x09" + "GTIN\x09" + txtgtin.Text + "\x09Slno" + "\x09" + slno + "\x04");
                            int bytesSent13 = sender1.Send(msg2);
                            int bytesRec13 = sender1.Receive(bytes13);


                            msg2 = Encoding.ASCII.GetBytes("F2\x04");
                            int bytesSent14 = sender1.Send(msg2);
                            int bytesRec14 = sender1.Receive(bytes14);



                            //msg = Encoding.ASCII.GetBytes("QAS\x09value\x0a"+"bdebaa\x09\x04"+"F2\x04");
                            //int bytesSent2 = sender1.Send(msg);
                            // int bytesRec2 = sender1.Receive(bytes2);
                            txtresponseprinter.Text = Encoding.ASCII.GetString(bytes10, 0, bytesRec10) + " " + Encoding.ASCII.GetString(bytes11, 0, bytesRec11) + " " + Encoding.ASCII.GetString(bytes12, 0, bytesRec12) + " " + Encoding.ASCII.GetString(bytes13, 0, bytesRec13) + " " + Encoding.ASCII.GetString(bytes14, 0, bytesRec14);
                            //textBox4.Text = Encoding.ASCII.GetString(bytes1, 0, bytesRec1);

                        };

                    }
                    // Release the socket.
                    sender1.Shutdown(SocketShutdown.Both);
                    sender1.Close();




                }

                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e1)
                {
                    Console.WriteLine("Unexpected exception : {0}", e1.ToString());
                }

            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.ToString());
            }
        }

        private void txtpo_TextChanged(object sender, EventArgs e)
        {
            string po = txtpo.Text;
            string strConnString = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=DB4";
            NpgsqlConnection conn = new NpgsqlConnection(strConnString);


            string sql = "SELECT lot,expiration_date,numbers,gtin,type,hrf FROM masterapp_printerdatatable where processordernumber ='" + po + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

            conn.Open();


            using (NpgsqlDataReader saReader = cmd.ExecuteReader())
            {

                while (saReader.Read())
                {
                    //DateTime.ToString()
                    //string expdate1 = saReader.GetString(1);
                    //string expdate2 = DateTime.ToString(expdate1);

                    txtlot.Text = saReader.GetString(0);
                    txtexp.Text = Convert.ToDateTime(saReader["expiration_date"]).ToString("dd/MM/yyyy");
                    //var resultObject = new JavaScriptSerializer().Deserialize<UserDetails>(input_json);
                    // txtslno.Text = JObject.Parse(saReader.GetString(2));
                    slnolist.Text = "";
                    var json = JsonConvert.DeserializeObject(saReader.GetString(2));
                    JArray alljsondata = new JArray();
                    //string tempData = saReader.GetString(2);
                    alljsondata = JArray.Parse(json.ToString());
                    int jsoncount = alljsondata.Count;
                    slnolist.Items.Add(alljsondata);
                    //int length = ((JArray)test["alljsondata"]).Count;

                    slnoarray = new string[jsoncount];
                    int i = 0;

                    foreach (string item in alljsondata)
                    {
                        Console.Write(item + " ");
                        slnoarray[i] = item;
                        i++;
                    }





                    //txtslno.Text = allJsonData;
                    txtgtin.Text = saReader.GetString(3);
                    txttype.Text = saReader.GetString(4);
                    //txtnoofcarton.Text = saReader.GetString(5);



                    if (txttype.Text == "type5" || txttype.Text == "type1")
                    {
                        var sa = saReader.GetString(5);
                        //////////////////////////////////////////////////////////
                        if (sa == null && sa == "")
                        {
                            hrfvalue.Text = "";
                            hrfkey.Text = "";
                        }


                        else if (sa != null && sa != "")
                        {

                            var json1 = JsonConvert.DeserializeObject<dynamic>(saReader.GetString(5));

                            JObject jobj = JObject.Parse(json1);

                            string hrf1key = (string)jobj["hrf1"];
                            string hrf1value = (string)jobj["hrf1value"];
                            string hrf2key = (string)jobj["hrf2"];
                            string hrf2value = (string)jobj["hrf2value"];

                            string hrf3key = (string)jobj["hrf3"];
                            string hrf3value = (string)jobj["hrf3value"];


                            string hrf4key = (string)jobj["hrf4"];
                            string hrf4value = (string)jobj["hrf4value"];

                            string hrf5key = (string)jobj["hrf5"];
                            string hrf5value = (string)jobj["hrf5value"];

                            string hrf6key = (string)jobj["hrf6"];
                            string hrf6value = (string)jobj["hrf6value"];


                            if (hrf1key != null && hrf1key != "")
                            {
                                hrfkey.Text = hrf1key;
                            }
                            else if (hrf2key != null && hrf2key != "")
                            {
                                hrfkey.Text = hrf2key;

                            }
                            else if (hrf3key != null && hrf3key != "")
                            {
                                hrfkey.Text = hrf3key;

                            }

                            else if (hrf4key != null && hrf4key != "")
                            {
                                hrfkey.Text = hrf4key;

                            }

                            else if (hrf5key != null && hrf5key != "")
                            {
                                hrfkey.Text = hrf5key;

                            }

                            else if (hrf6key != null && hrf6key != "")
                            {
                                hrfkey.Text = hrf6key;

                            }
                            if (hrf1value != null && hrf1value != "")
                            {
                                hrfvalue.Text = hrf1value;

                            }
                            else if (hrf2value != null && hrf2value != "")
                            {
                                hrfvalue.Text = hrf2value;

                            }
                            else if (hrf3value != null && hrf3value != "")
                            {
                                hrfvalue.Text = hrf3value;

                            }
                            else if (hrf4value != null && hrf4value != "")
                            {
                                hrfvalue.Text = hrf4value;

                            }
                            else if (hrf5value != null && hrf5value != "")
                            {
                                hrfvalue.Text = hrf5value;

                            }
                            else if (hrf6value != null && hrf6value != "")
                            {
                                hrfvalue.Text = hrf6value;

                            }

                        }
                    }



                }
            }
            conn.Close();
        }
    }
}
