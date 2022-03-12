using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LobbySetting : MonoBehaviour
{
    public Button exitBtn;
    public Button gotoMainSceneBtn;
    // Start is called before the first frame update
    void Start()
    {
        exitBtn.onClick.AddListener(delegate { gameObject.SetActive(false); });
        gotoMainSceneBtn.onClick.AddListener(delegate { SceneManager.LoadScene("00_Login"); });
    }

    public void init()
    {//설정창 초기세팅 and 기존 설정 불러오기
        gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
