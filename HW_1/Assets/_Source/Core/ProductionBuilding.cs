using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace _Source.Core
{
  public class ProductionBuilding: MonoBehaviour
  {
    [FormerlySerializedAs("GameResource")] public GameResource _gameResource;
    [FormerlySerializedAs("ResourceBank")] public ResourceBank _resourceBank;
    [FormerlySerializedAs("Slider")] public Slider _slider;
    [FormerlySerializedAs("ProductionTime")] public int _productionTime;
    [FormerlySerializedAs("VisualComponent")] public ResourceVisual _visualComponent;
    [FormerlySerializedAs("Button")] public Button _button;
    
    public void ButtonClick()
    {
      _button.interactable = false;
      StartCoroutine(ClickActions());
    }

    private IEnumerator ClickActions()
    {
      float timeCounter = 0;
      while (timeCounter < _productionTime)
      {
        timeCounter += Time.deltaTime;
        _slider.value = timeCounter / _productionTime;
        yield return null;
      }
      _resourceBank.ChangeResource(_gameResource, 1);
      _visualComponent.UpdateText(_resourceBank.GetResource(_gameResource).Value);
      _button.interactable = true;
      _slider.value = 0;
    }
  }
}