using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.ViewModels
{
    public partial class ImageErrorVm: BaseViewModel
    {
        [ObservableProperty]
        public bool _loading = true;
        [ObservableProperty]
        public ObservableCollection<FeedContentDTO> _feed = new();
        [ObservableProperty]
        public ImageSource _profileImageThumbnail;
        [ObservableProperty]
        public ImageSource _currentMoodImage;
        [ObservableProperty]
        public List<FeedAttachmentDTO> _newFeedImages;

        public Action ShowBottomSheet { get; set; }
        public Action HideBottomSheet { get; set; }
        public DataTemplate BottomSheetSetMood { get; set; }

        [ObservableProperty]
        public string _newFeedContent;


        public ImageErrorVm()
        {
        }

        public async override void Appearing(object sender, EventArgs e)
        {
            try
            {
                Loading = true;
                try
                {
                    base.Appearing(sender, e);
                    ProfileImageThumbnail = ImageSource.FromFile("dotnet_bot.svg");// CurrentUserUtil.GetProfileImageThumbnail();
                    CurrentMoodImage = ImageSource.FromFile("dotnet_bot.svg");// CurrentUserUtil.GetMoodStatusImage();
                    Data data = new Data();
                    var feedList = await data.GetUserFeed();
                    Feed = new ObservableCollection<FeedContentDTO>(feedList.FeedContents);
                }
                finally
                {
                    Loading = false;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }
}
