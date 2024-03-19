using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class MoveCamera : NetworkBehaviour
{
    public Transform cameraPosition;

    // No longer used due to removal of first person
    void Update()
    {
        if (!IsOwner) return;
        transform.position = cameraPosition.position;
    }
}
