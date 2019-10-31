using System;
using System.Collections.Generic;

namespace xf.simp2019.rssnews.Services
{
    public class GenericEventArgs<T> : EventArgs
    {
        public IList<T> Results { get; private set; }
        public GenericEventArgs(IList<T> results)
        {
            Results = results;
        }
    }
}