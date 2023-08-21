using System;
using System.Net;
using System.Net.Http;
using System.Text;
using DiscordMessenger;
using Discord;
using Discord.Webhook;

namespace DiscordSendWebhook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void sendDisWebhook(string url, string json)
        {
#pragma warning disable SYSLIB0014 // Type or member is obsolete
            var wr = WebRequest.Create(url);
            wr.ContentType = "application/json";
            wr.Method = "POST";
            using (var sw = new StreamWriter(wr.GetRequestStream()))
                sw.Write(json);
            wr.GetResponse();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "cs" && textBox3.Text == "cs")
            {
                new DiscordMessage()
                .SetUsername("C-Sharp")
                .SetContent(textBox4.Text)
                .SendMessage("https://discord.com/api/webhooks/1054812847969927269/JXpinyBFwG5ByeNfO-oTfCzkulIlKqwY9lEupmtdrDY9ea7PMdSUcIv05NIF4JmRpGsR");

                var message = new DiscordMessage
                {
                    Content = "kek"
                };
            }
            else
            {
                new DiscordMessage()
                    .SetUsername("C-Sharp")
                    .SetContent(textBox4.Text)
                    .SendMessage("https://discord.com/api/webhooks/" + textBox3.Text + "/" + textBox2.Text);

                var message = new DiscordMessage
                {
                    Content = "kek"
                };
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int nt = int.Parse(textBox5.Text);

            if (nt < 20)
            {
                while (i < nt)
                {
                    if (textBox2.Text == "cs" && textBox3.Text == "cs")
                    {
                        new DiscordMessage()
                        .SetUsername("C-Sharp")
                        .SetContent(textBox4.Text)
                        .SendMessage("https://discord.com/api/webhooks/1054812847969927269/JXpinyBFwG5ByeNfO-oTfCzkulIlKqwY9lEupmtdrDY9ea7PMdSUcIv05NIF4JmRpGsR");

                        var message = new DiscordMessage
                        {
                            Content = "kek"
                        };
                    }
                    else
                    {
                        new DiscordMessage()
                            .SetUsername("C-Sharp")
                            .SetContent(textBox4.Text)
                            .SendMessage("https://discord.com/api/webhooks/" + textBox3.Text + "/" + textBox2.Text);

                        var message = new DiscordMessage
                        {
                            Content = "kek"
                        };
                    }
                    System.Threading.Thread.Sleep(200);
                    i++;
                }
            }if(nt < 50 && nt > 20)
            {
                while (i < nt-20)
                {
                    if (textBox2.Text == "cs" && textBox3.Text == "cs")
                    {
                        new DiscordMessage()
                        .SetUsername("C-Sharp")
                        .SetContent(textBox4.Text)
                        .SendMessage("https://discord.com/api/webhooks/1054812847969927269/JXpinyBFwG5ByeNfO-oTfCzkulIlKqwY9lEupmtdrDY9ea7PMdSUcIv05NIF4JmRpGsR");

                        var message = new DiscordMessage
                        {
                            Content = "kek"
                        };
                    }
                    else
                    {
                        new DiscordMessage()
                            .SetUsername("C-Sharp")
                            .SetContent(textBox4.Text)
                            .SendMessage("https://discord.com/api/webhooks/" + textBox3.Text + "/" + textBox2.Text);

                        var message = new DiscordMessage
                        {
                            Content = "kek"
                        };
                    }
                    System.Threading.Thread.Sleep(200);
                    i++;
                }
                System.Threading.Thread.Sleep(500);
                while (i < 20)
                {
                    if (textBox2.Text == "cs" && textBox3.Text == "cs")
                    {
                        new DiscordMessage()
                        .SetUsername("C-Sharp")
                        .SetContent(textBox4.Text)
                        .SendMessage("https://discord.com/api/webhooks/1054812847969927269/JXpinyBFwG5ByeNfO-oTfCzkulIlKqwY9lEupmtdrDY9ea7PMdSUcIv05NIF4JmRpGsR");

                        var message = new DiscordMessage
                        {
                            Content = "kek"
                        };
                    }
                    else
                    {
                        new DiscordMessage()
                            .SetUsername("C-Sharp")
                            .SetContent(textBox4.Text)
                            .SendMessage("https://discord.com/api/webhooks/" + textBox3.Text + "/" + textBox2.Text);

                        var message = new DiscordMessage
                        {
                            Content = "kek"
                        };
                    }
                    System.Threading.Thread.Sleep(200);
                    i++;
                }
            }if(nt < 201 && nt > 50)
            {
                int ii = 0;
                while(ii < 11)
                {
                    while (i < nt / 10)
                    {
                        if (textBox2.Text == "cs" && textBox3.Text == "cs")
                        {
                            new DiscordMessage()
                            .SetUsername("C-Sharp")
                            .SetContent(textBox4.Text)
                            .SendMessage("https://discord.com/api/webhooks/1054812847969927269/JXpinyBFwG5ByeNfO-oTfCzkulIlKqwY9lEupmtdrDY9ea7PMdSUcIv05NIF4JmRpGsR");

                            var message = new DiscordMessage
                            {
                                Content = "kek"
                            };
                        }
                        else
                        {
                            new DiscordMessage()
                                .SetUsername("C-Sharp")
                                .SetContent(textBox4.Text)
                                .SendMessage("https://discord.com/api/webhooks/" + textBox3.Text + "/" + textBox2.Text);

                            var message = new DiscordMessage
                            {
                                Content = "kek"
                            };
                        }
                        System.Threading.Thread.Sleep(200);
                        i++;
                    }
                    System.Threading.Thread.Sleep(500);
                    ii++;
                }
            }else
            {
                int ii = 0;
                while (ii < 21)
                {
                    while (i < nt / 20)
                    {
                        if (textBox2.Text == "cs" && textBox3.Text == "cs")
                        {
                            new DiscordMessage()
                            .SetUsername("C-Sharp")
                            .SetContent(textBox4.Text)
                            .SendMessage("https://discord.com/api/webhooks/1054812847969927269/JXpinyBFwG5ByeNfO-oTfCzkulIlKqwY9lEupmtdrDY9ea7PMdSUcIv05NIF4JmRpGsR");

                            var message = new DiscordMessage
                            {
                                Content = "kek"
                            };
                        }
                        else
                        {
                            new DiscordMessage()
                                .SetUsername("C-Sharp")
                                .SetContent(textBox4.Text)
                                .SendMessage("https://discord.com/api/webhooks/" + textBox3.Text + "/" + textBox2.Text);

                            var message = new DiscordMessage
                            {
                                Content = "kek"
                            };
                        }
                        System.Threading.Thread.Sleep(200);
                        i++;
                    }
                    System.Threading.Thread.Sleep(500);
                    ii++;
                }
            }
        }
    }
}