using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp3.Views;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp3.ViewModels
{
    public partial class BottomScreenKBProblemVm : BaseViewModel
    {
        [ObservableProperty]
        public bool _loading = true;
        [ObservableProperty]
        public ObservableCollection<FeedContentDto> _feed = new();
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


        public BottomScreenKBProblemVm()
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
                    //var feedList =  await data.GetUserFeed();
                    Feed = GetData();//new ObservableCollection<FeedContentDto>(feedList.FeedContents);
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

        private ObservableCollection<FeedContentDto> GetData()
        {
            ObservableCollection<FeedContentDto> result = new();

            for (int i=1; i<10;i++)
            {
                FeedContentDto dto = new();
                dto.FeedContent = "Blah";
                result.Add(dto);
            }

            return result;
        }


    }

}

