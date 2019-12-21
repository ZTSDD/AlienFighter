using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;
    [SerializeField]
    private List<EnemyController> enemies;
    private Transform enemiesTransform;

    public void InstantiateEnemies(int count, float interval, Vector3 pos)
    {
        StopAllCoroutines();
        StartCoroutine(EnemyCreatorCoroutine(count, interval, pos));
    }

    public void DestroyAllEnemies(float delay)
    {
        foreach (var enemy in enemies)
        {
            Destroy(enemy, delay);
        }
    }

    private IEnumerator EnemyCreatorCoroutine(int count, float interval, Vector3 pos)
    {
        for (int i = 0; i < count; i++)
        {
            var enemy = Instantiate(enemyPrefab, pos, Quaternion.identity);
            enemy.transform.parent = enemiesTransform;
            yield return new WaitForSeconds(interval);
        }
        yield return null;
    }

    // Start is called before the first frame update
    void Start()
    {
        enemiesTransform = this.transform.GetChild(0);
        InstantiateEnemies(100, 0.5f, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
