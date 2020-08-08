using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainCollision : MonoBehaviour
{

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("SnakeHead")) {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
