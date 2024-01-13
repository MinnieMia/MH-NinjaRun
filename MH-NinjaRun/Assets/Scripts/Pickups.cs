using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{

    public int score;
    public Text scoreText;

    public ParticleSystem Pickup;

    void Start()
    {
       Pickup.Stop();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("coin")){
            //if the other game object has the tag coin, then do this...
            score++;
            scoreText.text = score.ToString();
            Destroy(other.gameObject);

            Pickup.Play();
        }
    }
}
