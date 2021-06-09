using UnityEngine;

public class Fish : MonoBehaviour
{
    public float speed = 3.0f;
    private Rigidbody _fishrb;
    private GameObject _player;

    // Start is called before the first frame update
    private void Start()
    {
        _fishrb = GetComponent<Rigidbody>();
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
        var lookDirection = (_player.transform.position + transform.position).normalized;
        _fishrb.AddForce(lookDirection * speed);
    }
}
