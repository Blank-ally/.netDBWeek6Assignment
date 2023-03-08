internal class MediaList
{
    List<Media> media = new List<Media>();
    List<string> list = new List<string>();
    FileService file = new FileService();

    public void AddMedia(string view)
    {    list.Add(view);

    }

    public MediaList(List<Media> media, List<string> list, FileService file)
    {
        this.media = media;
        this.list = list;
        this.file = file;
    }
}

