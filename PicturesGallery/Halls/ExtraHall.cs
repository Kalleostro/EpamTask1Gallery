using Microsoft.VisualBasic;

namespace PicturesGallery.Halls;

public class ExtraHall:Hall
{
    public List<Picture?> PublishedPictures;

    public override List<Picture?> ShowAllPublished()
    {
        return PublishedPictures;
    }

    public override Picture? SearchByAuthor(string author)
    {
        return PublishedPictures.Find(x => x != null && x.Author.Contains(author));
    }
    public override Picture? SearchByName(string name)
    {
        return PublishedPictures.Find(x => x != null && x.Name.Contains(name));
    }
    public override Picture? SearchByGenre(string genre)
    {
        return PublishedPictures.Find(x => x != null && x.Genre.Contains(genre));
    }
    public override Picture? SearchByYear(int year)
    {
        return PublishedPictures.Find(x => x != null && x.YearOfRelease.Equals(year));
    }

    public override List<Picture?> SearchByPattern(Picture _picture)
    {
        var foundPictures = new List<Picture?>();
        foreach (var picture in PublishedPictures)
        {
            if (picture != null && (picture.Author.Contains(_picture.Author) || picture.Genre.Contains(_picture.Genre) || 
                                    picture.Name.Contains(_picture.Name) || picture.YearOfRelease.Equals(_picture.YearOfRelease)))
                foundPictures.Add(picture);
        }
        return foundPictures;
    }
    public override void Publish(Picture picture, int year, int duration)
    {
        var historyOfPublishing = picture.History;
        historyOfPublishing.Year = year;
        historyOfPublishing.Duration = duration;
        picture.History = historyOfPublishing;
        PublishedPictures.Add(picture);
    }
}