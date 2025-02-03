using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public GameObject gameClearText;
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            gameClearText.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
