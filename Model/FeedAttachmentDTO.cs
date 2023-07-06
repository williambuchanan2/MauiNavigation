namespace MauiApp3
{
    public class FeedAttachmentDto
    {
        public int ID { get; set; }
        public int UserFeedId { get; set; }
        public int UserFeedResponseId { get; set; }
        public byte[] ImageData { get; set; }
        public string FileType { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public bool LocallyDeleted { get; set; }
        public Guid? MobileLocalId { get; set; }
        public string RecordStatusId { get; set; }
    }
}
