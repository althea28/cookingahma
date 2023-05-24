using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toastclick : MonoBehaviour
{

    public Transform kayaObj;
    public Transform butterObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        //GetComponent<Transform> ().position = new Vector3(2.9f,3.082f,3.366f);
        //for reference, x coords are: boardA=2.9, boardB=0.52, grillA= -2.15f, grillB= -3.94
       
        if ((gameflow.placeKaya == "y") && (transform.position.x > 0.0f)) { //placing kaya && toast on board
            Instantiate(kayaObj, transform.position + new Vector3(0.01f, 0.182f, 0.032f), kayaObj.rotation);
            gameflow.placeKaya = "n";

        } else if ((gameflow.placeButter == "y") && (transform.position.x > 0.0f)) { //placing butter && toast on board
            Instantiate(butterObj, transform.position + new Vector3(0.005f, 0.247f, 0.129f), butterObj.rotation);
            gameflow.placeButter = "n";

        } else if (gameflow.toastOnBoardA == "n") { //moving from grill to boardA
            if (transform.position.x == -2.15f) { //if in grillA 
                gameflow.toastOnGrillA = "n";
            } else {
                gameflow.toastOnGrillB = "n";
            }
            GetComponent<Transform> ().position = new Vector3(2.9f,3.08f,3.366f);
            gameflow.toastOnBoardA = "y";

        } else if (gameflow.toastOnBoardB == "n") { //moving from grill to boardB
            if (transform.position.x == -2.15f) { //if in grillA
                gameflow.toastOnGrillA = "n";
            } else {
                gameflow.toastOnGrillB = "n";
            }
            GetComponent<Transform> ().position = new Vector3(0.52f,3.08f,3.366f);
            gameflow.toastOnBoardB = "y";
        }
    }
}
