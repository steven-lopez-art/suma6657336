using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SumA6657336.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        public string entry1;
        [ObservableProperty]
        public string entry2;
        [ObservableProperty]
        public string entry3;


        [RelayCommand]
        public void calcular()
        {
            if (double.TryParse(Entry1, out double number1) && double.TryParse(Entry2, out double number2))
            {
                double result = number1 + number2;
                Entry3 = result.ToString();
            }
            else
            {
                Entry3 = "Entrada inválida";
            }
        }
    }
}