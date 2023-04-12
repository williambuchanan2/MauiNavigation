using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class BorderProblemPage : ContentPage
{
    public ContentPageUtil<BorderProblemVm> PageUtil { get; set; }

    public BorderProblemPage(BorderProblemVm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<BorderProblemVm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }
}