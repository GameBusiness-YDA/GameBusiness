using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{

    float WallMoveSpeed;


    private void Start()
    {
        WallMoveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(gameObject.transform.forward * -WallMoveSpeed * Time.deltaTime, Space.World);

        if (this.transform.position.z < -10.0f)
        {
            Destroy(this.gameObject);
        }

    }
}
