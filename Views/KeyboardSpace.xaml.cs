using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class KeyboardSpace : ContentPage
{
    public ContentPageUtil<KeyboardSpaceVm> PageUtil { get; set; }

    public KeyboardSpace(KeyboardSpaceVm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<KeyboardSpaceVm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}