using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextTest : MonoBehaviour
{
    public string message;
    private Text textInstance;

    void Start()
    {
        textInstance = GetComponent<Text>();
    }

    void Update()
    {
        textInstance.text = message;
    }
}