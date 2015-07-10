using UnityEngine;
using System.Collections;

public class actualPiece : MonoBehaviour {
	public GameObject acube;
	private PieceScript gridscript;
	bool[,] localgrid;
    GameObject[,] localCUBEmatrrix;

    Transform tr;
    Vector3 mypos;


    GameObject thebrain;

    public bool moving;

    void Awake() { localCUBEmatrrix = new GameObject[4, 4];
    thebrain = GameObject.Find("BRAIN");
    }


    bool cancontrol ;

	// Use this for initialization
	void Start () {
        cancontrol = true;
       
        
        moving = true;

        tr = this.transform;
        mypos = this.transform.position;
        
	}

	public void build_Mesh_Piece(int type) {
		type = type % 6;
		gridscript = new PieceScript(type);
		localgrid = gridscript.pieceGrid;

       

		for (int x = 0; x < 4; x++) {
			for (int y = 0; y < 4; y++) {
				if (localgrid[x, y]) {
					GameObject go = Instantiate(acube, new Vector3(x+3, y+18, 0), Quaternion.identity) as GameObject;             
                    localCUBEmatrrix[x, y] = go;
                    go.renderer.material.color = Color.green;
                    go.transform.parent = this.transform;
                    go.tag = "visible_active";
                    
				}
                else
                    {
                        GameObject go = Instantiate(acube, new Vector3(x+3, y + 18, 0), Quaternion.identity) as GameObject;
                        go.transform.parent = this.transform;
                        go.renderer.material.color = Color.white;
                        go.tag = "invisible_active";
                        localCUBEmatrrix[x, y] = go;
                    }
			}
		}
	
	}

    public void rearrangeRotation() {


        localgrid = gridscript.rotateMatrixLeft(gridscript.pieceGrid);

        for (int x = 0; x < 4; x++)
        {
            for (int y = 0; y < 4; y++)
            {
                if (localgrid[x, y])
                {

                    localCUBEmatrrix[x, y].tag = "visible_active";
                    localCUBEmatrrix[x, y].renderer.material.color = Color.green;
                    

                }
                else
                {

                    localCUBEmatrrix[x, y].tag = "invisible_active";
                    localCUBEmatrrix[x, y].renderer.material.color = Color.white;

                }
            }
        }
    
    
    }




    public void switchoff() {// Debug.Log("switcinh off");

      //  thebrain.GetComponent<generatorBrain>().startTimer();
       moving = false;
       cancontrol = false;
      // spawneryo.GetComponent<generatorBrain>().spawn();

    }
    public void switchon()
    {// Debug.Log("switcinh off");
        moving = true;
    }


    public void ControleIt() {


        if (cancontrol) {
         if (moving) transform.Translate(Vector3.down * 0.8f * Time.deltaTime);
         //   if (moving) transform.Translate(Vector3.down * 2f * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.LeftArrow)) { transform.position = new Vector3(transform.position.x - 1, transform.position.y + 0.01f, transform.position.z); };
        if (Input.GetKeyDown(KeyCode.RightArrow)) { transform.position = new Vector3(transform.position.x + 1, transform.position.y + 0.01f, transform.position.z); };

        if (Input.GetKeyDown(KeyCode.UpArrow)) { rearrangeRotation(); };}


    
    }
	// Update is called once per frame
	
    void Update () {


        ControleIt();
	
	}
}
