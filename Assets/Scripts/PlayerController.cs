using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        Vector2 moveVec = Vector2.zero;

        moveVec.x = Input.GetAxis("Horizontal");
        moveVec.y = Input.GetAxis("Vertical");

        // ‚±‚±‚É–½—ß‚ð’Ç‰Á

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            SceneDirector.itemCount++;
            other.gameObject.SetActive(false);
        }
    }
}
