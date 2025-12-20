using SQLite;
using Workout.Models;

namespace Workout.Data;

public class WorkoutDatabase
{
    SQLiteAsyncConnection database;
    
    async Task Init()
    {
        if (database is not null)
            return;

        database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        await database.CreateTableAsync<WorkoutPlan>();
        await database.CreateTableAsync<WorkoutPlanExercise>();
        await database.CreateTableAsync<Exercise>();
        await database.CreateTableAsync<SetEntry>();
    }

    public async Task<List<WorkoutPlan>> GetWorkoutPlanAsync()
    {
        await Init();
        return await database.Table<WorkoutPlan>().ToListAsync();
    }
    
    public async Task<List<Exercise>> GetExerciseAsync()
    {
        await Init();
        return await database.Table<Exercise>().ToListAsync();
    }
    
    public async Task<List<WorkoutPlanExercise>> GetWorkoutPlanExercise(int WorkoutID)
    {
        await Init();
        return await database.QueryAsync<WorkoutPlanExercise>(
            "SELECT * FROM WorkoutPlanExercise WHERE WorkoutPlanID = ?",
            WorkoutID);
    }

}