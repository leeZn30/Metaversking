using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Join : MonoBehaviour
{
    public Button exitBtn;
    public Button joinBtn;
    public inputObject[] inputObjects;

    private bool isOkay =false;
    // Start is called before the first frame update
    void Start()
    {
        joinBtn.onClick.AddListener(OnClickJoinButton);
        exitBtn.onClick.AddListener(OnClickExitButton);
    }
    public void OpenJoinPanel()
    {
        gameObject.SetActive(true);
        for(int i=0; i<inputObjects.Length; i++)
        {
            inputObjects[i].init();
        }


    }
    void OnClickJoinButton()
    {
        if (isOkay == true)
        {
            gameObject.SetActive(false);
        }
        else
        {
            
        }
    }
    void OnClickExitButton()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
