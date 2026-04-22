using UnityEngine;

public class pontos_de_interesse_Script : MonoBehaviour
{
    public GameObject modalTexto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        modalTexto.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        modalTexto.SetActive(false);
    }
}
