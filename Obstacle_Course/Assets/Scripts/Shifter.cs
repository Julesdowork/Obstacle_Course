using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shifter : MonoBehaviour
{
    [SerializeField] private float shiftSpeed;
    [SerializeField] private Transform[] positions;
    private int positionIndex;

    void Start()
    {
        transform.position = positions[0].position;
    }

    void Update()
    {
        if (positionIndex == 0)
        {
            transform.position = Vector3.MoveTowards(transform.position,
                positions[1].position, shiftSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, positions[1].position) <= Mathf.Epsilon)
            {
                ChangePosition();
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position,
                positions[0].position, shiftSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, positions[0].position) <= Mathf.Epsilon)
            {
                ChangePosition();
            }
        }
    }

    private void ChangePosition()
    {
        positionIndex = positionIndex == 0 ? 1 : 0;
    }
}
