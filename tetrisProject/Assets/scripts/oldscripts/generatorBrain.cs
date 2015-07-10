using UnityEngine;
using System.Collections;

public class generatorBrain : MonoBehaviour {

	public GameObject EmptyPiece_withpiceScript;
    Vector3 mypos;
	// Use this for initialization
	void Start () {
        makeObject();
      //  spawn();
	}

   public GameObject makeObject() {

       int x= Random.Range(0, 6);

        mypos = this.transform.position;

        GameObject go = Instantiate(EmptyPiece_withpiceScript, new Vector3(4f,16f,0f), Quaternion.identity) as GameObject;

        go.GetComponent<actualPiece>().build_Mesh_Piece(x);

        return go;
    }


   bool spawnmutex = false;

    public void spawn(){
        


        int x= Random.Range(0, 6);

        mypos = this.transform.position;

        GameObject go = Instantiate(EmptyPiece_withpiceScript, new Vector3(4f, 16f, 0f), Quaternion.identity) as GameObject;

        go.GetComponent<actualPiece>().build_Mesh_Piece(x);
    }

    void docontrole(GameObject go) { 
    
    
    }


    /*
   public  void startTimer() {
        StartCoroutine(mytimer());
    }
    IEnumerator mytimer()
    {
       // print(Time.time);
        yield return new WaitForSeconds(1);
        print(Time.time);
        spawn();
    }
    */

    float timeleft = 5f;

    void timerdown() {

        timeleft -= Time.deltaTime;
        if (timeleft < 0)
        {
            spawn();
            spawnmutex = false;
            timeleft = 5;
        }
    }

	// Update is called once per frame
	void Update () {

        

       
	}
}
