using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour {

	public void IrAEscena()
    {
        Debug.Log("Mi metodo fue llamado");
        SceneManager.LoadScene("SalaDeBolos");
    }
}
