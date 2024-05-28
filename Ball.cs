using System.Collections; using
System.Collections.Generic;
using UnityEngine; public class
Ball : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
    }
    private void OnMouseDown()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().ScoreUp();
        Destroy(gameObject);
    }
} 