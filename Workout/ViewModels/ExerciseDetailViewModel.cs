using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Workout.Data;
using Workout.Models;

namespace Workout.ViewModels;
[QueryProperty(nameof(Exercise), "Exercise")]

public partial class ExerciseDetailViewModel: ObservableObject
{
    WorkoutDatabase _database;
    
    [ObservableProperty]
    Exercise exercise;

    [ObservableProperty] 
    private ObservableCollection<SetEntry> _setEntries;

    public ExerciseDetailViewModel(WorkoutDatabase database)
    {
        _database = database;
        SetEntries = new ObservableCollection<SetEntry>();
    }
    [RelayCommand]
    public async Task LoadSetEntriesAsync()
    {
        SetEntries.Clear();
        SetEntries.Add(new SetEntry
        {
            ExerciseId = Exercise.ExerciseID,
            setNumber = SetEntries.Count+1,
            repetitions = 0,
            weight = 0,
            performedAt =  DateTime.Now,
        });
    }
    [RelayCommand]
    public void AddSet()
    {
        SetEntries.Add(new SetEntry
        {
            ExerciseId = Exercise.ExerciseID,
            setNumber = SetEntries.Count+1,
            repetitions = 0,
            weight = 0,
            performedAt =  DateTime.Now,
        });
    }

    [RelayCommand]
    public void RemoveSet()
    {
        if (SetEntries.Any())
        {
            SetEntries.Remove(SetEntries.Last());
        }
    }

}