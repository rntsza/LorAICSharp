using System;
using TwitchLib.Client.Models;
using TwitchLib.Api;
using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Api.V5.Models.Users;
using Lorai.Twitch.Utils;
using Lorai.Properties;

namespace Lorai.Twitch
{
    internal class TwitchChatBot
    {
        AutoIT twitchAuto = new AutoIT();


        ConnectionCredentials credentials = new ConnectionCredentials(Configs.BotUsername, Configs.BotToken);
        TwitchClient client;
        TwitchAPI api = new TwitchAPI();

        public TwitchChatBot()
        {

        }

        internal void Connect()
        {
            Console.WriteLine("Connecting");
            client = new TwitchClient();

            client.Initialize(credentials, Configs.ChannelName);
            client.OnLog += Client_OnLog;
            client.OnConnectionError += Client_OnConnectionError;
            // Until here, thats all ok

            // 
            client.OnMessageReceived += Client_OnMessageReceived;
            //

            client.Connect();

            api.Settings.ClientId = Configs.ClientID;
        }

        private void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            if (e.ChatMessage.Message != null)
            {
                //Console.WriteLine("Saved on database!");

                if (e.ChatMessage.Message.Contains("!StartGame") || e.ChatMessage.Message.Contains("!startgame"))
                {
                    twitchAuto.StartGame("PvE", 1);
                    client.SendMessage(Configs.ChannelName, $"Starting a new game, fasten your seat belts! {e.ChatMessage.DisplayName}");
                    
                    //client.SendMessage(Configs.ChannelName, $"We already in a game! NotLikeThis {e.ChatMessage.DisplayName}");
                }
                if (e.ChatMessage.Message.Contains("!Replace") || e.ChatMessage.Message.Contains("!replace") || e.ChatMessage.Message.Contains("Replace") || e.ChatMessage.Message.Contains("replace"))
                {
                    string commandLine = e.ChatMessage.Message;
                    string[] message = commandLine.Split(' ');
                    Console.WriteLine(message);
                    
                    if (message.Length == 2)
                    {
                        twitchAuto.ReplaceCards(message[1]);
                    } else if (message.Length == 3)
                    {
                        twitchAuto.ReplaceCards(message[1], message[2]);
                    } else if (message.Length == 4)
                    {
                        twitchAuto.ReplaceCards(message[1], message[2], message[3]);
                    } else if (message.Length == 5)
                    {
                        twitchAuto.ReplaceCards(message[1], message[2], message[3], message[4]);
                    } else
                    {
                        twitchAuto.DontReplaceCards();
                    }
                }
                if (e.ChatMessage.Message.Contains("!Surrender") || e.ChatMessage.Message.Contains("!surrender") || e.ChatMessage.Message.Contains("!ff"))
                {
                    twitchAuto.Surrender();
                }


                //SaveDataBase(e.ChatMessage.DisplayName, e.ChatMessage.UserId, e.ChatMessage.Message);
            }

        }

        TimeSpan? GetUpTime()
        {
            string userId = GetUserId(Configs.ChannelName);
            if (userId == null)
            {
                return null;
            }

            return api.V5.Streams.GetUptimeAsync(userId).Result;
        }

        string GetUserId(string username)
        {
            User[] userList = api.V5.Users.GetUserByNameAsync(username).Result.Matches;
            if (userList == null || userList.Length == 0)
            {
                return null;
            }
            return userList[0].Id;
        }

        private void Client_OnLog(object sender, OnLogArgs e)
        {
            Console.WriteLine(e.Data);
        }
        private void Client_OnConnectionError(object sender, OnConnectionErrorArgs e)
        {
            Console.WriteLine($"Erro! : {e.Error}");
        }

        internal void Disconnect()
        {
            Console.WriteLine("Disconnecting");
        }

        
        private void SaveDataBase(string twitchid, string userid, string message)
        {
            HistoryDB db = new HistoryDB();
            TwitchUsers user = new TwitchUsers();

            user.Username = twitchid;
            user.Message = message;
            user.TwitchID = int.Parse(userid);

            db.TwitchUsers.Add(user);
            db.SaveChanges();
        }
        
    }
}
