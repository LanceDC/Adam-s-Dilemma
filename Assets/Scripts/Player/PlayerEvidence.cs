using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerEvidence : MonoBehaviour
{
    public List<GameObject> evidenceCollected;
    public TMP_Text meshPro;
    public List<bool> evidenceHasBeenCrossed = new List<bool>();

    private int burnCount = 0;
    private int photoObjectCount = 0;
    private LastChoiceUsed lastChoice;

    [SerializeField] private AudioSource source;

    public void AddEvidence(GameObject obj)
    {
        //See if the player has already inspected this evidence
        if(!evidenceCollected.Contains(obj))
        {
            //Add it to a list of inspected evidence
            evidenceCollected.Add(obj);
            meshPro.text += evidenceCollected[evidenceCollected.Count - 1].name + "\n";
            evidenceHasBeenCrossed.Add(false);
        }
    }

    //When evidence has been destroyed or taken a picture of, show the player this by crossing though it on the text on the screen
    public void MarkOffEvidence(GameObject obj)
    {
        //Check to see if the evidence destroyed has been found
        if (!evidenceCollected.Contains(obj))
            return;

        string newList = "";
        for (int i = 0; i < evidenceCollected.Count; i++)
        {
            //Check to see if this new object has been collected or the evidence has allready been croussed out
            if (obj.name == evidenceCollected[i].name || evidenceHasBeenCrossed[i])
            {
                if (!source.isPlaying)
                    source.Play();

                //Crosses out this evidence on the list of evidence on the screen
                newList += "<s>" + evidenceCollected[i].name + "</s>" + "\n";
                evidenceHasBeenCrossed[i] = true;
                continue;
            }
            newList += evidenceCollected[i].name + "\n";
        }
        meshPro.text = newList;
        CheckEvidenceDeltWith();

    }
    
    public void IncreaseBurnCount()
    {
        burnCount++;
        lastChoice = LastChoiceUsed.Burn;
    }

    public void IncreasePhotoCount()
    {
        photoObjectCount++;
        lastChoice = LastChoiceUsed.Photo;
    }

    private void CheckEvidenceDeltWith()
    {
        //See how many evidence items have been destroyed
        int evidenceItemsDeltWith = photoObjectCount + burnCount;

        //If all of the evidence items found, have been destroyed, end the game
        if(evidenceItemsDeltWith >= evidenceCollected.Count)
        {
            GameManager.PausePlayer();
            //Show text on the screen based on how they destroyed the last imaged showing their choice in this dilema
            GameManager.instance.GameOver(lastChoice);
        }
    }


}

public enum LastChoiceUsed
{
    Burn,
    Photo,
    Leave
}

