using UnityEngine;
using System.Collections;

public class Coin2 : MonoBehaviour
{
    private GameObject unitychan;
    void Start()
    {
        //シーン中のunitychanオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
    }
    void Update()
    {
        if (this.transform.position.z < unitychan.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
