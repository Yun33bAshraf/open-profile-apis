namespace OpenProfileAPI.Domain.Entities.AIChatBot;
public class Conversation : BaseAuditableEntity
{
    public string Title { get; set; } = "New Conversation";
    public int UserId { get; set; }
    public User User { get; set; } = default!;
    public string SlugId { get; set; } = string.Empty;

    public ICollection<Message> Messages { get; set; } = default!;
}
