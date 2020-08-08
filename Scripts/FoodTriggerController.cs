using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTriggerController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("SnakeHead")) {
            other.GetComponent<SnakeBehaviour>().IncrementTailPart();
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
