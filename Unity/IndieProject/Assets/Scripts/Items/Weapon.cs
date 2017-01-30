using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Equipment {

    void Start()
    {
        if (objectName == "")
        {
            objectName = Random.Range(0, 100).ToString();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            print(objectName);
        }
    }
}
