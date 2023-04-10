using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class ImageError2 : ContentPage
{
    public ContentPageUtil<ImageError2Vm> PageUtil { get; set; }

    public ImageError2(ImageError2Vm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<ImageError2Vm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }
}