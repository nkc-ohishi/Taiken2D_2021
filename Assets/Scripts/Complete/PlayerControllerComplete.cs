using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerComplete : MonoBehaviour
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
        if (SceneDirectorComplete.gameFlg == false) return;

        Vector2 moveVec = Vector2.zero;

        moveVec.x = Input.GetAxis("Horizontal");
        moveVec.y = Input.GetAxis("Vertical");

        rb2d.AddForce(moveVec * speed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            SceneDirectorComplete.itemCount++;
            other.gameObject.SetActive(false);
        }
    }
}
