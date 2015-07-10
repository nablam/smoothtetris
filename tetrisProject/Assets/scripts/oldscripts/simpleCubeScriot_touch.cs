using UnityEngine;
using System.Collections;

public class simpleCubeScriot_touch : MonoBehaviour {


    public int[] ID;

    bool localcubeistouchong;
	// Use this for initialization
	void Start () {
        ID = new int[2];
        localcubeistouchong = false;
	}
	
	// Update is called once per frame
	void Update () {
       /* if (rigidbody.IsSleeping())
        {
            rigidbody.WakeUp();
        }
        */

        localcubeistouchong = false;
        if (localcubeistouchong)
        {
            Debug.Log("we noo touch");
            this.transform.parent.GetComponent<actualPiece>().switchon();
        }
	}


    void OnTriggerEnter(Collider  otherOB) {
        if (otherOB.gameObject.tag == "visible_active")
        {
            Debug.Log("we done hit something");
            this.transform.parent.GetComponent<actualPiece>().switchoff();
        }
    }

    void OnTriggerExit(Collider otherOB)
    {
        Debug.Log("we EXITED");
        if (otherOB.gameObject.tag == "visible_active")
        this.transform.parent.GetComponent<actualPiece>().switchon();
    }
    
/*
    void OnCollisionStay(Collision collisionInfo)
    {
        Debug.Log("touch staying");
        localcubeistouchong = true;

        if (collisionInfo.contacts.Length > 0)
        {
            Debug.Log("touch staying");
            this.transform.parent.GetComponent<actualPiece>().switchon();
        }
    }
    */

}
