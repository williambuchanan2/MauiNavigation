using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MauiApp3
{
    public partial class FeedContentDto : ObservableObject
    {
        public int UserFeedId { get; set; }
        public int UserAccountId { get; set; }
        // [Required(ErrorMessage = "FeedContent is required")]
        public string FeedContent { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime LastSavedDateTime { get; set; }
        public List<FeedAttachmentDto> FeedAttachments { get; set; }
        public int AttachmentHeight { get; set; }
        public UserProfileDto UserProfile { get; set; }
        public bool LocallyDeleted { get; set; }
        public ulong? RowVersion { get; set; }
        public string TimeSinceIndicator { get; set; }

        public bool IsCurrentUser { get; set; }

        [ObservableProperty]
        public int? _userFeedReactionId;
        [ObservableProperty]
        public int _numOfReactions;
        [ObservableProperty]
        public int _numOfComments;

    }
}
