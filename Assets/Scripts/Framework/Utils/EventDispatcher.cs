/*
 * FileName: EventDispatcher
 * Author: bx
 * CreateTime: 2019-06-28-11:42:09
 * UnityVersion: 2018.4.2f1
 * Description: 
 * 
*/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void EventHandleDel(EventPackage package);
public class EventDispatcher : Singleton<EventDispatcher>, IEventHandler
{
    // 
    Dictionary<EventType, List<EventHandleDel>> m_EventDic = new Dictionary<EventType, List<EventHandleDel>>();

    #region 

    /// <summary>
    /// 添加事件监听
    /// </summary>
    /// <param name="eventType"></param>
    /// <param name="del"></param>
    public void AddEvent(EventType eventType, EventHandleDel del)
    {
        if(!m_EventDic.ContainsKey(eventType))
        {
            m_EventDic.Add(eventType, new List<EventHandleDel>());
        }

        var list = m_EventDic[eventType];
        if (!list.Contains(del))
        {
            list.Add(del);
        }
    }

    /// <summary>
    /// 删除事件监听
    /// </summary>
    /// <param name="eventType"></param>
    /// <param name="del"></param>
    public void RemoveEvent(EventType eventType, EventHandleDel del)
    {
        List<EventHandleDel> list = null;
        if(m_EventDic.TryGetValue(eventType, out list))
        {
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i].Target == del.Target)
                {
                    list.RemoveAt(i);
                }
            }
        }
    }

    public void Clear()
    {
        foreach (List<EventHandleDel> handlerList in m_EventDic.Values)
        {
            if (handlerList == null || handlerList.Count == 0)
                continue;

            handlerList.Clear();
        }
        m_EventDic.Clear();
    }

    /// <summary>
    /// 发送事件
    /// </summary>
    /// <param name="eventType"></param>
    public void SendEvent(EventType eventType)
    {
        var package = new EventPackage(eventType);
        this.SendEvent(package);
    }

    public void SendEvent(EventType eventType, params object[] data)
    {
        var package = new EventPackage(eventType, data);
        this.SendEvent(package);
    }

    #endregion

    #region 
    /// <summary>
    /// 发送事件
    /// </summary>
    /// <param name="package"></param>
    private void SendEvent(EventPackage package)
    {
        List<EventHandleDel> list = null;
        if (m_EventDic.TryGetValue(package.eventType, out list))
        {
            foreach (var item in list)
            {
                item(package);
            }
        }
    }
    #endregion
}
