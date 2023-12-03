using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class KeyboardButtonEvent : ContentPage
{
    public ContentPageUtil<KeyboardButtonEventVm> PageUtil { get; set; }

    public KeyboardButtonEvent(KeyboardButtonEventVm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<KeyboardButtonEventVm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}