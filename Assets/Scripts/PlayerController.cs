using System;
using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public bool isAlive = true;
    public int playerScore;
    
    private Rigidbody _playerRb;
    
    // Start is called before the first frame update
    private void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Movement();
    }
    
    private void Movement()
    {
        var movementH = Input.GetAxis("Horizontal");
        var movementV = Input.GetAxis("Vertical");

        var movement = new Vector3(movementH, 0.0f, movementV);

        _playerRb.AddForce(movement * speed);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag($"Fish"))
        {
            Destroy(other.gameObject);
            playerScore++;
        }
        else if (other.gameObject.CompareTag($"Enemy"))
        {
            this.gameObject.SetActive(false);
            isAlive = false;
        }
        
    }
}