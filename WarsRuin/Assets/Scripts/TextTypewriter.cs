using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTypewriter : MonoBehaviour
{
    public float delay = 0.1f;
    [TextArea]public string fullText;
    private string _currentText = "";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText ()
    {
        var textComponent = this.GetComponent<Text>();
        textComponent.text = "";
        for (int i = 0; i < fullText.Length; i++)
        {
            _currentText = fullText.Substring(0, i);
            textComponent.text = _currentText;
            yield return new WaitForSeconds(delay);
        }
    }
}