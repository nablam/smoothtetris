using UnityEngine;
using System.Collections;

public class sensorGridSc : MonoBehaviour {
    public GameObject ballSensor;

    public GameObject[,] sensorGrid;



    public void buildSensorGrid() {
        for (int y = 0; y < 16; y++) {
            for (int x = 0; x < 9; x++) {
              GameObject go=  Instantiate(ballSensor, new Vector3(x  , y , 0), Quaternion.identity) as GameObject;
              go.GetComponent<ballSensorIDSc>().ballx = x;
              go.GetComponent<ballSensorIDSc>().bally = y;
              go.transform.parent = this.transform;
            }
        }
    
    }

	// Use this for initialization
	void Start () {
        sensorGrid = new GameObject[9, 16];
        buildSensorGrid();
	}
	
   

	// Update is called once per frame
	void Update () {
	
	}
}
