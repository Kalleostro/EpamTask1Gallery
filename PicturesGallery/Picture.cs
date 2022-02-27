namespace PicturesGallery;

public abstract class Picture
{
    public Technologies Technology;
    public string Author { get; set; }
    public string Name { get; set; }
    public int YearOfRelease { get; set; }
    public string Genre { get; set; }
    public HistoryOfPublishing History { get; set; }
}