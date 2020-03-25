using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaGenerador : MonoBehaviour
{
    public GameObject[] tetrominos;

    // Start is called before the first frame update
    void Start()
    {
        NuevoTetromino();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NuevoTetromino()
    {
        Instantiate(tetrominos[Random.Range(0, tetrominos.Length)], transform.position, Quaternion.identity);
    }
}
