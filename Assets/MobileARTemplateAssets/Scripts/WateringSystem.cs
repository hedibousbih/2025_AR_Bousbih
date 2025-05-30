using UnityEngine;

public class WateringSystem : MonoBehaviour
{
    public Camera arCamera;
    private bool wateringMode = false;

    public void ActivateWateringMode()
    {
        wateringMode = true;
        Debug.Log("🌧️ Mode arrosage activé !");
    }

    void Update()
    {
        if (wateringMode && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = arCamera.ScreenPointToRay(Input.GetTouch(0).position);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                PlantGrowthHandler plant = hit.transform.GetComponentInParent<PlantGrowthHandler>();

                if (plant != null)
                {
                    plant.WaterPlant();
                    wateringMode = false; // termine l’arrosage
                    Debug.Log("✅ Arrosage terminé");
                }
                else
                {
                    Debug.Log("❌ Aucun script PlantGrowthHandler trouvé");
                }
            }
        }
    }
}
