using System;

namespace WindowSpot.Core
{
    public static class CoreExtensions
    {
         public static void Raise(this Action action)
         {
             if (action != null)
                 action();
         }

        public static void Raise<T>(this Action<T> action, T arg)
        {
            if (action != null)
                action(arg);
        }
    }
}