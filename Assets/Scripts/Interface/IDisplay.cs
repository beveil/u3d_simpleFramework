/*
 * FileName: IDisplay
 * Author: bx
 * CreateTime: 2019-06-28-11:35:09
 * UnityVersion: 2018.4.2f1
 * Description: 显示对象接口
 * 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDisplay
{
    GameObject DisplayObj { get; set; }

    void Show();

    void Hide();

    void Bind(GameObject display);
}
