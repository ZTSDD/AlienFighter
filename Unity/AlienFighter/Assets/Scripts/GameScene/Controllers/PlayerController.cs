using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public BtnModel leftBtnModel;
    public BtnModel rigthBtnModel;
    public BtnModel atackBtnModel;
    public PlayerModel playerModel;
    public GameObject bulletPrefab;
    private bool reload;
    private Transform bulletsTransform;
    public GameObject gameState;

    // Start is called before the first frame update
    void Start()
    {
        bulletsTransform = transform.Find("Bullets");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            DontDestroyOnLoad(gameState);
            SceneManager.LoadScene("GameOverScene", LoadSceneMode.Single);
        }
    }

    void Update()
    {
        HandlePlayerMoves();
        HandlePlayerActions();
    }

    private void HandlePlayerMoves()
    {
        var xDelta = (leftBtnModel.Clicked && !rigthBtnModel.Clicked)
            ? -playerModel.speed / Time.deltaTime
            : (!leftBtnModel.Clicked && rigthBtnModel.Clicked)
                ? playerModel.speed / Time.deltaTime
                : 0;
        transform.position = new Vector3(
                transform.position.x + xDelta,
                transform.position.y,
                transform.position.z);
    }

    private void HandlePlayerActions()
    {
        if (atackBtnModel.Clicked && !reload)
        {
            Atack();
        }
    }

    private void Atack()
    {
        var bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        bullet.transform.parent = bulletsTransform;
        StartCoroutine(ReloadCoroutine(0.75f));
    }

    private IEnumerator ReloadCoroutine(float reloadTime)
    {
        reload = true;
        yield return new WaitForSeconds(reloadTime);
        reload = false;
    }
}