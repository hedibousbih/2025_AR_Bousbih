using UnityEngine;

public class PlantGrowthHandler : MonoBehaviour
{
    public GameObject smallModel;
    public GameObject bigModel;
    private bool isGrown = false;

    void Start()
    {
        smallModel.SetActive(true);
        bigModel.SetActive(false);
    }

    public void WaterPlant()
    {
        if (isGrown) return;

        smallModel.SetActive(false);
        bigModel.SetActive(true);
        isGrown = true;
    }
}
