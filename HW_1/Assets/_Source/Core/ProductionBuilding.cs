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
    
    public void ButtonClick()
    {
      _resourceBank.ChangeResource(_gameResource, 1);
      _visualComponent.UpdateText(_resourceBank.GetResource(_gameResource).Value);
    }
  }
}