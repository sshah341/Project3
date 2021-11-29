using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class call : MonoBehaviour
{
    public GameObject RotationList;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rotation()
    {
        if (RotationList.active == true)
        {
            RotationList.active = false;

        }
        else
        {
            RotationList.active = true;

        }
    }
}

