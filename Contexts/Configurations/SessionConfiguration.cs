using GymManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymManagementSystem.Contexts.Configurations
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Session> builder)
        {
            builder.Property(S => S.CreatedAt)
                   .HasDefaultValueSql("GETDATE()");

            builder.HasOne(S => S.Trainer)
                   .WithMany(T => T.Sessions)
                   .HasForeignKey(S => S.TrainerId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable(T =>
            {
                T.HasCheckConstraint("Session_Capacity_Check", "Capacity Between 1 And 25");
                T.HasCheckConstraint("Session_EndDate_After_StartDate", "EndDate > StartDate");
            });
        }
    }
}
