using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEManager : MonoBehaviour
{
    [SerializeField]AudioClip ButtonSeOK;
    
    [SerializeField]AudioClip ButtonSeNG;
    
    [SerializeField]AudioClip CollisionSeOK;
    
    [SerializeField]AudioClip CollisionSeNG;

    byte wallTagNumber;


    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayButtonSE(byte buttonTagNumber)
    {
        if(wallTagNumber == buttonTagNumber)
        {
            audioSource.PlayOneShot(ButtonSeOK);
        }
        else
        {
            audioSource.PlayOneShot(ButtonSeNG);
        }
    }


    public void PlayCollisionSEOK()
    {
        audioSource.PlayOneShot(CollisionSeOK);
    }

    public void PlayCollisionSENG()
    {
        audioSource.PlayOneShot(CollisionSeNG);
    }

    public byte WallTagNumber
    {
        get { return wallTagNumber; }
        set { wallTagNumber = value; }
    }
}
