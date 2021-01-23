using UnityEngine;
using UnityEngine.UI;

namespace Baum2.Sample
{
    public class Sample : MonoBehaviour
    {
        [SerializeField]
        private GameObject uiPrefab = null;

        private System.Collections.Generic.List<string> listElements = new System.Collections.Generic.List<string>();

        public void Start()
        {

            for (var i = 0; i < 1000; ++i)
            {
                listElements.Add(Random.Range(0, 2) + "_" + i);
            }
            ImageSample();
            ButtonSample();

        }

        public void Update()
        {

        }

        public void ImageSample()
        {

        }

        public void ButtonSample()
        {

        }


    }
}
