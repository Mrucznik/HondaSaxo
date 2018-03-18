using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dym : MonoBehaviour
{

    public Text lol;
	// Use this for initialization
	void Start () {
	    switch (StoryManager.GetInstance().kokoko)
	    {
	        case 0: //stołówka, intensywna terapia
                lol.text = "Szokująca wiadomość! W wyniku awarii w szpitalu zginęło 32 dzieci." +
	                       "Inkubatory nie były zasilane, co doprowadziło do śmierci noworodków.";
                break;
	        case 1: //duży pokój (Dimitrij)
                lol.text = "Szokująca wiadomość! W wyniku awarii w szpitalu zginęło 54 ludzi." +
                           "Maszyny podtrzymujące życie nie były zasilane, co doprowadziło do zgonu pacjentów."; 
	            break;
	        case 2: //koniec korytarza
                lol.text = "Szokująca wiadomość! W wyniku awarii w szpitalu zginęło 86 ludzi w tym 32 dzieci." +
                           "Inkubatory i maszyny podtrzymujące życia nie były zasilane, co doprowadziło do śmierci pacjentów." +
                           "Z magazynu w szpitalu zginęły przy okazji leki oraz spirytus. Służby podejrzewają o współudział w kradzieży elektryka Elektrija, który był obecny w dniu awarii w budynku.";
	            break;
	        case 3: //na lewo (agregat)
                lol.text = "Szokująca wiadomość! W wyniku awarii zasilania w więzieniu doszło do ucieczki stulecia." +
                           "Prawie połowa więźniów uciekła i znajduje się teraz na wolności. Uprasza się o zachowanie ostrożności poruszając się dzisiaj po terenie miasta.";
	            break;
	        case 4: //na prawo (bramy)
	            lol.text = "Szokująca wiadomość! W wyniku awarii zasilania w więzieniu doszło do śmierci 15 więźniów, którzy znajdowali się na skrzydle szpitalnym.";
	            break;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
