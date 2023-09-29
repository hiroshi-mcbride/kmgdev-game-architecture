using System.Collections.Generic;
using UnityEngine;

public static class Utility
{
    /// <summary>
    /// Picks a random item from the list and returns it
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="_list"></param>
    /// <returns></returns>
    public static T Pick<T>(List<T> _list)
    {
        int r = Random.Range(0, _list.Count);
        return _list[r];
    }
}
