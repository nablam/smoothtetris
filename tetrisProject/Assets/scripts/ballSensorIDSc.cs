using UnityEngine;
using System.Collections;

public class ballSensorIDSc : MonoBehaviour {

	
	public int ballx;
	public int bally;

    public bool ison;
	// Use this for initialization
	void Start () {
        ison = false;
	//	ballx = 0;
	//	bally = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider otherOB)
    {
        if (otherOB.gameObject.tag == "visible_active")
        {

            this.gameObject.renderer.material.color = Color.red;
        }


        if (otherOB.gameObject.tag == "invisible_active")
        {

            this.gameObject.renderer.material.color = Color.blue;
        }
    }

    void OnTriggerExit(Collider otherOB)
    {

       // if (otherOB.gameObject.tag == "visible_active")
        

            this.gameObject.renderer.material.color = Color.white;
        
    }
}
