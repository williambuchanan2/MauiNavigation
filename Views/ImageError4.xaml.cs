using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class ImageError4 : ContentPage
{
    public ContentPageUtil<ImageError4Vm> PageUtil { get; set; }

    public ImageError4(ImageError4Vm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<ImageError4Vm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }
}