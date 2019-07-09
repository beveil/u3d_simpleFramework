using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AutoSingleton(true)]
public class UIManager : MonoSingleton<UIManager>
{

    public void HelloWorld()
    {
        Debug.Log("UIManager hello world");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
