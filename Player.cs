using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [System.Serializable]

    public class PlayerStats
    {
        public float Health = 100f;
    }

    private GameMaster gm;

    public Transform blood;

    public PlayerStats playerStats = new PlayerStats();

    public float fallBoundary = -20;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    void Update()
    {
        if (transform.position.y <= fallBoundary)
            DamagePlayer(Mathf.Infinity);
    }

    public void DamagePlayer (float damage)
    {
        Instantiate(blood, transform.position, Quaternion.identity);
        playerStats.Health -= damage;
        if (playerStats.Health <= 0){
            GameMaster.KillPlayer(this);
      
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            gm.points += 1;
        }
    }

    //void OnCollisionEnter2D(Collision2D col)
    //{
    //if (col.gameObject.tag == "Coin")
    //{
    //Score.scoreAmount += 1;
    //Destroy(col.gameObject);

    //}
    //}


}
