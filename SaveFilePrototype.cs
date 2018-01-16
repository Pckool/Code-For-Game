using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveFilePrototype : MonoBehaviour
{

    public static SaveFilePrototype control;

    public float health = 10;
    public float speed = 10;

    private void Awake()
    {
        health = 10;
        speed = 8;

        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if(control != this)
        {
            Destroy(gameObject);
        }
    }
    void Start ()
    {

        
    }
	

	void Update ()
    {
		
	}

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 60), "Health: " + health);
        GUI.Label(new Rect(10, 60, 200, 60), "Speed: " + speed);

        if(GUI.Button(new Rect(10, 110, 200, 60), "Apply"))
        {
               health = UnityEngine.Random.Range(10, 20);
               speed = UnityEngine.Random.Range(8, 12);
        }

        if (GUI.Button(new Rect(10, 160, 200, 60), "Save"))
        {
            Save();
        }

        if (GUI.Button(new Rect(10, 210, 200, 60), "Load"))
        {
            Load();
        }

    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        PlayerData data = new PlayerData();
        data.health = health;
        data.speed = speed;

        bf.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data =(PlayerData)bf.Deserialize(file);
            file.Close();

            health = data.health;
            speed = data.speed;
        }
    }
}

[Serializable]
class PlayerData
{
    public float health;
    public float speed;
}