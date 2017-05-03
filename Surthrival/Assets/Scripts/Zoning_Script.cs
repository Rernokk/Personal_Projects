using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoning_Script : MonoBehaviour {
    Material rend;
	// Use this for initialization
	void Start () {
        rend = transform.GetComponent<MeshRenderer>().material;
    }
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit) && hit.transform.tag == "Ground"){
            transform.position = hit.point + new Vector3(0, transform.localScale.y/2, 0);
            rend.color = new Color(rend.color.r, rend.color.g, rend.color.b, 1f);
        } else
        {
            rend.color = new Color(rend.color.r, rend.color.g, rend.color.b, 0);
        }
	}
}
