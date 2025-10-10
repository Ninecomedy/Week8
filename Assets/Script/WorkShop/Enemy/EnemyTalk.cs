using TMPro;
using UnityEngine;

public class EnemyTalk : Enemy
{
    public TMP_Text interactionTextUI;
    public TMP_Text WordTextUI;

    public void Update()
    {     
        Turn(player.transform.position - transform.position);
    }
    
    void CloseWord()
    {
        WordTextUI.gameObject.SetActive(false);
    }
}
