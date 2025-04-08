using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMondeda : MonoBehaviour
{
    public float dinero;
    public string moneda;
    public float montoConvertido;
    float montoMinimo = 1000;
    float Real = 173.3f;
    float Dolar = 1345;
    float Euro = 936.5f;


    // Start is called before the first frame update
    void Start()
    {
        if (dinero < montoMinimo)
        {
            Debug.Log("El monto mínimo es 1000");
            return;
        }

        if (moneda == "R")
        {
            montoConvertido = dinero *= Real;
            Debug.Log(montoConvertido);
        }
        else if (moneda == "D")
        {
            montoConvertido = dinero *= Dolar;
            Debug.Log(montoConvertido);
        }
        else if (moneda == "E")
        {
            montoConvertido = dinero *= Euro;
            Debug.Log(montoConvertido);
        }
        else
        {
            Debug.Log("Opción de moneda extranjera no valida");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}