using SQLite;

namespace Workout.Models;

public class WorkoutPlanExercise
{
    [PrimaryKey, AutoIncrement]
    public int WorkoutPlanExerciseId { get; set; }
    private int WorkoutPlanID;
    private int ExerciseID;
    private int OrderIndex;
}