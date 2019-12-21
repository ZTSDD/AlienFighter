using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField]
    private BulletModel bulletModell;
    private Vector3 startPos;
    private const int maxRange = 8;

    // Start is called before the first frame update
    void Start()
    {
        startPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3
        {
            x = transform.position.x,
            y = transform.position.y + bulletModell.speed / Time.deltaTime,
            z = transform.position.z
        };

        if (Vector3.Distance(transform.position, startPos) > maxRange)
        {
            Destroy(gameObject, 0f);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Destroy(this.gameObject, 0f);
            Destroy(collision.gameObject, 0f);
        }
    }
}
