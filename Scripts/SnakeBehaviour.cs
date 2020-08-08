using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnakeBehaviour : MonoBehaviour
{
    public float speed = 20f;
    public float rotationSpeed = 10f;
    public Text score;
    private int scoreCount = 0;
    public GameObject tailPrefab;
    public List<GameObject> tailParts = new List<GameObject>();
    public float tailPartsOffset = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        tailParts.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        score.text = scoreCount.ToString();
        transform.Translate(Vector3.forward*speed*Time.deltaTime);

        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(-Vector3.up*rotationSpeed*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(Vector3.up*rotationSpeed*Time.deltaTime);
        }
    }

    public void IncrementTailPart() {
        Vector3 tailPosition = tailParts[tailParts.Count - 1].transform.position;
        tailPosition.z -= tailPartsOffset;
        tailParts.Add(GameObject.Instantiate(tailPrefab, tailPosition, Quaternion.identity));
        scoreCount++;
    }
}
