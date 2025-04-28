using bstate.core.Classes;

namespace bstate.tutorial.Features.Counter;

public partial class CounterState
{
    class AddActionHandler(CounterState counterState) : IActionHandler<AddAction>
    {
        public Task Execute(AddAction request)
        {
            counterState.Counter++;
            return Task.CompletedTask;
        }
    }

    public Task Add() => this.ActionChannel.Send(new AddAction());
}
