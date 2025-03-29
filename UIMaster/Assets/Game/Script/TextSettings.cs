using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextSettings : MonoBehaviour
{
    [SerializeField] Text targetText;
    [SerializeField] TextMeshProUGUI TextMeshPro;
    public string text;
    RectTransform rt;

    private void Start()
    {
        rt = targetText.GetComponent<RectTransform>();
    }

    [ContextMenu(nameof(GetHeightAndWidth))]
    public void GetHeightAndWidth()
    {
        // Bước 1: Lấy width hiện tại
        float currentWidth = rt.rect.width;

        // Bước 2: Setup TextGenerationSettings
        TextGenerationSettings settings = targetText.GetGenerationSettings(new Vector2(currentWidth, 0f));
        settings.scaleFactor = 1f;
        settings.generateOutOfBounds = false;
        settings.updateBounds = true;

        // Bước 3: Dùng GetPreferredHeight để lấy chiều cao cần thiết
        TextGenerator textGen = new TextGenerator();
        float preferredHeight = textGen.GetPreferredHeight(text, settings);
        float preferredWidth = textGen.GetPreferredWidth(text, settings);

        Debug.Log($"PreferredHeight chính xác: {preferredHeight}");
        Debug.Log($"PreferredWidth chính xác: {preferredWidth}");

        TextMeshPro.text = text;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            GetHeightAndWidth();
        }
    }
}


