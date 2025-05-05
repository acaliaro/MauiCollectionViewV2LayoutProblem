
namespace MauiApp4;

public partial class WallboxView : ContentView
{

    public static readonly BindableProperty IsFavoriteProperty = BindableProperty.Create(nameof(IsFavorite), typeof(bool), typeof(WallboxView));
    public static readonly BindableProperty NameProperty = BindableProperty.Create(nameof(Name), typeof(string), typeof(WallboxView), default(string));
    public static readonly BindableProperty HasPendingUpdateProperty = BindableProperty.Create(nameof(HasPendingUpdate), typeof(bool), typeof(WallboxView));
    public static readonly BindableProperty IsWallboxActiveProperty = BindableProperty.Create(nameof(IsWallboxActive), typeof(bool), typeof(WallboxView));
    public static readonly BindableProperty ImageProperty = BindableProperty.Create(nameof(Image), typeof(string), typeof(WallboxView));
    public static readonly BindableProperty IsMasterSlaveProperty = BindableProperty.Create(nameof(IsMasterSlave), typeof(bool), typeof(WallboxView));
    public static readonly BindableProperty IsActiveProperty = BindableProperty.Create(nameof(IsActive), typeof(bool), typeof(WallboxView));
    public static readonly BindableProperty HasStatusInfoSecondaryProperty = BindableProperty.Create(nameof(HasStatusInfoSecondary), typeof(bool), typeof(WallboxView));
    public static readonly BindableProperty HasStatusInfoPrimaryProperty = BindableProperty.Create(nameof(HasStatusInfoPrimary), typeof(bool), typeof(WallboxView));

    public bool IsFavorite
    {
        get => (bool)GetValue(IsFavoriteProperty);
        set => SetValue(IsFavoriteProperty, value);
    }

    public string Name
    {
        get => (string)GetValue(NameProperty);
        set => SetValue(NameProperty, value);
    }

    public bool HasPendingUpdate
    {
        get => (bool)GetValue(HasPendingUpdateProperty);
        set => SetValue(HasPendingUpdateProperty, value);
    }

    public bool HasStatusInfoSecondary
    {
        get => (bool)GetValue(HasStatusInfoSecondaryProperty);
        set => SetValue(HasStatusInfoSecondaryProperty, value);
    }

    public bool HasStatusInfoPrimary
    {
        get => (bool)GetValue(HasStatusInfoPrimaryProperty);
        set => SetValue(HasStatusInfoPrimaryProperty, value);
    }

    public bool IsWallboxActive
    {
        get => (bool)GetValue(IsWallboxActiveProperty);
        set => SetValue(IsWallboxActiveProperty, value);
    }

    public string Image
    {
        get => (string)GetValue(ImageProperty);
        set => SetValue(ImageProperty, value);
    }

    public bool IsMasterSlave
    {
        get => (bool)GetValue(IsMasterSlaveProperty);
        set => SetValue(IsMasterSlaveProperty, value);
    }

    public bool IsActive
    {
        get => (bool)GetValue(IsActiveProperty);
        set => SetValue(IsActiveProperty, value);
    }

    public WallboxView()
	{
		InitializeComponent();
	}
}