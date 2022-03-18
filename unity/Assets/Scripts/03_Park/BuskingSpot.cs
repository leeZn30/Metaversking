using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuskingSpot : MonoBehaviour
{
    [SerializeField] private GameObject videoPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Character")
        {
            collision.transform.GetComponent<PlayerControl>().OnVideoPanel();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Character")
        {
            collision.transform.GetComponent<PlayerControl>().OffVideoPanel();
        }
    }

}
