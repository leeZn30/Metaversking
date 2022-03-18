using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoPanel : MonoBehaviour
{

    // 카메라 모드
    // 0 - 축소, 1 - 전체
    [SerializeField] public int mode = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ScaleChangePanel()
    {
        if (mode == 0)
        {
            mode = 1;
            gameObject.transform.localScale = new Vector3(3, 3, 1);
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -80, 1);
        }
        else if (mode == 1)
        {
            mode = 0;
            gameObject.transform.localScale = new Vector3(1, 1, 1);
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -30, 1);

        }
        
    }
}
