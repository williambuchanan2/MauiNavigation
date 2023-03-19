namespace MauiApp3
{
    public class FeedAttachmentDTO
    {
        public int ID { get; set; }
        public int UserFeedId { get; set; }
        public byte[] ImageData { get; set; }
        public string FileType { get; set; }
    }
}
