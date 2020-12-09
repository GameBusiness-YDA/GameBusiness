using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    /// <summary>
    /// 0:判定無し 1:クリア 2:ミス
    /// </summary>
    byte collisionResult;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.tag == other.tag)
        {
            collisionResult = 1;
        }
        else
        {
            collisionResult = 2;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        collisionResult = 0;
    }


    #region GetSet関数


    /// <summary>
    /// 0:判定無し 1:クリア 2:ミス
    /// </summary>
    public byte CollisionResult
    {
        get { return collisionResult; }
        set { collisionResult = value; }
    }

    #endregion
}
