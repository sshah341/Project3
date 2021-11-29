using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class rotateLeft : MonoBehaviour
{
  
    public Quaternion startQuaternion;
    public float lerpTime = 1;
    public bool rotateLeft1;
    private GameObject room1;
    private GameObject room2;
    private float left;
    private float toLeft;
    public GameObject currState;
    rotateRight otherState;

    void Start()
    {


        room1 = GameObject.Find("Room");
        
        left = 0f;
        toLeft = 0f;

    }

    
    void Update()
    {
   
        if(rotateLeft1){
              
           
            if(toLeft != left){
                left++; 
                room1.transform.rotation = Quaternion.Euler(new Vector3(left, 0f, 0f)); 
            }
        }
     
    }


      private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "leftController" || other.gameObject.tag == "rightController"){
            currState.GetComponent<rotateRight>().rotateLeftFun1();
     
                
        }

    }


      public void rotateLeftFun(){
          
                rotateLeft1 = true;
                left  = 0f;
                toLeft = toLeft + 90;
                
           // toLeft = toLeft + 90f; 
    }

}
