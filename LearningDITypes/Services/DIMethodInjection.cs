using LearningDITypes.Abstractions;

namespace LearningDITypes.Services
{
    public class DIMethodInjection : IDIMethodInjection
    {
        public string GetData()
        {
            return "DI Method text";
        }
    }
}
