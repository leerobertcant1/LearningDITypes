using LearningDITypes.Abstractions;

namespace LearningDITypes.Services
{
    public class DIConstructorInjection : IDIConstructorInjection
    {
        public string GetData()
        {
            return "DI Constructor text";
        }
    }
}
