using PicturesGallery.Halls;
using PicturesGallery.Pictures;

namespace PicturesGallery;

public class Gallery
{
    public List<Picture> PublishedPictures;
    public List<Picture> ReservedPictures;
    public List<Picture> AllPitures;
    public MainHall MainHall;

    public Gallery()
    {
        MainHall = new MainHall();
        AllPitures = new List<Picture>();
        AllPitures.Add(new ClassicPicture("Chel1","Pic1",2022, "Simple", Technologies.Wet));
        AllPitures.Add(new ClassicPicture("Chel2","Pic2",2022, "Simple", Technologies.Wet));
        AllPitures.Add(new ClassicPicture("Chel3","Pic3",2022, "Simple", Technologies.Wet));
        AllPitures.Add(new ModernPicture("Chel1","Pic3",2021, "Simple", Technologies.Dry));
        AllPitures.Add(new ModernPicture("Chel2","Pic3",2022, "Simple", Technologies.Dry));
        AllPitures.Add(new NaturePicture("Chel1","Pic2",2021, "Simple", Technologies.Oil));
        AllPitures.Add(new NaturePicture("Chel2","Pic2",2021, "Simple", Technologies.Oil));
        MainHall.Publish(SearchByName("Chel1"),2022,2);
    }
    public  Picture? SearchByAuthor(string author)
    {
        return PublishedPictures.Find(x => x != null && x.Author.Contains(author));
    }
    public  Picture? SearchByName(string name)
    {
        return PublishedPictures.Find(x => x != null && x.Name.Contains(name));
    }
    public  Picture? SearchByGenre(string genre)
    {
        return PublishedPictures.Find(x => x != null && x.Genre.Contains(genre));
    }
    public  Picture? SearchByYear(int year)
    {
        return PublishedPictures.Find(x => x != null && x.YearOfRelease.Equals(year));
    }
    public  List<Picture?> SearchByPattern(Picture _picture)
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
}