using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AutoSingleton(true)]
public class GameMain : MonoSingleton<GameMain>
{
    protected override void Awake()
    {
        base.Awake();
        UIManager.Instance.HelloWorld();
    }

    void Start()
    {
    }

    void Update()
    {
        Debug.Log(Time.renderedFrameCount + "  " + Time.frameCount);
    }
}
