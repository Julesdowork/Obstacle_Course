using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int hits = 0;

    void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Hit"))    
        {
            hits++;
            Debug.Log("You've bumped into a thing this many times: " + hits);
        }    
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            Debug.Log("Congratulations! You made it through the course!!");
            Debug.Log("Your final score is: " + hits);
        }
    }
}
