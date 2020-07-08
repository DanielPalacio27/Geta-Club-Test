using UnityEngine;

public class JumpPowerUP : ArcadeKartPowerup
{
    public void OnAddForce()
    {
        otherGO.GetComponent<Rigidbody>().AddForce(Vector3.up * 20f + transform.forward * 1.5f, ForceMode.Impulse);
        otherGO = null;
    }
}
