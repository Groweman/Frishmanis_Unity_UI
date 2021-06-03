using System.Collections;
using UnityEngine;

public class KursorsUzAttela : MonoBehaviour
{
    public AudioSource skanasAvots;
    public AudioClip skanaKoAtskanot;
  

    public void uzbiditUzAttela(){
        skanasAvots.PlayOneShot(skanaKoAtskanot);
    }

    public void kursorsNoietNoAttela(){
        skanasAvots.Stop();
    }
}
