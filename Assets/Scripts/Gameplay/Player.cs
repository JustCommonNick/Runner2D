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

    public GameObject soundmanager;

    public GameObject OpenMenu;
    public bool bef_start = false;
    public bool down = false;

    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        Invoke("BeforeStart", 0.1f);
        bool inAir = false;
    }

    void Update()
    {

        originalHeight = transform.localScale.y;
        originalYPosition = transform.position.y;

        if (Input.GetKey(KeyCode.W) && !inAir && bef_start && !OpenMenu.GetComponent<OpenMenu>().open_menu)
        {
            inAir = true;
            m_Rigidbody.AddForce(force);
        }

        if (this.GetComponent<Loss>().loss == false && OpenMenu.GetComponent<OpenMenu>().open_menu == false && bef_start && !OpenMenu.GetComponent<OpenMenu>().open_menu)
        {
            if (Input.GetKeyDown(KeyCode.S) && !down)
            {

                down = true;
                Down();
            }
            else if (Input.GetKeyUp(KeyCode.S) && down)
            {
                down = false;
                Up();
            }
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            if (inAir)
            {
                soundmanager.GetComponent<Sounds>().TouchGround();
            }
            inAir = false;

        }

    }

    public void BeforeStart()
    {
        bef_start = true;
    }

    public void UpButton()
    {
        if (!inAir && bef_start && !OpenMenu.GetComponent<OpenMenu>().open_menu)
        {
            inAir = true;
            m_Rigidbody.AddForce(force);
        }
    }

    public void DownButton()
    {
        if (this.GetComponent<Loss>().loss == false && OpenMenu.GetComponent<OpenMenu>().open_menu == false && bef_start && !OpenMenu.GetComponent<OpenMenu>().open_menu)
        {
            if (!down)
            {

                down = true;
                Down();
            }
            else if (down)
            {
                down = false;
                Up();
            }
        }
    }

    public void Up()
    {
        transform.localScale = new Vector3(transform.localScale.x, originalHeight * 2, transform.localScale.z);
        transform.position = new Vector3(transform.position.x, originalYPosition + originalHeight, transform.position.z);
    }

    public void Down()
    {
        transform.localScale = new Vector3(transform.localScale.x, originalHeight / 2, transform.localScale.z);
        transform.position = new Vector3(transform.position.x, originalYPosition - originalHeight / 2, transform.position.z);
    }
}