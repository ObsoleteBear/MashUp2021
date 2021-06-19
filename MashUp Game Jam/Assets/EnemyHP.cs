using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int enemyHP = 5;
    public bool enemyIsDead = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("k"))
        {
            enemyHP = 0; 
        }

            if (enemyHP < 1)
        {
            enemyIsDead = true;

        }
        if (enemyIsDead == true)
        {
           Destroy(gameObject);
        }
    }
}
