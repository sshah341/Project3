using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door1 : MonoBehaviour
{ public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


	void OnTriggerEnter(Collider other){
		Debug.Log("some collision");
		 anim.SetBool("isOpen", true);
	}
}





