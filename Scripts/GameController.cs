using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public static GameController Instance { get; private set; }
    public GameObject JuegoPrefab;
    public Sprite[] Domino;
    public int Dominos = 28;
    private Image _dominoImage = null


    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        Instantiate(JuegoPrefab, transform.position, Quaternion.identity);
        int i = 0;
        while(i < Dominos)
        {
            _dominoTiles = 
            _dominoImage.sprite 
        }
    }
}
