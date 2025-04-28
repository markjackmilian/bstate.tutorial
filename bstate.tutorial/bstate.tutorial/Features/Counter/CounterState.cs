using bstate.core;
using bstate.core.Services;

namespace bstate.tutorial.Features.Counter;

public partial class CounterState(IActionBus actionChannel) : BState(actionChannel)
{
    public int Counter { get; private set; } = 100;
}