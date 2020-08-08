using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateFood : MonoBehaviour
{

    public GameObject foodPrefab;
    public GameObject food;
    public Vector3 position;
    public float XRange = 80f;
    public float ZRange = 36f;
    private float XPosition;
    private float ZPosition;

    void GenerateFoodPosition() {
        XPosition = Random.Range(-XRange, XRange);
        ZPosition = Random.Range(-ZRange, ZRange);
        position = new Vector3(XPosition, 5, ZPosition);
    }

    void GenerateFoodObject() {
        GenerateFoodPosition();
        food = GameObject.Instantiate(foodPrefab, position, Quaternion.identity) as GameObject;
    }

    // Start is called before the first frame update
    void Start()
    {
        GenerateFoodObject();
    }

    

    // Update is called once per frame
    void Update()
    {
        if (!food) {
            GenerateFoodObject();
        }
    }
}
