using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.SceneManagement;

public class UIHandler : MonoBehaviour
{

    [SerializeField] private TMP_InputField InputField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeName()
    {
        Manager.Instance._name = InputField.text;
    }

    public void ChangeScene()
    {
        EditorSceneManager.LoadScene(1);
    }
}
