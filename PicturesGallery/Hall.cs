namespace PicturesGallery;

public abstract class Hall
{
    public abstract List<Picture?> ShowAllPublished();
    public abstract Picture? SearchByAuthor(string author);
    public abstract Picture? SearchByName(string name);
    public abstract Picture? SearchByYear(int yearOfRelease);
    public abstract Picture? SearchByGenre(string genre);
    public abstract List<Picture?> SearchByPattern(Picture picture);
    public abstract void Publish(Picture picture, int year, int duration);

}