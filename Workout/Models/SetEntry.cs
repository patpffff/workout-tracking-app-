using SQLite;
namespace Workout.Models;

public class SetEntry
{
    [PrimaryKey, AutoIncrement]
    public int SetEntryId { get; set; }
    
    private int WorkoutPlanExerciseID;
    private int setNumber;
    private float weight;
    private int repetitions;
    private DateTime performedAt;
    
}