using SQLite;
namespace Workout.Models;

public class SetEntry
{
    [PrimaryKey, AutoIncrement]
    public int SetEntryId { get; set; }
    
    public int WorkoutPlanExerciseID;
    public int setNumber;
    public float weight;
    public int repetitions;
    public DateTime performedAt;
    
}