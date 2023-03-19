using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class ImageError : ContentPage
{
    public ContentPageUtil<ImageErrorVm> PageUtil { get; set; }

    public ImageError(ImageErrorVm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<ImageErrorVm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }
}