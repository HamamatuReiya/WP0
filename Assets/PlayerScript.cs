using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rd;
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, false);
    }

    // Update is called once per frame
    void Update()
    {
        const float moveSpeed = 5.0f;
        Vector3 v = rd.velocity;
        v.x = 0;
        v.z = 0;
        if (Input.GetKey(KeyCode.D))
        {
            v.x = moveSpeed;
            //transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            v.x = -moveSpeed;
            //transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            v.z = moveSpeed;
            //transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            v.z = -moveSpeed;
            //transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        rd.velocity = v;
    }
}
