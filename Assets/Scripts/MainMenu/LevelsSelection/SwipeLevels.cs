using UnityEngine;
using UnityEngine.UI;

public class SwipeLevels : MonoBehaviour
{
    [SerializeField]
    private GameObject scrollBar;

    [SerializeField]
    private float scrollPosition = 0;
    [SerializeField]
    private float[] position;

    private void Update()
    {
        position = new float[transform.childCount];
        float distance = 1f / (position.Length - 1f);

        for (int i = 0; i < position.Length; i++)
        {
            position[i] = distance * i;
        }

        if (Input.touches.Length > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                scrollPosition = scrollBar.GetComponent<Scrollbar>().value;
            }
            else
            {
                for (int i = 0; i < position.Length; i++)
                {
                    if (scrollPosition < position[i] + (distance / 2) && scrollPosition > position[i] - (distance / 2))
                    {
                        scrollBar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollBar.GetComponent<Scrollbar>().value, position[i], .1f);
                    }
                }
            }
        }
        else
        {
            if (Input.GetMouseButton(0))
            {
                scrollPosition = scrollBar.GetComponent<Scrollbar>().value;
            }
            else
            {
                for (int i = 0; i < position.Length; i++)
                {
                    if (scrollPosition < position[i] + (distance / 2) && scrollPosition > position[i] - (distance / 2))
                    {
                        scrollBar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollBar.GetComponent<Scrollbar>().value, position[i], .1f);
                    }
                }
            }
        }
    }
    //TODO: сделать кнопки запуска уровня
}
