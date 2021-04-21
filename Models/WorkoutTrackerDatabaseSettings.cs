namespace WorkoutsAPI.Models
{
    public class WorkoutTrackerDatabaseSettings : IWorkoutTrackerDatabaseSettings
    {
        public string WorkoutsCollectionName { get; set; }
        public string ExercisesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IWorkoutTrackerDatabaseSettings
    {
        string WorkoutsCollectionName { get; set; }
        string ExercisesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}