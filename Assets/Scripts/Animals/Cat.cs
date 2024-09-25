using UnityEngine;

public class Cat : Animal
{
    public override void Sound()
    {
        Debug.Log($"{animalName} meowed.");
    }
}
