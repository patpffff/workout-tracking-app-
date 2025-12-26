using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workout.Data;
using Workout.ViewModels;

namespace Workout.Views;

public partial class ExercisePage : ContentPage
{
    public ExercisePage(ExerciseViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
        vm.AddExerciseRequested += OnAddExerciseRequested;
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is ExerciseViewModel vm)
        {
            await vm.LoadExercisesAsync();
        }
    }

    private Task OnAddExerciseRequested()
    {
        //throw new NotImplementedException();
    }
}