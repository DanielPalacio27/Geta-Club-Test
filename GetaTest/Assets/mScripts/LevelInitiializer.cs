using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInitiializer : MonoBehaviour
{
    [SerializeField] GameObject rigthTrack = null;
    [SerializeField] GameObject leftTrack = null;
    [SerializeField] GameObject straigthTrack = null;

    void Start()
    {
        GenerateLevel(new TrackType[2, 2] { { TrackType.LeftCurve, TrackType.Straight }, { TrackType.Straight, TrackType.Straight } });
    }

    void GenerateLevel(TrackType[,] trackMap)
    {
        float yOffset = 10f;
        float xOffset = 10f;
        xOffset = 0;
        

        Vector3 pivot = Vector3.zero;
        float width = trackMap.GetUpperBound(0) + 1;
        float height = trackMap.GetUpperBound(1) + 1;

        for (int x = 0; x < width; x++)
        {
            for(int y = 0; y < height; y++)
            {
                TrackType currentTrack = trackMap[x, y];

                Vector3 pos = new Vector3(pivot.x + (xOffset * x), 0f, yOffset * y + pivot.y);
                SpawnTrack(pos, currentTrack);
            }
        }
    }

    void SpawnTrack(Vector3 _pos, TrackType type)
    {
        switch (type)
        {
            case TrackType.Straight:
                Instantiate(straigthTrack, _pos, Quaternion.identity);
                break;
            case TrackType.LeftCurve:
                Instantiate(leftTrack, _pos, Quaternion.identity);
                break;
            case TrackType.RightCurve:
                Instantiate(rigthTrack, _pos, Quaternion.identity);
                break;
            default:
                break;
        }
    }

    void Update()
    {
        
    }
}
