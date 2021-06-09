using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;
    private Rigidbody _rb;
    private GameObject _player;

    // Start is called before the first frame update
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _player = GameObject.Find("Player");
    }

    // Update is called once per frame
    private void Update()
    {
        FishMovement();
        if (transform.position.y < -10) Destroy(gameObject);
        
        Destroy(this.gameObject,10f);
    }

    private void FishMovement()
    {
        var lookDirection = (_player.transform.position - transform.position).normalized;
        _rb.AddForce(lookDirection * speed);
    }
}