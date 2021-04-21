using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace WorkoutsAPI.Models{
    public class Workout{
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }

        public BsonDateTime StartTime {get; set;}
        public BsonDateTime EndTime {get; set;}

        public string TargetedMuscles {get; set;}
        public string RequiredEquipment {get; set;}

        public ICollection<Workout> RequiredWorkoutsList {get; set;}
        public ICollection<Workout> ActualWorkoutsList {get; set;}
    }
}