using UnityEngine;

public class TapToGrow : MonoBehaviour
{
    public GameObject smallModel;
    public GameObject bigModel;

    private bool isGrown = false;

    void Start()
    {
        smallModel.SetActive(true);
        bigModel.SetActive(false);
    }

    void OnMouseDown()
    {
        if (!isGrown)
        {
            smallModel.SetActive(false);
            bigModel.SetActive(true);
            isGrown = true;
            Debug.Log("🌿 La plante a grandi !");
        }
    }
}
