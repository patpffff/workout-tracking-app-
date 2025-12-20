using SQLite;

namespace Workout.Models;

public class WorkoutPlanExercise
{
    [PrimaryKey, AutoIncrement]
    public int WorkoutPlanExerciseId { get; set; }
    public int WorkoutPlanID;
    public int ExerciseID;
    public int OrderIndex;
}