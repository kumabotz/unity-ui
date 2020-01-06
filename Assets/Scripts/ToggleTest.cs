using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ToggleTest : MonoBehaviour
{
    private ToggleGroup toggleGroupInstance;

    public Toggle CurrentSelection => toggleGroupInstance.ActiveToggles().FirstOrDefault();

    void Start()
    {
        toggleGroupInstance = GetComponent<ToggleGroup>();
        Debug.Log($"First selected {CurrentSelection.name}");
        SelectToggle(2);
    }

    public void SelectToggle(int index)
    {
        var toggles = toggleGroupInstance.GetComponentsInChildren<Toggle>();
        toggles[index].isOn = true;
    }
}