using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class CollisionScript : NetworkBehaviour
{
    // only used to play the touching player audio
    // separate for modularity if more collisions features want to be added
    public AudioSource touchPlayerAudio;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Collision detected with {other.gameObject.name}");
        if (other.CompareTag("Player") && IsOwner)
        {
            Debug.Log("Attempting to play audio for the local player.");
            touchPlayerAudio.Play();
        }
    }
}
