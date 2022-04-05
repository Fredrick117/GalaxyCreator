using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Galaxy Galaxy;

    public string[] StarSystemNames = new string[] {
        "Ahnar",
        "Zubana",
        "Komle",
        "Usta",
        "Zyb",
        "Sama",
        "Alhim",
        "Falha",
        "Zamok",
        "Korolis Ray",
        "FR-9097b",
        "Vovio",
        "Ovhil",
        "Cassio",
        "Urgarius",
        "Irel",
        "Daryus",
        "Noxus",
        "Demyr",
        "Ionia",
        "Demacia",
        "Lambda Paradisus",
        "Chi Caelum",
        "Meritum",
        "Harena",
        "Hio",
        "Urs",
        "Gav",
        "8970987c",
        "Ymir",
        "Hildr",
        "Signy",
        "Siv",
        "Skadi",
        "Nanna",
        "Papur",
        "Atla",
        "Eir",
        "Freya",
        "Saga",
        "Skul",
        "Var",
        "Bol",
        "Flot",
        "Duble",
        "Snotra",
        "Yggdrasil",
        "Eostre",
        "Tyr",
        "Yngvi",
        "Ull",
    };

    //private XDocument GalaxyData;

    private void Awake()
    {
        //GameData = new GalaxyGameData();

        //string filePath = Application.persistentDataPath + "/galaxy.data";

        //FileStream dataStream = new FileStream(filePath, FileMode.Create);

        //BinaryFormatter formatter = new BinaryFormatter();
        //formatter.Serialize(dataStream, GameData);
        //dataStream.Close();

        //if (File.Exists(filePath))
        //{
        //    FileStream openStream = new FileStream(filePath, FileMode.Open);

        //    GalaxyGameData data2 = formatter.Deserialize(openStream) as GalaxyGameData;

        //    openStream.Close();

        //    foreach (string s in data2.StarSystemNames) 
        //    {
        //        Debug.Log(s);
        //    }
        //}


        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        Galaxy = new Galaxy();
    }

    public void AddSystem(StarSystem system)
    {
        Galaxy.StarSystems.Add(system);
    }

    public void AddPlanet(StarSystem system, Object obj)
    {
        // Todo: refactor
        Galaxy.StarSystems[Galaxy.StarSystems.IndexOf(system)].CelestialObjects.Add(obj);
    }

    /// <summary>
    /// Generates an XML file that stores data that has been generated by the SystemGenerator class.
    /// </summary>
    //public void GenerateXMLFile()
    //{
    //    var xmlSettings = new XmlWriterSettings() { Indent = true };

    //    using (XmlWriter writer = XmlWriter.Create("galaxydata.xml", xmlSettings))
    //    {
    //        writer.WriteStartDocument();
    //        writer.WriteStartElement("Galaxy");
    //        writer.WriteElementString("StarSystem", "Sol");
    //        writer.WriteEndElement();
    //        writer.WriteEndDocument();
    //    }
    //}
}