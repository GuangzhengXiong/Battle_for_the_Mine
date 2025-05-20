using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vs : MonoBehaviour
{
    public float moveAmountX = 0.1f;


    void Update()
    {
        // 获取当前GameObject的Transform组件
        Transform transform = GetComponent<Transform>();

        // 沿X轴移动GameObject
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + moveAmountX);
      
    }
}
