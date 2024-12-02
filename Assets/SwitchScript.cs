using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    public GameObject Goal;
    public bool flag = false;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Goal.SetActive(flag);
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Hit");
        flag = true;
        Goal.SetActive(flag);
    }
}
