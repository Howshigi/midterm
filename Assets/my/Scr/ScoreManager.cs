using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0; // เก็บคะแนน

    // ฟังก์ชั่นเพิ่มคะแนน
    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Score: " + score);  // สำหรับแสดงคะแนนใน Console
    }
}