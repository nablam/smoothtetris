using UnityEngine;
using System.Collections;

public class destroyMe : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - 2, transform.position.z);
       // Destroy(this.gameObject);

        Debug.Log("bottom brick sais hi");
    }
}
