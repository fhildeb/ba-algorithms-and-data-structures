using System.Collections;

namespace Actions.Base
{
    public interface IAction
    {
        IEnumerator Run();
    }
}