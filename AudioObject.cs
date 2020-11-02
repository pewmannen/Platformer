using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioObject : MonoBehaviour
{
    public AudioClip coin;
    AudioSource aScorce;
    GameObject obj;
    void Start()
    {
        obj = GameObject.Find("AudioObject");
        if (obj != null)
            aScorce = obj.GetComponent<AudioSource>(); // get component once @ Start more efficient.
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            aScorce.clip = coin;
            aScorce.Play();
        }
    }
}
