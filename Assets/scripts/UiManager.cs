using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public AnimalSO[] animalsArray;

    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI clasificationText;
    [SerializeField] private TextMeshProUGUI numberOfLegsText;
    [SerializeField] private Image animalImage;


    public void ChangeTexts(int animalArrayIndex)
    {
        nameText.text = animalsArray[animalArrayIndex].animalName;
        clasificationText.text = animalsArray[animalArrayIndex].clasification;
        numberOfLegsText.text = animalsArray[animalArrayIndex].numberOfLegs;
        animalImage.sprite = animalsArray[animalArrayIndex].animalImage;

    }
}
