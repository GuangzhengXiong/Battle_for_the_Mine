using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vs : MonoBehaviour
{
    public float moveAmountX = 0.1f;


    void Update()
    {
        // ��ȡ��ǰGameObject��Transform���
        Transform transform = GetComponent<Transform>();

        // ��X���ƶ�GameObject
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + moveAmountX);
      
    }
}
