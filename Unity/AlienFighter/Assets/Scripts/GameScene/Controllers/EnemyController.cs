using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public enum MoveDirection { Side, Bottom }

    [SerializeField]
    private EnemyModel enemyModel;
    [SerializeField]
    private Vector3 targetPos;
    [SerializeField]
    private MoveDirection direction;

    // Start is called before the first frame update
    void Start()
    {
        targetPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, targetPos) > 0)
        {
            transform.position = Vector3.MoveTowards(
                current: transform.position,
                target: targetPos,
                maxDistanceDelta: enemyModel.speed / Time.deltaTime);
        }
        else
        {
            if (direction.Equals(MoveDirection.Side))
            {
                direction = MoveDirection.Bottom;
                targetPos = new Vector3 { x = targetPos.x, y = targetPos.y - 0.8f, z = targetPos.z };
            }
            else
            {
                direction = MoveDirection.Side;
                targetPos = (transform.position.x > 0)
                    ? new Vector3 { x = -2.5f, y = targetPos.y, z = targetPos.z }
                    : new Vector3 { x = 2.5f, y = targetPos.y, z = targetPos.z };
            }
        }
    }
}
