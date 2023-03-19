using System.Collections.Generic;

namespace MauiApp3
{
    public class SocialFeedPayload
    {
        public List<FeedContentDTO> FeedContents { get; set; }
        public List<UserProfileDTO> UserProfiles { get; set; }
    }
}
