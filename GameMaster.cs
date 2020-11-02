using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameMaster : MonoBehaviour
{
    public static GameMaster gm;

    void Start(){
        if (gm == null){
            gm = GameObject.FindGameObjectWithTag ("GM").GetComponent<GameMaster>();

        }
    }

    public Transform playerPrefab;
    public Transform spawnPoint;
    public float spawnDelay = 1;
    public Transform spawnPrefab;

    public int points;
    public Text pointsText;

    void Update()
    {
        pointsText.text = ("Points: " + points);
    }

    public IEnumerator RespawnPlayer()
    {
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
        Instantiate(spawnPrefab, spawnPoint.position, spawnPoint.rotation);

    }

    void FixedUpdate()
    {
        if (!playerPrefab)
        {
            playerPrefab = GameObject.FindGameObjectWithTag("Player").transform;
        }

        if (transform == null)
            return;
        if (playerPrefab == null)
            return;
    }

        public static void KillPlayer(Player player)
    {
        DeathManager.deathValue += 1; 
        Destroy(player.gameObject);
        gm.StartCoroutine(gm.RespawnPlayer());
    }
}
