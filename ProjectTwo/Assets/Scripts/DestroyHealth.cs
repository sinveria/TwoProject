using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyHealth : MonoBehaviour
{
    GameObject healthsearch;
    int health;
    private void Start()
    {
        healthsearch = GameObject.Find("PacksHealth");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.transform.name == "BorderBottom")
        {
            health = healthsearch.transform.childCount;
            for (int i = health - 1; i > -1; i--)
            {
                Destroy(healthsearch.transform.GetChild(i).gameObject);
            }
        }
    }
}
