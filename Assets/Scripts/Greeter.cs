using TMPro;
using UnityEngine;

public class Greeter : MonoBehaviour
{
    public TMP_Text greetText;

    private void Start()
    {
        if(DataManager.Singleton == null)
            greetText.text = $"Welcome unnamed creature!";
        else
            greetText.text = $"Welcome {DataManager.Singleton.Name}";
    }
}
