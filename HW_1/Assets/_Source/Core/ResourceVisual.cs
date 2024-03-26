using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace _Source.Core
{
  public class ResourceVisual : MonoBehaviour
  {
    private GameManager _game;
    public GameResource _gameResource;
    public TextMeshProUGUI _text;
    public ResourceBank _resourceBankVisual;

    void Start()
    {
      int valueToUpdate = _resourceBankVisual.GetResource(_gameResource).Value;
      _resourceBankVisual.GetResource(_gameResource).OnClick += UpdateText;
      UpdateText(valueToUpdate);
    }

    private void UpdateText(int value)
    {
      _text.text = value.ToString();
    }

    public void ButtonClick()
    {
      _resourceBankVisual.GetResource(_gameResource).Value++;
      UpdateText(_resourceBankVisual.GetResource(_gameResource).Value);
    }
  }
}
