using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rd;
    //public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        const float moveSpeed = 5.0f;
        Vector3 v = rd.velocity;
        
        //animator.SetBool("mode", false);
        v.x = 0;
        v.z = 0;
        if (Input.GetKey(KeyCode.D))
        {
            v.x = moveSpeed;
            //animator.SetBool("mode", true);
            transform.rotation = Quaternion.Euler(0, 90, 0);
            //transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            v.x = -moveSpeed;
            //animator.SetBool("mode", true);
            transform.rotation = Quaternion.Euler(0, -90, 0);
            //transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            v.z = moveSpeed;
            //animator.SetBool("mode", true);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            //transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            v.z = -moveSpeed;
            //animator.SetBool("mode", true);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            //transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        rd.velocity = v;
    }
}
