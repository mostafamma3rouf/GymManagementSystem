namespace GymManagementSystem.Entities.Enums
{
    public class Trainer : GymUser
    {
        public Specialities Speciality { get; set; }

        public ICollection<Session> Sessions { get; set; } = default!;
    }
}