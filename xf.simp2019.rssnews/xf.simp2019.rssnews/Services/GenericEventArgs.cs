using System;

namespace xf.simp2019.rssnews.Services
{
    public class GenericEventArgs<T> : EventArgs
    {
        public T Results { get; private set; }
        public GenericEventArgs(T results)
        {
            Results = results;
        }
    }
}