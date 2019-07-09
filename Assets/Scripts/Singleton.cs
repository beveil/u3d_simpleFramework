/*
 * FileName: Singleton
 * Author: bx
 * CreateTime: 2019-06-28-12:20:17
 * UnityVersion: 2018.4.2f1
 * Description: 
 * 
*/
using System.Collections;
using System.Collections.Generic;
public class Singleton<T> where T : class, new()
{
    private static T _instance;
    // ¼ÓËø
    private static object _lock = new object();

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new T();
                    }
                }
            }
            return _instance;
        }
    }
}
