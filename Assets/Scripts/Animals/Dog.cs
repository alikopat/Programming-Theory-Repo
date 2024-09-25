using UnityEngine;

public class Dog : Animal
{
    public override void Sound()
    {
        Debug.Log($"{animalName} barked.");
    }
}
