using UnityEngine;
using System.Collections;

public class StageSelectBGMove : MonoBehaviour
{
    [SerializeField]
    float speed = 100.0f;

    void Update()
    {
        transform.localPosition -= new Vector3(Time.deltaTime * speed,0f,0f );
        if (transform.localPosition.x < -307.0f)
        {
            transform.localPosition = new Vector3(307.0f,0f, 0f);
        }
    }
}
