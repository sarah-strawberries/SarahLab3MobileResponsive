using System;

public class GalleryItem
{
    #region Properties
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public string ImageUrl { get; set; }
    #endregion

    public GalleryItem(string name, decimal price, string imageUrl, string description = null) 
    {     
        Name = name;
        Price = price;
        ImageUrl = imageUrl;
        Description = description;
    }

 }
