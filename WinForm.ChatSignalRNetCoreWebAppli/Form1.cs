using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.AspNetCore.SignalR.Client;

namespace WinForm.ChatSignalRNetCoreWebAppli
{
    public partial class Form1 : Form
    {
        HubConnection connection;
        public Form1()
        {
            InitializeComponent();

            connection = new HubConnectionBuilder()
            .WithUrl("https://localhost:5001/chatHub/")
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
                    //if (to == txtFrom.Text)
                    //{


                    var tox = to;
                        var newMessage = $"{user}: {message}";
                        messagesList.Items.Add(newMessage);
                    //}

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
            try
            {
                await connection.InvokeAsync("SendMessagePrivate",
                    ctUser.Text, txtFrom.Text, ctMessage.Text);
                //messagesList.Items.Add($"{txtFrom.Text}:{ctMessage.Text}");
            }
            catch (Exception ex)
            {
                messagesList.Items.Add(ex.Message);
            }

        }
    }
}
