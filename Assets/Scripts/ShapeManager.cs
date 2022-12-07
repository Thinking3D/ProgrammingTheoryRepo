using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShapeManager : MonoBehaviour
{
	public string nome {get; private set; }
	public string colore {get; private set; }
	public static string frase;
	public static GameObject manager;
	public static GameObject casellaTesto;
	public static TMP_Text etichetta;
	
	
	
    // Start is called before the first frame update
    void Start()
    {
	    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	// abstraction 
	public virtual void PrintInfo()
	{
		frase = "il mio nome è "+nome+" e sono di colore "+colore;
		etichetta.text = frase;
		print (frase);
	}
	//
    
	
}
