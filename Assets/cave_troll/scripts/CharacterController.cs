using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterController : MonoBehaviour
{
    public Transform target; // Ŀ��λ��
    public float speed = 5.0f; // �ƶ��ٶ�
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
        
        moveDirection = (target.position - transform.position).normalized; // ���㷽������
        if (moveDirection != Vector3.zero) // ���Ŀ�겻�ǵ�ǰλ�ã���ʼ�ƶ������Ŷ���
        {
            isMoving = true;
            rb.MovePosition(transform.position + moveDirection * speed * Time.deltaTime); // �ƶ���ɫ
            animator.SetBool("Move", true); // ������·����

        }
        else if (isMoving) // �������Ŀ��λ�ã�ֹͣ�ƶ�������ֹͣ����������еĻ���
        {
            isMoving = false;
            animator.SetBool("Move", false); // ֹͣ��·�����������Ҫ�Ļ�Ҳ���Բ���ֹͣ����������еĻ���
        }
    }

}
