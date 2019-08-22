using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {


    public Vector3 pos1;
    bool isMouseOn = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            isMouseOn = true;
            pos1 = posGet();
            //this.transform.position = /*PlayerSC[TurnController.nowTurn].transform.position;*/ PlayerSC[TurnController.nowTurn].transform.position;
        }

        if (Input.touchCount > 0)
        {
            // タッチ情報の取得
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Debug.Log("押した瞬間");
            }
        }
	}


    Vector3 posGet()
    {
        Vector3 nowPos;                                          //Vector3でマウス位置座標を取得する        
        nowPos = Input.mousePosition;                            // Z軸修正      
        nowPos.z = 10f;                                          // マウス位置座標をスクリーン座標からワールド座標に変換する    


        Debug.Log(nowPos);

        return nowPos;
    }
}

/* タッチされているかチェック
if (Input.touchCount > 0) {
    // タッチ情報の取得
    Touch touch = Input.GetTouch(0);

    if (touch.phase == TouchPhase.Began) {
        Debug.Log("押した瞬間");
    }

    if (touch.phase == TouchPhase.Ended) {
    Debug.Log("離した瞬間");
    }

    if (touch.phase == TouchPhase.Moved) {
        Debug.Log("押しっぱなし");
    }
}*/
