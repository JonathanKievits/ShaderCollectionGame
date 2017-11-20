using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    [SerializeField] private GameObject food;

    private GameObject pancakes;
    private float waitTime;

    void Start()
    {
        waitTime = 1.5f;
        Pancake();
    }

    private void Pancake()
    {
        pancakes = Instantiate(food, new Vector3(Random.Range(-8, 8), 0.5f, Random.Range(-5, 5)), Quaternion.identity) as GameObject;
        Destroy(pancakes.gameObject, 4.5f);
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);
        Pancake();
    }
}

