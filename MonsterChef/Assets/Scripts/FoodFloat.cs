using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodFloat : MonoBehaviour {
    private bool move = true;
    public Vector3 moveVector = Vector3.up;
    public float MoveRange = 2.0f;
    public float MoveSpeed = 0.5f;

    private FoodFloat foodFloat;
    private Vector3 startPosition;

    private void Start()
    {
        foodFloat = this;
        startPosition = foodFloat.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(move)
        {
            foodFloat.transform.position = startPosition + moveVector *
                (MoveRange * Mathf.Sin(Time.timeSinceLevelLoad) * MoveSpeed);
        }
    }


}
