using System;
using FluxWork.Controller;
using FluxWork.Services;
using SampleLib.Presentation.First;

namespace FluxWork.Sample
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var boot = Bootstrap.Singleton; // Erzeugt eine Instanz des HitWorks
            //boot.DependencyService.SetAssemblyNameFilter(@"SampleLib\.dll$"); // Grenzt die Suche nach Services ein, RegEx
            boot.Boot("Meine App"); // Titel des Hauptfensters

            var ds = boot.DependencyService; // Holt den DependencyService
            var windowService = ds.Find<IWindowService>(); // Holt den WindowService
            windowService.Navigate(ds.Find<FirstController>()); // Setzt die 'ErstePresentation' als Einstieg

            boot.Run(); // Registriert Dienste und zeigt das Hauptfenster an
        }
    }
}