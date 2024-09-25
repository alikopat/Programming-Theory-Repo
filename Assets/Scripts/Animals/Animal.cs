using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    public string animalName;
    public void Walk()
    {
        Debug.Log($"{animalName} walked.");
    }

    public abstract void Sound();
}
