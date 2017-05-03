using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection_Script : MonoBehaviour {
    public GameObject curr;
    [SerializeField]
    List<GameObject> Structures;
    [SerializeField]
    GameObject myObj;
	// Use this for initialization
	void Start () {
        //curr = Structures[0];
        myObj = null;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            curr = null;
            Destroy(myObj);
            curr = Structures[0];
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            curr = null;
            Destroy(myObj);
            curr = Structures[1];
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            curr = null;
            Destroy(myObj);
            curr = Structures[2];
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            curr = null;
            Destroy(myObj);
            curr = Structures[3];
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            curr = null;
            Destroy(myObj);
            myObj = null;
        }

        if (curr != null && myObj == null)
        {
            myObj = Instantiate(curr, Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, curr.transform.localScale.y / 2, 0), Quaternion.identity);
        }
    }
}
