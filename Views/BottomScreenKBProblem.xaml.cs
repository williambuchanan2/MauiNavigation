using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class BottomScreenKBProblem : ContentPage
{
    public ContentPageUtil<BottomScreenKBProblemVm> PageUtil { get; set; }

    public BottomScreenKBProblem(BottomScreenKBProblemVm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<BottomScreenKBProblemVm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }
}