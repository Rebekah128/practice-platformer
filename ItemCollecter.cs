using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollecter : MonoBehaviour
{
    private int Kiwi = 0;

    [SerializeField] private Text kiwiText;

    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Kiwi"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            Kiwi ++;
            kiwiText.text = "Kiwifruit: " + Kiwi;
        }
    }
}
