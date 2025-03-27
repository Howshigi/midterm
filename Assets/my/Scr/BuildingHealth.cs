using UnityEngine;

public class BuildingHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;

    private ScoreManager scoreManager; // อ้างอิงถึง ScoreManager

    void Start()
    {
        currentHealth = maxHealth; // ตั้งค่าเลือดเริ่มต้น

        // หา ScoreManager จาก GameObject ที่เกี่ยวข้อง (เช่น Scene)
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        Debug.Log("Building HP: " + currentHealth);

        if (currentHealth <= 0)
        {
            DestroyBuilding(); // ทำลายตึกถ้าเลือดหมด
        }
    }

    void DestroyBuilding()
    {
        Debug.Log("Building Destroyed!");
        
        // เพิ่มคะแนนเมื่อทำลายตึก
        if (scoreManager != null)
        {
            scoreManager.AddScore(1);  // เพิ่มคะแนน 1 คะแนน
        }

        Destroy(gameObject); // ลบตึกออกจากฉาก
    }
}