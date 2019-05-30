using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdScript : MonoBehaviour
{

    Rigidbody2D rigidbody;

    public float speed = 2f;

    public float force = 300f;
    

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
     
        if (Input.GetMouseButtonDown(0))
        {
            rigidbody.AddForce(Vector2.up * force);
        }

    }

    void GameOver()
    {

        FindObjectOfType<MainMenu>().RestartOpen();
       
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Game Over
        GameOver();
    }

    private void OnBecameInvisible()
    {
        GameOver();
    }

}
