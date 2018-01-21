//using UnityEngine;

public class QuestionType
{
    public int score { get; private set; }

    public void GainPoint() { score++; }
    public void LosePoint() { score--; }

    public void GainMultiplePoints(int numOfPoints)
    {
        if (score <= 0)
        {
            //Debug.LogError("This method is for awarding points, not subtracting them. Returning...");
            return;
        }
        score += numOfPoints;
    }
    public void LoseMultiplePoints(int numOfPoints)
    {
        if (score <= 0)
        {
            //Debug.LogError("This method is for subtracting points, not awarding them. Returning...");
            return;
        }
        score -= numOfPoints;
    }
}
