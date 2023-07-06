using System.Collections.Generic;

namespace MauiApp3
{
    public class SocialFeedPayload
    {
        public List<FeedContentDto> FeedContents { get; set; }
        public List<UserProfileDto> UserProfiles { get; set; }
        public ulong? MaxRowVersion { get; set; } = 0;
        public ulong? MinRowVersion { get; set; } = 0;
    }
}
