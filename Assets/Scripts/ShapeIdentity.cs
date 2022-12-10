using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// INHERITANCE
public class ShapeIdentity : ShapeManager
{
// ENCAPSULATION
	private string m_nome;
	public string nome 
	{
		get { return m_nome; }
		set { m_nome = value; }
	}
	private string m_colore;
	public string colore
	{
		get { return m_colore; }
		set { m_colore = value; }
	}
	
    // Start is called before the first frame update
    void Start()
	{
		manager = GameObject.FindGameObjectWithTag("GameController");
		casellaTesto = GameObject.FindGameObjectWithTag("testo");
		etichetta = casellaTesto.GetComponent<TMP_Text>();
		
		frase = "";
		
		if (gameObject.tag == "cube")
		{
			colore = "rosso";
		}
		else if (gameObject.tag == "sphere")
		{
			colore = "verde";
		}
		else if (gameObject.tag == "capsule")
		{
			colore = "blu";
		}
		
		if (gameObject.tag == "cube")
		{
			m_nome = "cubo";
		}
		else if (gameObject.tag == "sphere")
		{
			m_nome = "sfera";
		}
		else if (gameObject.tag == "capsule")
		{
			m_nome = "capsula";
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	void ShapeInfo()
	{
		
	}
	
	public override void PrintInfo()
	{
		frase = "il mio nome è "+m_nome+" e sono di colore "+m_colore;
		etichetta.text = frase;
// POLYMORPHISM
		if (gameObject.tag=="cube")
		{
			etichetta.color = Color.red;
		}
		else if (gameObject.tag=="sphere")
		{
			etichetta.color = Color.green;
		} 
		else if (gameObject.tag=="capsule")
		{
			etichetta.color = Color.blue;
		}	
		else { etichetta.color = Color.white; }
		
		print (frase);
	}
	
	// OnMouseDown is called when the user has pressed the mouse button while over the GUIElement or Collider.
	protected void OnMouseDown()
	{
// ABSTRACTION
		PrintInfo();
		
	}
}
