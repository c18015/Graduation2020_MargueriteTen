using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConPosWatch : MonoBehaviour
{
    public OVRInput.Controller controller;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 CPW = OVRInput.GetLocalControllerPosition(controller);

        
    }
}
