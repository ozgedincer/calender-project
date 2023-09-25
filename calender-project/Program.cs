using calender_project.Entities;
using calender_project.Commons;


Meeting meeting = new()
{
    Title = "YetGen Jump Meeting",
    Details = "Details",
    StartTime = DateTime.Now,
    EndTime = DateTime.Now,
    Guests = new() { "guest1", "guest2" },
};

Todo Todo = new()
{
    Title = "Title",
    Details = "Details",
    StartTime = DateTime.Now,
    EndTime = DateTime.Now,
    Importance = "HIGH"
};