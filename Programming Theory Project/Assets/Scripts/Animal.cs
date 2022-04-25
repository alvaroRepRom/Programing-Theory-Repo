using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    private string animalName;
    public string AnimalName
    {
        set { animalName = value; }
        get { return animalName; }
    }

    private string sound;
    public string Sound
    {
        set { sound = value; }
        get { return sound; }
    }

    protected virtual void Jump() { }
    protected string Talk()
    {
        return "The " + AnimalName + " says: " + Sound;
    }
}
