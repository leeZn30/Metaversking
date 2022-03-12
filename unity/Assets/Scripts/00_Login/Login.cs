using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Login : MonoBehaviour
{
    public Button joinBtn;
    public Button loginBtn;
    public TMP_InputField id_input;
    public TMP_InputField password_input;
    public Join join;

    // Start is called before the first frame update
    void Start()
    {
        joinBtn.onClick.AddListener(delegate { join.OpenJoinPanel(); });
        loginBtn.onClick.AddListener(OnClickLoginButton);
    }
    void OnClickLoginButton()
    {
        //로그인 버튼이 눌렸을 때 
        SceneManager.LoadScene("01_Lobby");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
