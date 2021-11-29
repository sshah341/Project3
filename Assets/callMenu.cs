using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class callMenu : MonoBehaviour
{
    public GameObject List;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CallList()
    {
        if (List.active == true)
        {
            List.active = false;
            
        }
        else
        {
            List.active = true;
            
        }
    }
}
