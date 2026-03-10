using System.Collections;
using UnityEngine;

public class BeerPlacer : MonoBehaviour
{
    public GameObject beerPrefab;
    void Update()
    {
        StartCoroutine(CountdownUntilCreation());
    }

    IEnumerator CountdownUntilCreation()
    {
        yield return new WaitForSeconds(3f);
        Place();
    }

    private void Place()
    {
        Instantiate(beerPrefab, SpawnTools.RandomLocationWorldSpace(), Quaternion.identity);
    }
}
