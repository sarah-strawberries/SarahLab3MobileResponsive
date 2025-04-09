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
            new GalleryItem("Yellow Rose", 3.99M, "https://images.pexels.com/photos/22302611/pexels-photo-22302611/free-photo-of-pink-and-yellow-rose.jpeg", "Location: Ashton Gardens"),
            new GalleryItem("Sunflower", 3.99M, "https://images.pexels.com/photos/21430709/pexels-photo-21430709/free-photo-of-sunflower-and-white-fence.jpeg", "Location: Santaquin, UT"),
            new GalleryItem("Lilac Bush and Moth", 4.99M, "https://images.pexels.com/photos/21575387/pexels-photo-21575387/free-photo-of-orange-moth-on-purple-flowers.jpeg", "Location: Ephraim, UT")
        });
    }
}