using System;
using UnityEngine;

public static class Models
{
    #region Player

    [Serializable]
    public class PlayerSettingsModel
    {
        [Header("Camera Settings")]
        public float SensitivityX;
        public float SensitivityY;
        public bool InvertedX;
        public bool InvertedY;

        public float yClampMin = -60f;
        public float yClampMax = 50f;

        [Header("Character")]
        public float characterRotationSmoothDamp = 1f;
    }

    #endregion
}
