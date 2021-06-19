using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
     
{
    public float speed;
    public Vector2 playerPosition;
    public Vector2 position;
    public GameObject player; 

    // Start is called before the first frame update
    void Start()
    {
        position = gameObject.transform.position;
       

    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {

        }
        else
        {
            playerPosition = new Vector2(player.transform.position.x, transform.position.y);
        }
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, playerPosition, step);
    }    

 
}
