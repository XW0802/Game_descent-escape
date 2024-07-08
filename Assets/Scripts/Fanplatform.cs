using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fanplatform : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // 在 Update 方法中添加逻辑（如果需要）
    }

    // 碰撞检测方法
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animator.Play("Fan_run");
        }
    }
}
