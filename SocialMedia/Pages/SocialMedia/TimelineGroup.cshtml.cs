using Microsoft.AspNetCore.Mvc.RazorPages;

public class Group
{
	public string Name { get; set; }
	public string ImageURL { get; set; }
	public int MemberNumber { get; set; }
}

namespace SocialMedia.Pages.SocialMedia
{
	public class TimelineGroup : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		public TimelineGroup(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public float ratedStar { get; set; }
		public List<Group> Groups { get; set; } = new List<Group>();
		public List<Group> SuggestedGroups { get; set; } = new List<Group>();

		public void OnGet()
		{
			ratedStar = 4.7f;
			Groups.AddRange(new List<Group> {
				new() { Name = "Sports Punch", ImageURL = "images/resources/group1.jpg", MemberNumber = 125000000 },
				new() { Name = "Asian Girls", ImageURL = "images/resources/group2.jpg", MemberNumber = 12000000 },
				new() { Name = "Graphic Design", ImageURL = "images/resources/group3.jpg", MemberNumber = 125000000 },
				new() { Name = "Family Lovers", ImageURL = "images/resources/group4.jpg", MemberNumber = 1000000 },
				new() { Name = "School Mates", ImageURL = "images/resources/group5.jpg", MemberNumber = 22000000 },
				new() { Name = "Panama Beach", ImageURL = "images/resources/group6.jpg", MemberNumber = 5000000 },
				new() { Name = "Online Teching", ImageURL = "images/resources/group7.jpg", MemberNumber = 52000000 },
				new() { Name = "Child Cares", ImageURL = "images/resources/group8.jpg", MemberNumber = 1000000 },
				new() { Name = "Fun Art", ImageURL = "images/resources/group9.jpg", MemberNumber = 35000000 },
				new() { Name = "Kids Players", ImageURL = "images/resources/group10.jpg", MemberNumber = 10000000 },
				new() { Name = "Goldi Friends", ImageURL = "images/resources/group11.jpg", MemberNumber = 14000000 }
			});

			SuggestedGroups.AddRange(new List<Group> {
				new() { Name = "Big Biker", ImageURL = "images/resources/group12.jpg", MemberNumber = 15000000 },
				new() { Name = "Blue Tech", ImageURL = "images/resources/group13.jpg", MemberNumber = 12000000 },
				new() { Name = "Gold Movies", ImageURL = "images/resources/group14.jpg", MemberNumber = 125000000 },
				new() { Name = "Musicly Friends", ImageURL = "images/resources/group15.jpg", MemberNumber = 22000000 },
				new() { Name = "AFC Cafe", ImageURL = "images/resources/group16.jpg", MemberNumber = 5000000 },
				new() { Name = "Volunteers", ImageURL = "images/resources/group17.jpg", MemberNumber = 12000000 }
			});
		}
	}
}
