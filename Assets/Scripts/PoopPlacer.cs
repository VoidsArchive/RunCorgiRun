using UnityEngine;

public class PoopPlacer : MonoBehaviour
{
    public GameObject PoopPrefab;
    
    public void Place(Vector2 corgiPosition)
    {
        Instantiate(PoopPrefab, corgiPosition, Quaternion.identity);
    }
}
