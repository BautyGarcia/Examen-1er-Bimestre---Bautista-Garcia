using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    public float CantTaxis;
    public float CantDias;
    public float CantLluviosos;
    float costoTotal;
    float diasMSG;
    // Start is called before the first frame update
    void Start()
    {
        if (CantLluviosos < 0 || CantLluviosos > CantDias || CantDias < 5){
            Debug.Log("No es posible esa cantidad de dias lluviosos ó Los dias no pueden ser menos que 5");
            return;
        }
        diasMSG = CantDias;
        CantDias -= CantLluviosos;

        CantLluviosos = CantLluviosos * 110;
        CantLluviosos = CantLluviosos / 15;
        CantLluviosos = CantLluviosos * 130;

        CantDias = CantDias * 90;
        CantDias = CantDias / 15;
        CantDias = CantDias * 130;

        costoTotal += CantDias;
        costoTotal += CantLluviosos;

        costoTotal = costoTotal * CantTaxis;

        Debug.Log("Una flota de "+CantTaxis+" unidades trabajando durante "+diasMSG+" días implicará un gasto de "+costoTotal+" pesos en concepto de combustible");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    
   
}
