using System.Collections.Generic;
using System;

namespace Sowtank
{
    public static class GameUtils
    {
        public static void ApplyAll<T>(List<T> list, Action<T> action)
        {
            if (list == null) return;
            for (int i = 0; i < list.Count; i++)
            {
                action(list[i]);
            }
        }
    }
}