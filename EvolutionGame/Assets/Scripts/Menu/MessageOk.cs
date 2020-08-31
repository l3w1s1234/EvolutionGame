using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageOk : MonoBehaviour
{
    Text txt;
    Button okBtn;


    // Start is called before the first frame update
    void Start()
    {
        okBtn = transform.Find("Ok_Button").GetComponent<Button>();
        txt = transform.Find("Text").GetComponent<Text>();
        okBtn.onClick.AddListener(deactivateObject);
        this.transform.position = new Vector3(0, 0, -15);
    }


    public void showError(string s)
    {
        txt.text = s;
        this.transform.position = new Vector3(0, 0, 0);
    }

    void deactivateObject()
    {
        this.transform.position = new Vector3(0, 0, -15);
    }
}
