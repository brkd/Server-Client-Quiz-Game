using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        static Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static bool connected = false;
        static bool turn = false, phase = false /*has the game started*/, collision = false, first= true;
        static readonly object _locker = new object(); //lock
        static string IP;
        static string name;


        public Form1()
        {
            InitializeComponent();
            
            CheckForIllegalCrossThreadCalls = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connection when clicked

            connectButton.Visible = false;

            if (collision)
            {
                //if the name is equal to other client's name

                name = player_q.Text;
                client.Send(Encoding.Default.GetBytes(name)); // send a new name
                collision = false;
                phase = true;
            }

            else if (!phase && !connected)
            {
                int port = int.Parse(portBox.Text);
                IP = IP_a.Text;
                name = player_q.Text;

                try
                {
                    if (first)
                    {
                        client.Connect(IP, port);
                        connected = true;
                        feed.Text = "Connected to the server..." + '\n';
                        first = false;
                        Thread receiver = new Thread(Receive);
                        receiver.Start();

                    }
                    //connection established


                    try
                    {
                        client.Send(Encoding.Default.GetBytes(name)); // send username, which must be unique
                        feed.Text += "Credentials sent." + '\n';
                        IP_a.Text = "";
                        player_q.Text = "";
                    }
                    catch
                    {
                        feed.Text = "Couldn't send credentials.";
                    }

                    
                }
                catch
                {
                    feed.Text = "There was a problem.";
                }
            }
            else if(phase)
            {
                //question is sent by the client
                string toBeSent;

                if (turn)
                {
                    toBeSent = player_q.Text + IP_a.Text;
                    try
                    {
                        client.Send(Encoding.Default.GetBytes(toBeSent));
                        IP_a.Text = "";
                        player_q.Text = "";

                    }
                    catch
                    {
                        feed.Text = "Couldn't send question.";
                    }
                }
                else
                {
                    toBeSent = IP_a.Text;
                    try
                    {
                        client.Send(Encoding.Default.GetBytes(toBeSent));
                        IP_a.Text = "";
                        player_q.Text = "";
                    }
                    catch
                    {
                        feed.Text = "Couldn't send guess.";
                    }
                }
            }
            

        }

        //Receiving message
        private void Receive(object obj)
        {
            phase = true;
            while (connected)
            {
                lock (_locker)
                {
                    

                    try
                    {
                        // try to receive messages while there is a connection
                        Byte[] buffer = new Byte[64];
                        client.Receive(buffer);
                        if ((Encoding.Default.GetString(buffer)).Substring(0, 15) == "Ask a question.") // if server asks you to ask a question
                        {
                            if (turn != true)
                            {
                                // necessary GUI changes
                                connectButton.Visible = true;
                                connectButton.BackColor = default(Color);
                                turn = true;
                                feed.Text += "Your turn. \n";
                                label1.Text = "Question";
                                label3.Text = "AnswerQQ";
                                label2.Visible = false;
                                label1.Visible = true;
                                player_q.Visible = true;
                                portBox.Visible = false;
                            }

                        }
                        else if (Encoding.Default.GetString(buffer).Substring(0, 30) == "Please enter a different name.") // if username is not unique
                        {
                            collision = true;
                            phase = false;
                            feed.Text += "Please enter a different name.\n";
                            connectButton.Visible = true;
                            IP_a.Text = IP;
                            player_q.Text = name;
                        }
                        else if (Encoding.Default.GetString(buffer).Substring(0, 1) == "1" || Encoding.Default.GetString(buffer).Substring(0, 1) == "0")
                        {
                            if (turn)
                            {
                                label3.Text = "Answer";
                                label2.Visible = false;
                                label1.Visible = false;
                                portBox.Visible = false;
                                player_q.Visible = false;
                                IP_a.Visible = false;


                            }
                            if (Encoding.Default.GetString(buffer).Substring(0, 1) == "1")
                            {
                                feed.Text += "Correct Answer! \n"; // both users will see these messages
                            }
                            else if (Encoding.Default.GetString(buffer).Substring(0, 1) == "0")
                            {
                                feed.Text += "Wrong Answer! \n";
                            }
                        }
                        else
                        {
                            // necessary GUI changes for answering a question
                            connectButton.Visible = true;
                            connectButton.BackColor = default(Color);
                            turn = false;
                            label3.Text = "Answer";
                            label2.Visible = false;
                            label1.Visible = false;
                            portBox.Visible = false;
                            player_q.Visible = false;
                            IP_a.Visible = true;
                            feed.Text += Encoding.Default.GetString(buffer);
                            feed.Text += '\n';


                        }
                        connectButton.Visible = true;
                        connectButton.BackColor=Color.Red;


                    }
                    catch
                    {
                        feed.Text = "Connection has failed"; //if the connection is severed.
                        connected = false;
                        label2.Visible = false;
                        label1.Visible = false;
                        label3.Visible = false;
                        portBox.Visible = false;
                        player_q.Visible = false;
                        connectButton.Visible = false;
                    }
                }
                
                
            }
        }

                
    }
	
    
}
        