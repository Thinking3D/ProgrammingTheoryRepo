using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShapeIdentity : MonoBehaviour
{
	public string nome;
	public string colore;
	private string frase;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	void ShapeInfo()
	{
		
	}
	
	void PrintInfo()
	{
		frase = "il mio nome è "+nome+" e sono di colore "+colore;
	}
}
