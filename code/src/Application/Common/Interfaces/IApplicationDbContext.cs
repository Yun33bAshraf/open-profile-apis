using OpenProfileAPI.Domain.Entities;
using OpenProfileAPI.Domain.Entities.AIChatBot;
using AuthPolicyModel = OpenProfileAPI.Domain.Entities.AuthPolicy;

namespace OpenProfileAPI.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<User> Users { get; }
    DbSet<UserProfile> UserProfile { get; }
    DbSet<Role> Role { get; }
    DbSet<Right> Right { get; }
    DbSet<RoleRight> RoleRight { get; }
    DbSet<UserRole> UserRole { get; }
    DbSet<UserRight> UserRight { get; }
    DbSet<LoginAttempts> LoginAttempts { get; }
    DbSet<AuthPolicyModel> AuthPolicies { get; }
    DbSet<Category> Category { get; }
    DbSet<EntityType> EntityType { get; }
    DbSet<UserFile> UserFile { get; }
    DbSet<FileStore> FileStore { get; }
    DbSet<Conversation> Conversation { get; }
    DbSet<Message> Message { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
