using GymManagementSystem.Entities.Enums;

namespace GymManagementSystem.Entities
{
    public class Session : BaseEntity
    {
        public string Description { get; set; }
        public string Capacity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int TrainerId { get; set; } = default!; // FK
        public Trainer Trainer { get; set; } // Navigation properties
    }
}
