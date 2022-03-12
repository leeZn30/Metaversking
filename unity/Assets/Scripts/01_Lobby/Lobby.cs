using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Lobby : MonoBehaviour
{
    public Button settingBtn;
    public Button gotoGroundBtn;
    public Button gotoMusicListBtn;
    public Button characterSetBtn;

    public LobbySetting lobbySetting;
    void Start()
    {
        settingBtn.onClick.AddListener(delegate { lobbySetting.init(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
