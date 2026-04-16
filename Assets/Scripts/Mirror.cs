using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
    public GameObject OGobject;
    public GameObject MIRRORobject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MIRRORobject.transform.position = new Vector3(OGobject.transform.position.x, OGobject.transform.position.y, OGobject.transform.position.z * -1);
    }
}
