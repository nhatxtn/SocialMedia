namespace DataAccess.Core.Entities.Base
{
    public abstract class AttachedMediaEntity : GuidEntity
    {
        public int UploadOrder { get; set; }

        public string FileName { get; set; }

        public string StorageUrl { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
