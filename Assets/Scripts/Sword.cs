using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sword : MonoBehaviour
{
    public TMP_Text Text;
    public int Count;
    private void Start()
    {
        Cursor.visible = false;
        Count = 0;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            var pos = Input.mousePosition;
            pos.z = -Camera.main.transform.position.z;
            var worldPos = Camera.main.ScreenToWorldPoint(pos);
            worldPos.z = 0;
            transform.position = worldPos;
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        ChangeText();
    }
    public void ChangeText()
    {
        Count++;
        Text.text = Count.ToString();
    }
}