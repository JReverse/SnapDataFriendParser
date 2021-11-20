using Newtonsoft.Json;

namespace SnapDataFriendParser.Classes
{
    public class Friend
    {
        public string Username { get; set; }

        [JsonProperty("Display Name")]
        public string DisplayName { get; set; }

        [JsonProperty("Creation Timestamp")]
        public string CreationTimestamp { get; set; }

        [JsonProperty("Last Modified Timestamp")]
        public string LastModifiedTimestamp { get; set; }
        public string Source { get; set; }
    }

    public class FriendRequestsSent
    {
        public string Username { get; set; }

        [JsonProperty("Display Name")]
        public string DisplayName { get; set; }

        [JsonProperty("Creation Timestamp")]
        public string CreationTimestamp { get; set; }

        [JsonProperty("Last Modified Timestamp")]
        public string LastModifiedTimestamp { get; set; }
        public string Source { get; set; }
    }

    public class BlockedUser
    {
        public string Username { get; set; }

        [JsonProperty("Display Name")]
        public string DisplayName { get; set; }

        [JsonProperty("Creation Timestamp")]
        public string CreationTimestamp { get; set; }

        [JsonProperty("Last Modified Timestamp")]
        public string LastModifiedTimestamp { get; set; }
        public string Source { get; set; }
    }

    public class DeletedFriend
    {
        public string Username { get; set; }

        [JsonProperty("Display Name")]
        public string DisplayName { get; set; }

        [JsonProperty("Creation Timestamp")]
        public string CreationTimestamp { get; set; }

        [JsonProperty("Last Modified Timestamp")]
        public string LastModifiedTimestamp { get; set; }
        public string Source { get; set; }
    }

    public class HiddenFriendSuggestion
    {
        public string Username { get; set; }

        [JsonProperty("Display Name")]
        public string DisplayName { get; set; }

        [JsonProperty("Creation Timestamp")]
        public string CreationTimestamp { get; set; }

        [JsonProperty("Last Modified Timestamp")]
        public string LastModifiedTimestamp { get; set; }
        public string Source { get; set; }
    }

    public class Shortcut
    {
        [JsonProperty("Shortcut Name")]
        public string ShortcutName { get; set; }
        public string Created { get; set; }
    }

    public class FriendKlass
    {
        public List<Friend> Friends { get; set; }

        [JsonProperty("Friend Requests Sent")]
        public List<FriendRequestsSent> FriendRequestsSent { get; set; }

        [JsonProperty("Blocked Users")]
        public List<BlockedUser> BlockedUsers { get; set; }

        [JsonProperty("Deleted Friends")]
        public List<DeletedFriend> DeletedFriends { get; set; }

        [JsonProperty("Hidden Friend Suggestions")]
        public List<HiddenFriendSuggestion> HiddenFriendSuggestions { get; set; }

        [JsonProperty("Ignored Snapchatters")]
        public List<object> IgnoredSnapchatters { get; set; }

        [JsonProperty("Pending Requests")]
        public List<object> PendingRequests { get; set; }
        public List<Shortcut> Shortcuts { get; set; }
    }


}
