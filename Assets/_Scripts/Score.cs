using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    private Hungry hungry;
    private float score;
    public float getScore { get { return score; } }

    void Start()
    {
        hungry = GetComponent<Hungry>();
    }

    void FixedUpdate()
    {
        score = hungry.Amount + 0.03f;
    }
}
