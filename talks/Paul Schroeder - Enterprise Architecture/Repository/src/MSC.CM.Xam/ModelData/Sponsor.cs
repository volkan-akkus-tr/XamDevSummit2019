// <auto-generated> - Template:SqliteModelData, Version:1.1, Id:c5caad15-b3be-4443-87d8-7cabde59f7b0
using SQLite;

namespace MSC.CM.Xam.ModelData.CM
{
	[Table("Sponsor")]
	public partial class Sponsor
	{
		public string BoothLocation { get; set; }
		public string CreatedBy { get; set; }
		public System.DateTime CreatedUtcDate { get; set; }
		public int DataVersion { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
		public bool IsDeleted { get; set; }
		public string ModifiedBy { get; set; }
		public System.DateTime ModifiedUtcDate { get; set; }
		public int Rank { get; set; }
		public string ShortTitle { get; set; }

		[PrimaryKey]
		public int SponsorId { get; set; }

		public int SponsorTypeId { get; set; }
		public string Title { get; set; }
		public string TwitterUrl { get; set; }
		public string WebsiteUrl { get; set; }
	}
}
