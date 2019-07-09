/*
 * FileName: IEventHandler
 * Author: bx
 * CreateTime: 2019-06-28-11:40:50
 * UnityVersion: 2018.4.2f1
 * Description: 
 * 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEventHandler
{
    void AddEvent(EventType eventType, EventHandleDel del);

    void RemoveEvent(EventType eventType, EventHandleDel del);
}
