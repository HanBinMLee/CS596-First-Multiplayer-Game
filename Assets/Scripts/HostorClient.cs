using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HostorClient : NetworkBehaviour
{
    public AudioSource plusSound;
    public AudioSource minusSound;

    private void OnTriggerEnter(Collider other)
    {
        if (!IsLocalPlayer) return; // Ensure only the local player's interactions trigger score changes

        // adds or subtracts corresponding player's points
        if (other.CompareTag("Plus"))
        {
            other.gameObject.SetActive(false);
            plusSound.Play();
            if (IsHost)
            {
                PointManager.Instance.AddToP1Score(1);
            }
            else
            {
                PointManager.Instance.AddToP2Score(1);
            }
        }
        else if (other.CompareTag("Minus"))
        {
            other.gameObject.SetActive(false);
            minusSound.Play();
            if (IsHost)
            {
                PointManager.Instance.AddToP1Score(-1);
            }
            else
            {
                PointManager.Instance.AddToP2Score(-1);
            }
        }
    }

}
