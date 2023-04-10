using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class ImageError3 : ContentPage
{
    public ContentPageUtil<ImageError3Vm> PageUtil { get; set; }

    public ImageError3(ImageError3Vm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<ImageError3Vm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }
}