using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    readonly Vector2 force = new Vector2(0, 300);
    bool inAir;

    private float originalHeight;
    private float originalYPosition;
    

    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        originalHeight = transform.localScale.y;
        originalYPosition = transform.position.y;

        if (Input.GetKey(KeyCode.W) && !inAir)
        {
            inAir = true;
            m_Rigidbody.AddForce(force);
        }


        if (Input.GetKeyDown(KeyCode.S))
        {
            // Сжимаем капсулу и смещаем ее ниже
            transform.localScale = new Vector3(transform.localScale.x, originalHeight / 2, transform.localScale.z);
            transform.position = new Vector3(transform.position.x, originalYPosition - originalHeight / 2, transform.position.z);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            // Возвращаем капсулу в начальное состояние
            transform.localScale = new Vector3(transform.localScale.x, originalHeight * 2, transform.localScale.z);
            transform.position = new Vector3(transform.position.x, originalYPosition + originalHeight, transform.position.z);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
            inAir = false;
    }
}