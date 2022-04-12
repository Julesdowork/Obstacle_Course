using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void PrintInstructions()
    {
        Debug.Log("Welcome to the Obstacle Course!");
        Debug.Log("Use the arrow keys (or WASD keys) to move Mr. Bean.");
        Debug.Log("Make your way to the end of the course, making sure to avoid the obstacles along the way...");
    }

    private void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0, zValue);
    }
}
