using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WorkoutsAPI.Models{
    
    public class Exercise{
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Muscle { get; set; }
        public string Equipment { get; set; }
        public int RecommenededSets { get; set; }
        public int RecommenededReps { get; set; }
        public int ActualReps { get; set; }
        public int ActualSets { get; set; }

        public int Weight { get; set; }

    }
}