//Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.
//Comunicar si la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio02 : MonoBehaviour
{
    public int prod1, prod2, prod3, monto;
    int total;
    // Start is called before the first frame update
    void Start()
    {
        total = prod1 + prod2 + prod3;

        if (total <= monto)
        {
            Debug.Log("La suma de los precios no supera el monto disponible\nLe sobran $" + (monto - total));
        }

        else
        {
            Debug.Log("La suma de los precios supera el monto disponible\nLe faltan $" + (monto - total) * -1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
