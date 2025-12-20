using SQLite;

namespace Workout.Models;

public class WorkoutPlan
{
    [PrimaryKey, AutoIncrement]
    public int WorkoutID { get; set; }
    public string Name { get; set; } = string.Empty;
}