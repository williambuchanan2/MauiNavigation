using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp3.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MauiApp3.ViewModels
{
    public class FeedAttachmentDTO
    {
        public int ID { get; set; }
        public int UserFeedId { get; set; }
        public ImageSource ImageData { get; set; }
        public string FileType { get; set; }
    }


    public partial class Class7 : BaseViewModel
    {
        [ObservableProperty]
        public ObservableCollection<FeedAttachmentDTO> _newFeedImages;

        [RelayCommand]
        private void NextButtonPressed()
        {
            NavigationUtil.Navigate<NewPage8>();
        }

        public override void NavigatedTo(object sender, NavigatedToEventArgs e)
        {
            base.NavigatedTo(sender, e);

            ImageSource img = ImageSource.FromFile("dotnet_bot.svg");
            FeedAttachmentDTO newFeedImage = new FeedAttachmentDTO() { ImageData = img };
            _newFeedImages.Add(newFeedImage);

        }

        [RelayCommand]
        private async void SelectPhotoPressed()
        {
            try
            {
                ImageSource img = ImageSource.FromFile("dotnet_bot.svg");
                if (NewFeedImages == null)
                NewFeedImages = new ObservableCollection<FeedAttachmentDTO>();

                //foreach (CameraResult camResult in imagesData)
                {
                    FeedAttachmentDTO newFeedImage = new FeedAttachmentDTO() { ImageData = img };
                    NewFeedImages.Add(newFeedImage);
                }
            }
            catch (Exception ex)
            {
                // AppExceptionHandler.HandleException(ex);
            }
        }


    }
}
