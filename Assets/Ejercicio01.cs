//Crea un programa que permita ingresar por Inspector dos valores enteros y responda si son iguales o no lo son.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio01 : MonoBehaviour
{
    public int num1, num2;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 == num2)
        {
            Debug.Log("Los números son iguales");
        }

        else
        {
            Debug.Log("Los números no son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
