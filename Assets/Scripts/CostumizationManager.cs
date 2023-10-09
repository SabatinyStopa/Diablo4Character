using UnityEngine;

namespace Diablo4Copy.Managers
{
    public class CostumizationManager : MonoBehaviour
    {
        private static int id;

        public static void Select(int id)
        {
            CostumizationManager.id = id;
        }

        private void LoadCharacter()
        {

        }
    }
}