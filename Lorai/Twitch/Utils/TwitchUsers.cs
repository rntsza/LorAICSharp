using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorai.Twitch.Utils
{
    public class TwitchUsers
    {
        public TwitchUsers()
        {

        }

        public TwitchUsers(int twitchID, string username, string message)
        {
            TwitchID = twitchID;
            Username = username ?? throw new ArgumentNullException(nameof(username));
            Message = message ?? throw new ArgumentNullException(nameof(message));
        }


        #region Geral
        public int Id { get; set; }
        public int TwitchID { get; set; }
        public string Username { get; set; }
        public string Message { get; set; }
        #endregion
    }
}
