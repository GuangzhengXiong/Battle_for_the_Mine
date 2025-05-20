using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterController : MonoBehaviour
{
    public Transform target; // 目标位置
    public float speed = 5.0f; // 移动速度
    private Animator animator;
    private Rigidbody rb;
    private Vector3 moveDirection;
    private bool isMoving = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        moveDirection = (target.position - transform.position).normalized; // 计算方向向量
        if (moveDirection != Vector3.zero) // 如果目标不是当前位置，则开始移动并播放动画
        {
            isMoving = true;
            rb.MovePosition(transform.position + moveDirection * speed * Time.deltaTime); // 移动角色
            animator.SetBool("Move", true); // 播放走路动画

        }
        else if (isMoving) // 如果到达目标位置，停止移动并播放停止动画（如果有的话）
        {
            isMoving = false;
            animator.SetBool("Move", false); // 停止走路动画，如果需要的话也可以播放停止动画（如果有的话）
        }
    }

}
