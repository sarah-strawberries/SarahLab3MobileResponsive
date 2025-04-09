using MobileResponsiveApp.ViewModels;

namespace MobileResponsiveApp.Views;

public partial class GalleryView : ContentPage
{
	public GalleryView()
	{
		InitializeComponent();
		BindingContext = new GalleryViewModel();
	}
}