using UnityEngine;


/// <summary>
/// MovingTarget
/// 讓物件在兩點之間來回移動
/// 參數：
/// - distance：移動距離
/// - cycleTime：完成一次來回所需時間（秒）
/// </summary>
public class MovingTarget : MonoBehaviour
{
    [Header("Movement Settings")]
    [Tooltip("移動的最大距離")]
    public float distance = 5f;


    [Tooltip("完成一次來回的循環時間（秒）")]
    public float cycleTime = 2f;


    private Vector3 startPosition;
    private float timer;


    void Start()
    {
        startPosition = transform.position;
    }


    void Update()
    {
        if (cycleTime <= 0f) return;


        timer += Time.deltaTime;


        // 使用 PingPong 產生來回效果（0 ~ 1）
        float t = Mathf.PingPong(timer / cycleTime, 1f);


        // 沿著 X 軸移動（可自行改成 Vector3.forward 等方向）
        transform.position = startPosition + Vector3.right * distance * t;
    }
}