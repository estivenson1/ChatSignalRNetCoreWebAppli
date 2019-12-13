using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.ChatSignalRNetCoreWebAppli.Enums;
using Common.ChatSignalRNetCoreWebAppli.Models;
using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;

namespace WinForm.ChatSignalRNetCoreWebAppli
{
    public partial class Form1 : Form
    {
        HubConnection connection;
        public Form1()
        {
            InitializeComponent();

            //string url = "http://localhost:50894/chatHub/";
            string url = "https://localhost:5001/chatHub/";

            connection = new HubConnectionBuilder()
            .WithUrl(url)
            .Build();

            connection.Closed += async (error) =>
            {
                await Task.Delay(new Random().Next(0, 5) * 1000);
                await connection.StartAsync();
            };
        }

        private async void btConectar_Click(object sender, EventArgs e)
        {
            connection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                //this.Dispatcher.Invoke(() =>
                //{
                //    var newMessage = $"{user}: {message}";
                //    messagesList.Items.Add(newMessage);
                //});


                this.Invoke((Action)(() =>
                {
                    //if (to == txtFrom.Text)
                    //{
                    var newMessage = $"{user}: {message}";
                    messagesList.Items.Add(newMessage);
                    //}

                }));


            });

            connection.On<string, string, string>("ReceiveMessagePrivate", (user, to, message) =>
            {
                this.Invoke((Action)(() =>
                {
                    if (to == ctUser.Text)
                    {
                        var tox = to;
                        var newMessage = $"{user}: {message}";
                        messagesList.Items.Add(newMessage);
                    }
                }));
            });

            connection.On<string, string, MsEvent>("ReceiveMessageServer", (user, to, message) =>
            {
                this.Invoke((Action)(async () =>
                {
                    string User = ctUser.Text + ctIdUser.Text;
                    if (to == User)
                    {


                        //EmployeeInfo employee = message.Data as EmployeeInfo;
                        //string json = JsonConvert.SerializeObject(message.Data);
                        // var emp = JsonConvert.DeserializeObject<EmployeeInfo>(json);

                        var emp = JsonConvert.DeserializeObject<EmployeeInfo>(message.Data.ToString());

                        // EmployeeInfo emp = await JsonSerializer.DeserializeAsync<EmployeeInfo>()

                        var tox = to;
                        var newMessage = $"{user}: {emp.iEmployeeNum + emp.tFirstName + emp.tLastName}";
                        messagesList.Items.Add(newMessage);

                      await  MsPrivad(to, message.To, "Hola 25: "+ message.To);
                    }
                }));
            });


            try
            {
                await connection.StartAsync();
                messagesList.Items.Add("Connection started");
                btConectar.Enabled = false;
                btSendMessage.Enabled = true;
            }
            catch (Exception ex)
            {
                messagesList.Items.Add(ex.Message);
            }
        }

        private async void btSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                await connection.InvokeAsync("SendMessage",
                    ctUser.Text, ctMessage.Text);
            }
            catch (Exception ex)
            {
                messagesList.Items.Add(ex.Message);
            }
        }

        private async void btMsPrivado_Click(object sender, EventArgs e)
        {
            string user = ctUser.Text + ctIdUser.Text;
            await  MsPrivad(user,ctTo.Text,ctMessage.Text);
        }
        private async Task MsPrivad(string user, string to, string message)
        {
            try
            {
                await connection.InvokeAsync("SendMessagePrivate", user, to, message);
            }
            catch (Exception ex)
            {
                messagesList.Items.Add(ex.Message);
            }
        }

        private async void btnMsEvent_Click(object sender, EventArgs e)
        {
            try
            {
                string user = ctUser.Text + ctIdUser.Text;
                MsEvent message = new MsEvent
                {
                    EventType = EventTypes.AddCounter.ToString(),
                    Message = "Hola Add Counter",
                    Data = new EmployeeInfo
                    {
                        iEmployeeNum = 1,
                        tFirstName = "Estivenson",
                        tLastName = "Perez taborda",
                        bNewCounter = true,
                        iCounter = 10,
                    },
                    To=user,
                };
              
                await connection.InvokeAsync("SendMessageServer", user, ctTo.Text, message);
            }
            catch (Exception ex)
            {
                messagesList.Items.Add(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
