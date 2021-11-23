using FluxWork.Presentation.Controller;
using SampleLib.Service;

namespace SampleLib.Presentation.Dialog
{
    public class DialogController : DialogController<DialogViewModel>
    {
        private readonly IGreetingService _greetingService;

        public DialogController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        public override void Initialized()
        {
            this.Dimensions.SetHeights(200);
            this.Dimensions.SetWidths(300);
            this.Title = "Dialog 1";
        }

        public override void Loaded()
        {
            this.ViewModel.PropertyChanged += (sender, args) =>
            {
                if(args.PropertyName == nameof(DialogViewModel.Name))
                    this.OnNameChanged();
            };
            this.OnNameChanged();
        }

        private void OnNameChanged()
        {
            this.ViewModel.Greeting = this._greetingService.GetGreeting(this.ViewModel.Name);
        }
    }
}