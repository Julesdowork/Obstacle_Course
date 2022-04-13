using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int hits = 0;

    void OnCollisionEnter(Collision other)
    {
        hits++;
        Debug.Log("You've bumped into a thing this many times: " + hits);
    }
}
