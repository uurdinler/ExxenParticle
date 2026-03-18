using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(FeedbackManager))]
public class FeedbackManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        // Standart Inspector alanlarını çiz (Listeleri görmeye devam etmen için)
        DrawDefaultInspector();

        FeedbackManager manager = (FeedbackManager)target;

        EditorGUILayout.Space();
        EditorGUILayout.LabelField("Test Kontrolleri", EditorStyles.boldLabel);

        // Yanlış Butonu (Biraz ayırmak için rengini değiştirebilirsin)
        GUI.backgroundColor = Color.red;
        if (GUILayout.Button("Play Yanlış"))
        {
            manager.PlayYanlis();
        }

        // Doğru Butonları
        GUI.backgroundColor = Color.green;
        if (GUILayout.Button("Play Doğru V1")) manager.PlayDogruV1();
        if (GUILayout.Button("Play Doğru V2")) manager.PlayDogruV2();
        if (GUILayout.Button("Play Doğru V3")) manager.PlayDogruV3();
        if (GUILayout.Button("Play Doğru V4")) manager.PlayDogruV4();

        GUI.backgroundColor = Color.white; // Rengi sıfırla
        if (GUILayout.Button("Hepsini Kapat"))
        {
            // StopAllFeedbacks private ise bunu public yapman gerekebilir
            // Veya yeni bir public metod ekleyebilirsin
            manager.SendMessage("StopAllFeedbacks");
        }
    }
}