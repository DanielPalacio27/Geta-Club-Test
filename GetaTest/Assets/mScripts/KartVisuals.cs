using UnityEngine;

public class KartVisuals : MonoBehaviour
{    
    private KartDisplay kartDisplay = null;

    void Start()
    {
        kartDisplay = GetComponent<KartDisplay>();

        if(CustomizationSystem.Instance != null)
            SetAesthetics(CustomizationSystem.Instance.currentSkin);
    }

    void SetAesthetics(CarSkin _carSkin)
    {
        for(int i = 0; i < 4; i++)
        {
            kartDisplay.wheels[i].material.color = _carSkin.wheelsColor;
            //kartDisplay.wheels[i].GetComponent<MeshFilter>().mesh = _carSkin.wheelMesh;
        }

        //kartDisplay.body.GetComponent<SkinnedMeshRenderer>().sharedMesh = _carSkin.bodyMesh;
        kartDisplay.body.material.color = _carSkin.bodyColor;
    }
}
