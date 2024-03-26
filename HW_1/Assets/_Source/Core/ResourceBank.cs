using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _Source.Core
{
  public class ResourceBank : MonoBehaviour
  {
    // В классе находится словарь c ключами - GameResource, и значениями ObservableInt 
    Dictionary<GameResource, ObservableInt> _resourceAmount = new Dictionary<GameResource, ObservableInt>()
    {
      { GameResource.Humans, new ObservableInt(0)},
      { GameResource.Food, new ObservableInt(0)},
      { GameResource.Wood, new ObservableInt(0)},
      { GameResource.Stone, new ObservableInt(0)},
      { GameResource.Gold, new ObservableInt(0)}
    };

    public void ChangeResource(GameResource r, int v)
    {
      _resourceAmount[r].Value += v;
    }

    public ObservableInt GetResource(GameResource r)
    {
      return _resourceAmount[r];
    }
  }
}
