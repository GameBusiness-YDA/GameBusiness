using UnityEngine;

public class Collision : MonoBehaviour
{
    /// <summary>
    /// 0:判定無し 1:クリア 2:ミス
    /// </summary>
    byte collisionResult;

    GameObject s_comboManager;
    ComboManager comboManager;

    GameObject s_ButtonManager;
    ButtonManager buttonManager;


    GameObject s_WallGeneration;
    WallGeneration wallGeneration;

    public AudioClip OKSound;
    public AudioClip NGSound;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        s_comboManager = GameObject.Find("ComboManager");
        comboManager = s_comboManager.GetComponent<ComboManager>();

        s_ButtonManager = GameObject.Find("ButtonManager");
        buttonManager = s_ButtonManager.GetComponent<ButtonManager>();

        s_WallGeneration = GameObject.Find("WallManager");
        wallGeneration = s_WallGeneration.GetComponent<WallGeneration>();

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// 0:判定無し 1:クリア 2:ミス
    /// </summary>
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("何かに当たった");

        if (this.gameObject.tag == other.tag)
        {
            collisionResult = 1;
            comboManager.ComboPuls();
            //audioSource.PlayOneShot(OKSound);
        }
        else
        {
            collisionResult = 2;
            comboManager.ComboReset();
            //audioSource.PlayOneShot(NGSound);
        }

        Debug.Log("Collisions.cs");
        wallGeneration.CountTimeFlg = true;
        buttonManager.ChangeButtons();
        Destroy(this.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        collisionResult = 0;
    }

}
