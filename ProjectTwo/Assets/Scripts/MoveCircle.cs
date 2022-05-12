using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCircle : MonoBehaviour
{
    private Rigidbody2D rigidbody;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rigidbody = GetComponent<Rigidbody2D>();

        if (collision.gameObject.name == "Brick" || collision.gameObject.name == "Frame" || collision.gameObject.name == "BrickDestroy")
        {
            rigidbody.AddForceAtPosition(Vector2.up * 30f, Vector2.right * 10f);
        }
    }

}
