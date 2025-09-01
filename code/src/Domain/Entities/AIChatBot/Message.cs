namespace OpenProfileAPI.Domain.Entities.AIChatBot;
public class Message : BaseAuditableEntity
{
    public string Content { get; set; } = string.Empty;
    public int RoleId { get; set; } // "user", "assistant", "system"
    public int ConversationId { get; set; }
    public Conversation Conversation { get; set; } = default!;
}
