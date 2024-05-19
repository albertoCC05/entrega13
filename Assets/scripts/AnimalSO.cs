using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Object/Animals")]

public class AnimalSO : ScriptableObject
{
    public string animalName;
    public string clasification;
    public string numberOfLegs;
    public Sprite animalImage;


}
