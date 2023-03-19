namespace MauiApp3
{
    public class UserProfileDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string Bio { get; set; }
        public byte[] ProfileImageThumbnail { get; set; }
    }
}
