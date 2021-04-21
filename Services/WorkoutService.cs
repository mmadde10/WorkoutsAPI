using WorkoutsAPI.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace WorkoutsAPI.Services
{
    public class WorkoutService
    {
        private readonly IMongoCollection<Workout> _workouts;

        public WorkoutService(IWorkoutTrackerDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _workouts = database.GetCollection<Workout>(settings.WorkoutsCollectionName);
        }

        public List<Workout> Get() =>
            _workouts.Find(Workout => true).ToList();

        public Workout Get(string id) =>
            _workouts.Find<Workout>(Workout => Workout.Id == id).FirstOrDefault();

        public Workout Create(Workout workout)
        {
            _workouts.InsertOne(workout);
            return workout;
        }

        public void Update(string id, Workout workoutIn) =>
            _workouts.ReplaceOne(Workout => Workout.Id == id, workoutIn);

        public void Remove(Workout workoutIn) =>
            _workouts.DeleteOne(Workout => Workout.Id == workoutIn.Id);

        public void Remove(string id) => 
            _workouts.DeleteOne(Workout => Workout.Id == id);
    }
}
