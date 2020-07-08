using System;
using UnityEngine;
using UnityEngine.Rendering;

public class ObjectColor : MonoBehaviour {

	public enum ObjectType
    {
		Body,
		Wheels
    }

	public ObjectType objType = ObjectType.Body;
    
    public Action<Color> OnSetColorAction = null;

    private KartDisplay kartDisplay = null;

    private void Start()
    {
        kartDisplay = FindObjectOfType<KartDisplay>();
		Initializer(objType);
    }

	void Initializer(ObjectType objType)
    {
        switch (objType)
        {
            case ObjectType.Body:
                OnSetColorAction += OnSetBodyColor;
                OnSetColorAction += CustomizationSystem.Instance.SetBodyColor;
                break;
            case ObjectType.Wheels:
                OnSetColorAction += OnSetWheelsColors;
                OnSetColorAction += CustomizationSystem.Instance.SetWheelsColor;
                break;
            default:
                break;
        }
    }

    void OnSetWheelsColors(Color color)
    {
        int length = kartDisplay.wheels.Length;

        for(int i = 0; i < length; i++)
        {
            Material mt = kartDisplay.wheels[i].material;
            mt.color = color;
        }
    }

    void OnSetBodyColor(Color color)
	{
        Material mt = kartDisplay.body.material;
		mt.color = color;       
    }

	void OnGetColor(ColorPicker picker)
	{
		picker.NotifyColor(GetComponent<Renderer>().material.color);
	}
}
