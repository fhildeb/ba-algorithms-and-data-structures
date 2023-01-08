using System.Collections;
using Actions.Base;
using Helper;

namespace Actions
{
    public abstract class BasicAction : IAction
    {
        protected ObjectMapper mapper = ObjectMapper.Instance;

        public abstract IEnumerator Run();
    }
}