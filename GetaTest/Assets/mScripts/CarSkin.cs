using UnityEngine;

public class CarSkin
{
    public Color bodyColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
    public Mesh bodyMesh = null;
    public Texture2D bodyTexture = null;

    public Mesh wheelMesh = null;    
    public Color wheelsColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
    public Texture2D wheelTexture = null;

    public CarSkin() { }
    public CarSkin(Mesh _bodyMesh, Color _bodyColor, Mesh _wheelMesh, Color _wheelsColor)
    {
        (bodyColor, bodyMesh, wheelMesh, wheelsColor) = (_bodyColor, _bodyMesh, _wheelMesh, _wheelsColor);
    }
}
