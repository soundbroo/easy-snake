using System.Collections;
using UnityEngine;

public class TailBehaviour : MonoBehaviour
{

    public float speed;
    private Vector3 movementTarget;
    private GameObject tailPartObject;
    private int currentTailPartIndex;
    private SnakeBehaviour snake; 

    // Start is called before the first frame update
    void Start()
    {
        snake = GameObject.FindGameObjectWithTag("SnakeHead").GetComponent<SnakeBehaviour>();
        speed = snake.speed;
        currentTailPartIndex = snake.tailParts.IndexOf(gameObject);
        tailPartObject = snake.tailParts[snake.tailParts.Count - 2];
    }

    // Update is called once per frame
    void Update()
    {
        movementTarget = tailPartObject.transform.position;
        transform.LookAt(movementTarget);
        transform.position = Vector3.Lerp(transform.position, movementTarget, speed*Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("SnakeHead") && currentTailPartIndex > 15) {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
