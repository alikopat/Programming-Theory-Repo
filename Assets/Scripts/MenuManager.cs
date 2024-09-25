using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField nameField;
    public void StartGame()
    {
        DataManager.Singleton.Name = nameField.text;
        SceneManager.LoadScene("Game");
    }
}
