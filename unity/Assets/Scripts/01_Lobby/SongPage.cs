using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongPage : MonoBehaviour
{

    public ListPageInSongPage listPage;
    public SearchPageInSongPage searchPage;
    public AddPageInSongPage addPage;
    void Start()
    {
        
    }

    public void open()
    {
        gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
