using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    public GameObject Goal;
    public bool flag = false;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Box")
        {
            flag = true;
            Goal.SetActive(flag);
        }
    }
    // Start is called before the first frame update

    void Start()
    {
        flag = false;
        Goal.SetActive(flag);
    }

    // Update is called once per frame
    void Update()
    {
        //if(flag == false)
        //{
        //    Goal.SetActive(flag);
        //}
        //if(flag == true)
        //{
        //    flag = false;
        //}
    }
}
