using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp3.Views;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp3.ViewModels
{
    public class FeedAttachmentDTO
    {
        public int ID { get; set; }
        public int UserFeedId { get; set; }
        public ImageSource ImageData { get; set; }
        public string FileType { get; set; }
    }
    
    
    public partial class Class7: BaseViewModel
    {
        [ObservableProperty]
        public List<FeedAttachmentDTO> _newFeedImages;

        [RelayCommand]
        private void NextButtonPressed()
        {
            NavigationUtil.Navigate<NewPage8>();
        }

        [RelayCommand]
        private async void SelectPhotoPressed()
        {
            try
            {
                ImageSource img = ImageSource.FromFile("dotnet_bot.svg");
                if (NewFeedImages == null)
                    NewFeedImages = new List<FeedAttachmentDTO>();

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
