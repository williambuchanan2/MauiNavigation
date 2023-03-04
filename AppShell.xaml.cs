namespace MauiApp3;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

    public static void SwitchToMainShellItem()
    {
        NavigationUtil.NavigateShell(nameof(MainShellItem));
    }

    public static void SwitchToLoginShellItem()
    {
        NavigationUtil.NavigateShell(nameof(TabHShellItem));
    }

    public static void SwitchToResetShellItem()
    {
        NavigationUtil.NavigateShell(nameof(ResetShellItem));
    }

}
