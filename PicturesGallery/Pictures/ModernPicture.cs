namespace PicturesGallery.Pictures;

public class ModernPicture:Picture
{
    public ModernPicture(string author, string name, int year, string genre, Technologies technology)
    {
        Author = author; 
        Name = name;
        YearOfRelease = year;
        Genre = genre;
        Technology = technology;
        History = new HistoryOfPublishing(0,0);
    }
}