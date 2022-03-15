using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SongFolder : MonoBehaviour
{
    public string folderName;
    public int id;
    public Image img;
    public TextMeshProUGUI name_text;
    private Button btn;

    void Start()
    {
        btn = GetComponent<Button>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
