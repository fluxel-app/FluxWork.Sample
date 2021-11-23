using System.Windows.Input;
using FluxWork.Presentation.ViewModel;

namespace SampleLib.Presentation.First
{
    public class FirstViewModel : VirtualViewModelBase
    {
        public virtual ICommand OpenDialog { get; set; }
    }
}