using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(rotate); // when clicked, go to print
    }

    void rotate() {
        Debug.Log("button has been clicked");
        transform.Rotate(new Vector3(150, 300, 60));
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
