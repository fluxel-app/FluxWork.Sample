using FluxWork.Presentation.Command;
using FluxWork.Presentation.Controller;
using FluxWork.Services;
using SampleLib.Presentation.Dialog;
using SampleLib.Service;

namespace SampleLib.Presentation.First
{
    public class FirstController : NavigationTargetController<FirstViewModel>
    {
        private readonly IWindowService _windowService;
        private readonly DialogController _dialogController;

        public FirstController(IWindowService windowService, DialogController dialogController)
        {
            _windowService = windowService;
            _dialogController = dialogController;
        }

        public override void Initialized()
        {
            this.Title = "Hello!";
            this._windowService.BaseWindow.Height = 200;
            this._windowService.BaseWindow.Width = 300;
        }

        public override void Loaded()
        {
            this.ViewModel.OpenDialog = new DelegateCommand(this.OnOpenDialog);
        }

        private void OnOpenDialog()
        {
            this._windowService.Open(this._dialogController);
        }
    }
}