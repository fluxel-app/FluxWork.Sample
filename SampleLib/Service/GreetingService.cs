using FluxWork.Services;

namespace SampleLib.Service
{
    public class GreetingService : IGreetingService
    {
        public string GetGreeting(string name)
        {
            if (string.IsNullOrEmpty(name))
                return "please type you name";
            return $"Hello {name}";
        }
    }

    public interface IGreetingService : IService
    {
        string GetGreeting(string name);
    }
}