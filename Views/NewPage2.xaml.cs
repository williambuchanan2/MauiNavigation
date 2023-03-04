using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class NewPage2 : ContentPage
{
    public ContentPageUtil<Class2> PageUtil { get; set; }

    public NewPage2(Class2 vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Class2>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}