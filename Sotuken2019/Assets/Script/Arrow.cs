using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider collider)
    {
        // 3D同士が接触している間、常に呼び出される処理
        if (collider.gameObject.tag == "Player")
        {
            
        }

    }
}
