using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class TabF : ContentPage
{
    public ContentPageUtil<TabFvm> PageUtil { get; set; }

    public TabF(TabFvm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<TabFvm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
         DisplayAlert("Alert", "Navigated to Tab F", "OK");
    }

    protected override void OnAppearing()
    {
        // Put breakpoint here
        base.OnAppearing();
    }

}