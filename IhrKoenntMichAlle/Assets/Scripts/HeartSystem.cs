using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts;
    private int life; 
    private bool dead;
    
    public static HeartSystem instance; 

    private void Start()
    {
        life = hearts.Length;
    }

    void Update()
    {
        if (dead == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void Awake()
    {
        instance = this; 
    }

    public void Damage(int damage) // Damage function
    {
        if (life >=1)
        {
            life -= damage;
            Destroy(hearts[life].gameObject);
            if (life < 1)
            {
                dead = true; 
            }
        }
        
    }
}
