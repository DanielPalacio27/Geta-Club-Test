using UnityEngine;

public class CarSkin
{
    Color bodyColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
    Mesh bodyMesh = null;

    Mesh wheelMesh = null;    
    Color wheelsColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);

    public CarSkin(Mesh _bodyMesh, Color _bodyColor, Mesh _wheelMesh, Color _wheelsColor)
    {
        (bodyColor, bodyMesh, wheelMesh, wheelsColor) = (_bodyColor, _bodyMesh, _wheelMesh, _wheelsColor);
    }
}
