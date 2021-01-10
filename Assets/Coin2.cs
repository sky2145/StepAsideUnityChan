using UnityEngine;
using System.Collections;

public class Coin2 : MonoBehaviour
{
    private GameObject MainCamera;
    void Start()
    {
        //シーン中のunitychanオブジェクトを取得
        this.MainCamera = GameObject.Find("Main Camera");
    }
    void Update()
    {
        if (this.transform.position.z < MainCamera.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
