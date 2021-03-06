using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PersistentData : MonoBehaviour
{
    public static PersistentData data;
    public TMP_InputField inputField;

    public string playerName;
    private void Awake()
    {
        if (data != null)
        {
            Destroy(gameObject); 
        }
        data = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SetName()
    {
        playerName = inputField.text;
        SceneManager.LoadScene(1);
    }

}
