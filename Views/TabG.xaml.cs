using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class TabG : ContentPage
{
    public ContentPageUtil<TabGvm> PageUtil { get; set; }

    public TabG(TabGvm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<TabGvm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        DisplayAlert("Alert", "Navigated to Tab G", "OK");
    }

    protected override void OnAppearing()
    {
        // Put breakpoint here
        base.OnAppearing();
    }

}