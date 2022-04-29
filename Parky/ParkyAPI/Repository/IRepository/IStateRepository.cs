using ParkyAPI.Models;
using System.Collections.Generic;

namespace ParkyAPI.Repository.IRepository
{
    public interface IStateRepository
    {
        // Define the crud operations that this repository should perform
        ICollection<State> GetStates();

        State GetState(int stateId);

        bool StateExists(string stateName);

        bool StateExists(int stateId);

        bool CreateState(State state);

        bool UpdateState(State state);

        bool DeleteState(State state);

        bool SaveState();
    }
}
