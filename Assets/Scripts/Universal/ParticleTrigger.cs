using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PURPOSE: To play self-created confetti animation

public class ParticleTrigger : MonoBehaviour
{
    public GameObject TriggerObject;
    public ParticleSystem confetti;

    private void Start()
    {
        TriggerObject.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PlayerCar")
        {
            confetti.Play();
        }
       
    }
}
