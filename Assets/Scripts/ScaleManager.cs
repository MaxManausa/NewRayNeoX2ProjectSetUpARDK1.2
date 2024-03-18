using UnityEngine;

public class ScaleManager : MonoBehaviour
{
    public void SetScaleTo135()
    {
        SetScale(135f);
    }

    public void SetScaleTo45()
    {
        SetScale(45f);
    }

    public void SetScaleTo70()
    {
        SetScale(70f);
    }

    private void SetScale(float scaleValue)
    {
        transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);
    }
}

