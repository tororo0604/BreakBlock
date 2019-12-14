using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
        Vector3 screenPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3でマウス位置座標を取得する
//		Vector3 position = Input.mousePosition;
		// Z軸修正
//		position.y = 0f;
//		position.z = -8f;
		// マウス位置座標をスクリーン座標からワールド座標に変換する
//		Vector3 screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
		// ワールド座標に変換されたマウス座標を代入
//		gameObject.transform.position = screenToWorldPointPosition;


        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position -= transform.right * 0.1f;
        }else if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position += transform.right * 0.1f;
        }
        
//        this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
//        Vector3 position = new Vector3 (Input.mousePosition.x,Input.mousePosition.y,screenPoint.z);
//		position.y = -10f;
//		position.z = -8f;
//        transform.position = Camera.main.ScreenToWorldPoint (position);
    }
}
