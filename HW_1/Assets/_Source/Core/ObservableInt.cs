using System;
using _Source.Core;

namespace _Source.Core
{
  public class ObservableInt
  {
    private int _value;
    public Action<int> OnClick;
    public ObservableInt(int value)
    {
      _value = value;
    }
    public int Value
    {
      get => _value;
      set
      {
        //OnClick.Invoke(value);
        _value = value;
      }
    }
  }
}
