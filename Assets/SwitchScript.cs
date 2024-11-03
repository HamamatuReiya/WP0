using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    public GameObject Goal;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Goal.SetActive(true);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
