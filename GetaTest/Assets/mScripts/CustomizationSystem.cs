using UnityEngine;

public class CustomizationSystem : Singleton<CustomizationSystem>
{
    public CarSkin currentSkin = new CarSkin();

    public void SetBodyColor(Color _color)
        =>
        currentSkin.bodyColor = _color;

    public void SetWheelsColor(Color _color)
        =>
        currentSkin.wheelsColor = _color;

    public void SetWheelMesh(Mesh mesh)
        =>
        currentSkin.wheelMesh = mesh;

    public void SetBodyMesh(Mesh mesh)
        =>
        currentSkin.bodyMesh = mesh;
    void SetCurrentSkin(Mesh wheelMesh, Mesh bodyMesh, Color wheelColor, Color meshColor)
    {        
    }

}
