using UnityEditor;
using UnityEngine;
using System.IO;
using System.Collections.Generic;


public class LevelDesignEditor : EditorWindow
{
    public struct TrackTransform
    {
        Vector3 pos;
        Quaternion rot;
    }

    int width = 5;
    int height = 6;

    int zone = 1;
    int level = 1;

    int threeStars = 1;
    int twoStars = 1;

    int starsToUnlock = 1;

    string zoneName = string.Empty;
    string levelName = string.Empty;

    TrackType[,] gridMap = new TrackType[5, 6];

    Dictionary<TrackType, TrackTransform> tilesPositions = new Dictionary<TrackType, TrackTransform>();

    static int totalZones = 20;

    string debug = string.Empty;

    static string path = string.Format("/PuzzleLevelData/PuzzleLevelDB.json");

    [MenuItem("Window/Level Design Window")]
    static void Init()
    {
        LevelDesignEditor window = (LevelDesignEditor)GetWindow(typeof(LevelDesignEditor));
        AssetDatabase.Refresh();
        window.Show();
    }

    private void OnGUI()
    {

        EditorGUILayout.LabelField("Level Grid", new GUIStyle() { fontStyle = FontStyle.Bold, fontSize = 30, padding = new RectOffset(Screen.width / 4, Screen.width / 4, 10, 10) });
        GUILayout.Space(40);
        Rect lastR;
        Rect lastRBeforeGrid;

        GUILayout.Space(30);
        EditorGUIUtility.labelWidth = 40;
        level = EditorGUILayout.IntField("Level", level, GUILayout.MinWidth(10), GUILayout.ExpandWidth(false));

        EditorGUILayout.BeginVertical();

        EditorGUILayout.BeginHorizontal();
        EditorGUIUtility.labelWidth = 50;
        width = EditorGUILayout.IntField("Width", gridMap.GetUpperBound(0) + 1, GUILayout.MinWidth(10), GUILayout.ExpandWidth(false));
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        height = EditorGUILayout.IntField("Height", gridMap.GetUpperBound(1) + 1, GUILayout.MinWidth(10), GUILayout.ExpandWidth(false));
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.EndVertical();

        GUILayout.Space(15);

        if (gridMap.GetUpperBound(0) + 1 != width || gridMap.GetUpperBound(1) + 1 != height)
            gridMap = new TrackType[width, height];


        lastR = GUILayoutUtility.GetLastRect();
        lastRBeforeGrid = GUILayoutUtility.GetLastRect();
        


        #region Grid
        EditorGUILayout.BeginHorizontal();
        for (int x = 0; x < width; x++)
        {
            EditorGUILayout.BeginVertical();

            for (int y = 0; y < height; y++)
            {
                gridMap[x, y] = (TrackType)EditorGUILayout.EnumPopup(gridMap[x, y]);
                GUILayout.Space(10);
                lastR = GUILayoutUtility.GetLastRect();
                lastR.width = Screen.width / width;
                lastR.height = Screen.height / (height * 2);
                GUILayout.Space(lastR.height - 20);
                SetGridImage(lastR, gridMap[x, y]);
            }

            EditorGUILayout.EndVertical();
        }

        #endregion

        #region Buttons

        lastRBeforeGrid.width = 100;
        lastRBeforeGrid.height = 20;
        lastRBeforeGrid.x += 290;
        lastRBeforeGrid.y -= 20;

        GUIStyle newStyle = GUI.skin.button;
        newStyle.fixedWidth = 80;

        if (GUI.Button(lastRBeforeGrid, "Save"))
            SaveLevelData(levelName, gridMap, zone, level, twoStars, threeStars, starsToUnlock);

        lastRBeforeGrid.x += 90;

        if (GUI.Button(lastRBeforeGrid, "Load", newStyle))
            LoadGridLevel(zone, level);

        //lastRBeforeGrid.x += 90;

        //if (GUI.Button(lastRBeforeGrid, "Clear Data", newStyle))
        //{
        //    debug = "Clear...";
        //}

        lastRBeforeGrid.y -= 35;
        lastRBeforeGrid.x -= 100;
        lastRBeforeGrid.width = 200;
        lastRBeforeGrid.height = 30;
        EditorGUI.TextField(lastRBeforeGrid, debug);
        #endregion

    }

    void SaveLevelData(string name, TrackType[,] _gridMap, int zone, int level, int twoStars, int threeStars, int starsToUnlock)
    {
        //string debugLog = string.Empty;
        //PuzzleLevelData lvlData = new PuzzleLevelData(name, _gridMap, zone, level, twoStars, threeStars);

        //zoneData[zone - 1].name = zoneName;
        //zoneData[zone - 1].starsToUnlock = starsToUnlock;
        //zoneData[zone - 1].levelDatas[level - 1] = lvlData;

        //Memento.SaveJSONStreamingPath(zoneData, path);

        //debugLog += string.Format("Level: {0}-{1} Saved Succesfully", zone, level);
        //debug = debugLog;
        //AssetDatabase.Refresh();
    }

    void LoadGridLevel(int zone, int level)
    {
        //Memento.LoadJSONStreamingPath(ref zoneData, path);

        //TileType[,] gridMap = zoneData[zone - 1].levelDatas[level - 1].grid;

        //width = gridMap.GetUpperBound(0) + 1;
        //height = gridMap.GetUpperBound(1) + 1;
        //this.gridMap = gridMap;

        //twoStars = zoneData[zone - 1].levelDatas[level - 1].twoStarsFlips;
        //threeStars = zoneData[zone - 1].levelDatas[level - 1].threeStarsFlips;
        //levelName = zoneData[zone - 1].levelDatas[level - 1].name;

        //zoneName = zoneData[zone - 1].name;
        //starsToUnlock = zoneData[zone - 1].starsToUnlock;

        //debug = string.Format("Level: {0}-{1} Loaded Succesfully", zone, level);
    }

    void SetGridImage(Rect rect, TrackType tileType)
    {
        //Texture texture = (Texture)Resources.Load("Sprites/Animals/Chip1");
        //switch (tileType)
        //{
        //    case TileType.None:
        //        texture = (Texture)Resources.Load("Sprites/Animals/None");
        //        break;
        //    case TileType.Empty:
        //        texture = (Texture)Resources.Load("Sprites/Animals/Block");
        //        break;
        //    case TileType.Block:
        //        texture = (Texture)Resources.Load("Sprites/Animals/Block");
        //        break;
        //    case TileType.Cherrats:
        //        texture = (Texture)Resources.Load("Sprites/Animals/Cherrats");
        //        break;
        //    case TileType.Hamgo:
        //        texture = (Texture)Resources.Load("Sprites/Animals/Hamgo");
        //        break;
        //    case TileType.Cerdia:
        //        texture = (Texture)Resources.Load("Sprites/Animals/Cerdia");
        //        break;
        //    case TileType.Shaun:
        //        texture = (Texture)Resources.Load("Sprites/Animals/Shaun");
        //        break;
        //    case TileType.Burberry:
        //        texture = (Texture)Resources.Load("Sprites/Animals/Burberry");
        //        break;
        //}

        //EditorGUI.DrawPreviewTexture(rect, texture);

    }

}
