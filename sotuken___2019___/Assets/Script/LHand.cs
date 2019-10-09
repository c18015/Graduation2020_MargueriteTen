using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LHand : MonoBehaviour
{

    bool ArrowLock = false;
    public OVRInput.Controller RHandPos;
    public OVRInput.Controller LHandPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 LHP = OVRInput.GetLocalControllerPosition(RHandPos);
        //Debug.Log("");
        if (!ArrowLock && Input.GetKeyDown(KeyCode.A))
        {
            ArrowLock = true;
        }


        if (ArrowLock)
        {
            Debug.Log("OK");
            if (OVRInput.GetUp(OVRInput.RawButton.RIndexTrigger))
            {
                Vector3 RHP = OVRInput.GetLocalControllerPosition(RHandPos);
                Debug.Log(RHP);
                Debug.Log(LHP);
            }
        }
    }

    private void OnCollisionStay(Collision collision)// 3D同士が接触している間、常に呼び出される処理
    {
        if (collision.gameObject.tag == "Rhand")
        {
            ArrowLock = true;
            Debug.Log("アローロック ＝" + ArrowLock);
        }
    }

    private void OnCollisionExit(Collision collision)// 3D同士が離れた瞬間の１回のみ呼び出される処理
    {
        if (collision.gameObject.tag == "Rhand")
        {
            ArrowLock = false;
            Debug.Log("アローロック ＝" + ArrowLock);
        }
    }

}
