using Actions.Base;
using Helper;

namespace Model.Base
{
    public abstract class DefaultAlgorithm<T> : IAlgorithm<T> where T : IDataContainer
    {
        //Abstract Methods
        public abstract T generate();

        public abstract void applyAlgorithm(T g);
        
        public abstract void visualize(T container, Prefabs pf);
        
        // General method mapping
        void IAlgorithm.applyAlgorithm(IDataContainer obj)
        {
            applyAlgorithm((T) obj);
        }

        IDataContainer IAlgorithm.generate()
        {
            return generate();
        }

        void IAlgorithm.visualize(IDataContainer container, Prefabs pf)
        {
            visualize((T) container, pf);
        }

        // Visual Feedback
        protected void visualFeedback(IAction action)
        {
            AnimationQueue.Instance.enqueueAction(action);
        }
        
        // Resolution from data object to physical object
        protected ObjectMapper objectMapper = ObjectMapper.Instance;
    }
}