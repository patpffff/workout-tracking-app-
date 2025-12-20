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
}