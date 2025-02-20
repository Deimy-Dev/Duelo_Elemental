using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DueloElemental : MonoBehaviour
{
    public enum Element { Fire, Water, Earth, Air }

    public Image playerChoiceImage, enemyChoiceImage;
    public Sprite fireSprite, waterSprite, earthSprite, airSprite;
    public TMP_Text resultText;

private Element playerChoice;
    private Element enemyChoice;

    public void PlayerSelect(int choice)
    {
        playerChoice = (Element)choice;
        playerChoiceImage.sprite = GetSprite(playerChoice);

        EnemySelect();
        DetermineWinner();
    }

    void EnemySelect()
    {
        enemyChoice = (Element)Random.Range(0, 4);
        enemyChoiceImage.sprite = GetSprite(enemyChoice);
    }

    void DetermineWinner()
    {
        if (playerChoice == enemyChoice)
        {
            resultText.text = "Empate!";
            return;
        }

        if ((playerChoice == Element.Fire && enemyChoice == Element.Earth) ||
            (playerChoice == Element.Water && enemyChoice == Element.Fire) ||
            (playerChoice == Element.Earth && enemyChoice == Element.Water) ||
            (playerChoice == Element.Air && enemyChoice == Element.Earth))
        {
            resultText.text = "¡Ganaste!";
        }
        else
        {
            resultText.text = "Perdiste...";
        }
    }

    Sprite GetSprite(Element element)
    {
        switch (element)
        {
            case Element.Fire: return fireSprite;
            case Element.Water: return waterSprite;
            case Element.Earth: return earthSprite;
            case Element.Air: return airSprite;
            default: return null;
        }
    }
}
