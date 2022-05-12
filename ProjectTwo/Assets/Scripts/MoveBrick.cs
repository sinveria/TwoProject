using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveBrick : MonoBehaviour
{
    public static float hor;
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal") * 10f * Time.deltaTime;
        transform.Translate(hor, 0, 0);
        rigidbody.velocity = new Vector3(hor, 0, 0);
    }
}
