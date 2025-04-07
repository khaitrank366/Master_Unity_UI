using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCard : MonoBehaviour
{
    [SerializeField] TMP_Text nameText;
    [SerializeField] TMP_Text description;

    public void UpdateName(string name)
    {
        nameText.text = name;
    }

    public void UpdateDescription(string newDescription) 
    {
        description.text = newDescription;
    }

}
