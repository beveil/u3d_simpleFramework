/*
 * FileName: EventType
 * Author: bx
 * CreateTime: 2019-06-28-12:21:45
 * UnityVersion: 2018.4.2f1
 * Description: 
 * 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EventType
{
    TestEvent = 1,
    HelloWorld = 2
}

public struct EventPackage
{
    public EventType eventType;
    public object[] data;

    public EventPackage(EventType e)
    {
        eventType = e;
        data = null;
    }

    public EventPackage(EventType e, object[] array)
    {
        eventType = e;
        data = array;
    }
}
