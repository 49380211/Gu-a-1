using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculos_Personalizados : MonoBehaviour
{

    public float num1;
    public float num2;
    public float resultado;


    // Start is called before the first frame update
    void Start()
    {
        resultado = num1 + num2;
        Debug.Log("El resultado de la suma entre " + num1 + num2 + " es " + resultado);
        resultado = num1 - num2;
        Debug.Log("El resultado de la resta entre " + num1 + num2 + " es " + resultado);
        resultado = num1 * num2;
        Debug.Log("El resultado de la multiplicaciòn entre " + num1 + num2 + " es " + resultado);
        resultado = num1 / num2;
        Debug.Log("El resultado de la divisiòn entre " + num1 + num2 + " es " + resultado);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
