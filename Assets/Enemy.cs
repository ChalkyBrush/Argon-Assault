using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    [Tooltip("Explosion FX")] [SerializeField] GameObject deathFX;
    [SerializeField] Transform parent;
    [SerializeField] int points = 5;
    Scoreboard scoreBoard;

    [SerializeField] int healthPoints = 100;
    [SerializeField] int hitsToKill = 5;

    // Start is called before the first frame update
    void Start()
    {
        AddBoxCollider();
        scoreBoard = FindObjectOfType<Scoreboard>();
    }

    private void AddBoxCollider()
    {
        Collider enemyHitbox = gameObject.AddComponent<BoxCollider>();
        enemyHitbox.isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnParticleCollision(GameObject other)
    {
        print("Particles collided with  enemy");
        
        scoreBoard.ScoreHit(points);
        hitsToKill--;
        if (hitsToKill <= 0)
        {
            EnemyDeath();
        }
    }

    private void EnemyDeath()
    {
        GameObject fx = Instantiate(deathFX, transform.position, Quaternion.identity);
        //fx.transform.parent = parent;
        Destroy(gameObject);
    }
}
