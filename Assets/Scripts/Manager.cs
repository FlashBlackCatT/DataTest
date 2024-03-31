using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class Manager : MonoBehaviour
{
    public static Manager Instance;
    public string _name;
    public string _highscoreName;
    public int _highscore;


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    class SaveData
    {
        public string _highscoreName;
        public int _highscore;
    }

    public void SaveBest()
    {
        SaveData data = new SaveData();
        data._highscoreName = _highscoreName;
        data._highscore = _highscore;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            _highscoreName = data._highscoreName; 
            _highscore = data._highscore;
        }

        
    }
}
