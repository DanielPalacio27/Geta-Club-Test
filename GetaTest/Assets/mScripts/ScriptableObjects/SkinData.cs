using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Visuals/SkinsData")]
public class SkinsData : ScriptableSingleton<SkinsData>
{
    public List<Mesh> wheelsSkins = new List<Mesh>();
    public List<Texture2D> wheelsTextures = new List<Texture2D>();

    public List<Mesh> bodySkins = new List<Mesh>();
    public List<Texture2D> bodyTextures = new List<Texture2D>();
}
