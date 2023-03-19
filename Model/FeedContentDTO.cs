using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MauiApp3
{
    public class FeedContentDTO
    {
        public int UserFeedId { get; set; }
        public int UserAccountId { get; set; }
        [Required(ErrorMessage = "FeedContent is required")]
        public string FeedContent { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public List<FeedAttachmentDTO> FeedAttachments { get; set; }
        public UserProfileDTO UserProfile { get; set; }

    }
}
