using LearningDITypes.Abstractions;
using Unity.Attributes;

namespace LearningDITypes.Services
{
    public class DIPropertyInjection: IDIPropertyInjection
    {
        [Dependency]
        public IDIPropertyInjection InjectedProperty { get;  set; } = new DIPropertyRepository();

        public IDIPropertyInjection GetObjectType()
        {
            return InjectedProperty;
        }
    }
}
