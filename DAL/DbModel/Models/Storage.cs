namespace DbModel.Models
{
	public class Storage
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<StorageItem>? Items { get; set; }
    }
}
