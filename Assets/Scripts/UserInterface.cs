using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UserInterface : MonoBehaviour
{
    [SerializeField] private Text animalText;
    [SerializeField] private Text catText;
    [SerializeField] private Text dogText;

    public void GoToMainScene()
    {
        StoreNames();
        SceneManager.LoadScene(1);
    }

    private void StoreNames()
    {
        DataPersistence.Instance.animalName = animalText.text;
        DataPersistence.Instance.catName = catText.text;
        DataPersistence.Instance.dogName = dogText.text;
    }
}
