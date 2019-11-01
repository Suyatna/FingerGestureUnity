using UnityEngine;

public class Rotations : MonoBehaviour
{

    private GameObject obj;
    private int angle;
    private bool n, e, s, w;

    private void Awake()
    {
        obj = this.gameObject;
    }

    private void Update()
    {
        
    }

    public void DoRotation(int angle)
    {
        this.angle = angle;
        obj.transform.Rotate(0, angle, 0);
    }
}
