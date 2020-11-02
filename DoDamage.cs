using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoDamage : MonoBehaviour
{
    [System.Serializable]
    public class EnemyStats
    {
        public int damage = 100;
    }

    public EnemyStats stats = new EnemyStats();

    void OnCollisionEnter2D(Collision2D _colInfo)
    {
        Player _player = _colInfo.collider.GetComponent<Player>();
        if (_player != null)
        {
            _player.DamagePlayer(stats.damage);
        }
    }
}
