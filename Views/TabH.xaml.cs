using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class TabH : ContentPage
{
    public ContentPageUtil<TabHvm> PageUtil { get; set; }

    public TabH(TabHvm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<TabHvm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        DisplayAlert("Alert", "Navigated to Tab H", "OK");
    }

    protected override void OnAppearing()
    {
        // Put breakpoint here
        base.OnAppearing();
    }

}