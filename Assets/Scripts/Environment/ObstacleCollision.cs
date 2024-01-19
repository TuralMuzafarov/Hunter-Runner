using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource crushHud;
    public GameObject levelControl;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMove>().enabled = false;
        crushHud.Play();
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        levelControl.GetComponent<EndRunSequence>().enabled = true;
        
    }
}