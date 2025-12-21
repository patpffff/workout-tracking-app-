using SQLite;

namespace Workout.Models;

public class WorkoutPlanExercise
{
    [PrimaryKey, AutoIncrement]
    public int WorkoutPlanExerciseId { get; set; }
    public int WorkoutPlanID { get; set; }  // ← Property statt Field
    public int ExerciseID { get; set; }     // ← Property statt Field
    public int OrderIndex { get; set; }     // ← Property statt Field
}