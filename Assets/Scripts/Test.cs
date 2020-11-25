using UnityEngine;

public class Test : MonoBehaviour
{
    // playerMovementController - camelCase
    // PlayerMovementController - PascalCase
    // player_movement_controller - snake_case
    // m_playerMovementController - Hungarian notation

    // int, float, string, bool, long (duze liczby calkowite)
    // GameObject, Transform

    // akcesor typ nazwaZmiennej = wartosc inicjalizacyjna
    private int stanLicznika = 50000;
    private float stanZuzyciaOpon = 0.3f;

    private void Start()
    {
        
    }

    private int Jedz()
    {
        int predkosc = 60;
        return predkosc;
    }

    private void ZamknijDrzwi(int ktoreDrzwi)
    {
        if(ktoreDrzwi == 0)
        {
            Debug.Log("Milej jazdy!");
        }
    }

}

//private void Podsumuj()
//{

//}
