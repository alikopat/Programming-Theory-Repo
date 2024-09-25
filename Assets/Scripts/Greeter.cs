using TMPro;
using UnityEngine;

public class Greeter : MonoBehaviour
{
    public TMP_Text greetText;

    private void Start()
    {
        greetText.text = $"Hoşgeldin {DataManager.Singleton.Name}";
    }
}
