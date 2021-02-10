using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class Singleton : MonoBehaviour
{
    // Start is called before the first frame update
    private static Singleton instance;

    protected Singleton() { }
    public string value;

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
                instance = GameObject.FindObjectOfType<Singleton>();
            return instance;
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}

public class TextRetrieve
{
    TextAsset textAsset;

    public TextRetrieve()
    {
    }

    public void DataRetrieval()
    {
        Singleton.Instance.value = Application.persistentDataPath;
        textAsset = Resources.Load(Singleton.Instance.value) as TextAsset;
    }
}
