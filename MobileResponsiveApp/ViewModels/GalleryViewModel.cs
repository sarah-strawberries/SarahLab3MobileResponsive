using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MobileResponsiveApp.ViewModels;

public class GalleryViewModel : ObservableObject
{
    public ObservableCollection<GalleryItem> Items { get; set; }
    public GalleryViewModel()
    {
        Items = new ObservableCollection<GalleryItem>(new List<GalleryItem>() 
        {
            new GalleryItem("Yellow Rose", 3.99M, "rose", "Location: Ashton Gardens"),
            new GalleryItem("Sunflower", 3.99M, "sunflower", "Location: Santaquin, UT"),
            new GalleryItem("Lilac Bush and Moth", 4.99M, "lilac_bush", "Location: Ephraim, UT")
        });
    }
}
