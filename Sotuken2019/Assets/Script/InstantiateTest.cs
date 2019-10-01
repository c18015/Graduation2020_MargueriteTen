using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTest : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 pos1;
    public Vector3 pos2;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pos1 = Input.mousePosition;
            pos1 = Camera.main.ScreenToWorldPoint(pos1);
            //Debug.Log(pos1);
        }

        if (Input.GetMouseButton(0))
        {
            pos2 = Input.mousePosition;

            pos2 = Camera.main.ScreenToWorldPoint(pos2);
            //Debug.Log(pos2);


        }

        if (Input.GetMouseButtonUp(0))
        {
            Vector3 diff = (pos1 - pos2);
            float radian = diff.y * 3 ;
            float radian2 = diff.x * 3;

            //Debug.Log(diff);

            GameObject obj = Instantiate(prefab, pos1, Quaternion.identity) as GameObject;
            obj.transform.localScale = new Vector3(radian2, radian, 3);//希望する値 1つ目固定,縦,横

        }
    }

    Vector3 posGet()
    {
        Vector3 nowPos;                                          //Vector3でマウス位置座標を取得する        
        nowPos = Input.mousePosition;                            // Z軸修正      
        nowPos.z = 10f;                                          // マウス位置座標をスクリーン座標からワールド座標に変換する    
        nowPos = Camera.main.ScreenToWorldPoint(nowPos);

        return nowPos;

    }

    void insta()
    {
        GameObject obj = Instantiate(prefab, this.transform.position, Quaternion.identity) as GameObject;

        obj.transform.localScale = new Vector3(1, 0, 0);//希望する値 1つ目固定,縦,横

    }

}
