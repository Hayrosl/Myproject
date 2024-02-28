using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCspeed : MonoBehaviour
{
    // Start is called before the first frame update
    public int speedVehiclesNPC;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,0, 1) * Time.deltaTime * speedVehiclesNPC);
    }
}
